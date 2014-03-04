using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;
using System.Data.Entity.Infrastructure;
using Diagnostics_FP.ViewModels;

namespace Diagnostics_FP.Controllers
{
    public class ClinicController : Controller
    {
        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();
        //
        // GET: /Clinic/
        [Authorize]
        public ActionResult ClinicGroupList(int clinicGroupID, string sortOrder, string currentFilter = "", string searchString = "", int? pageNum = 0)
        {
            ViewBag.ClinicGroupID = clinicGroupID;
            ViewBag.ClinicList = null;
            ViewBag.CurrentSort = sortOrder;
            ViewBag.DescriptionSortParm = sortOrder == "Description" ? "Description Desc" : "Description";
            ViewBag.INNSortParm = sortOrder == "INN" ? "INN Desc" : "INN";
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                pageNum = 0;
            }
            ViewBag.CurrentFilter = searchString;
            var objs = from o in db.GetClinicGroupList()
                       select o;
            if (!String.IsNullOrEmpty(searchString))
            {
                objs = objs.Where(o => o.Description.ToUpper().Contains(searchString.ToUpper()) ||
                    o.INN.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "INN":
                    objs = objs.OrderBy(o => o.INN);
                    break;
                case "INN Desc":
                    objs = objs.OrderByDescending(o => o.INN);
                    break;
                case "Description":
                    objs = objs.OrderBy(o => o.Description);
                    break;
                case "Description Desc":
                    objs = objs.OrderByDescending(o => o.Description);
                    break;
               
                default:
                    objs = objs.OrderBy(o => o.Description);
                    break;
            }
            int pageSize = 5;
            int itemsCount = objs.Count();
            ViewData["pageSize"] = pageSize;
            ViewData["pageNum"] = pageNum;
            ViewData["itemsCount"] = itemsCount;
            ViewData["activeSortOrder"] = sortOrder;
            ViewData["activeFilterString"] = searchString;
            objs = objs.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();

            if (clinicGroupID > 0)
            {
                ViewBag.ClinicList = db.GetWardListForClinic(clinicGroupID);
                ViewBag.ClinicListCount = db.GetWardListForClinic(clinicGroupID).Count();
            }
            else
            {
                ViewBag.ClinicList = null;
                ViewBag.ClinicListCount = 0;
            }

            return View(objs);
            
        }

        [Authorize]
        public ActionResult EditClinic(int id, int clinicGroupID)
        {
            var obj = db.GetClinic(id);
            var clinicGroupList = db.GetClinicGroupList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in clinicGroupList)
            {
                items.Add(new SelectListItem { Text = item.Description.ToString(), Value = item.ClinicGroupID.ToString() });
            }
            ViewBag.ClinicGroupID = clinicGroupID;
            ViewBag.ClinicGroupList = items;
            return View(obj);
        }
        
        [HttpPost]
        [Authorize]
        public ActionResult EditClinic(Clinic obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditClinic(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                        return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
                    }

                    if (id == -1)
                    {
                        db.DetachClinic(obj);
                        Clinic oldObj = db.GetClinic(obj.ClinicID);
                        ModelState.AddModelError("", "Ошибка параллельного доступа к данным. Если проблема повторится, обратитесь к системному администратору.");
                        if (oldObj.Description != obj.Description)
                            ModelState.AddModelError("Description", "Текущее значение: " + oldObj.Description.ToString());
                        obj.Timestamp = oldObj.Timestamp;
                    }
                    if (id == -2)
                    {
                        ModelState.AddModelError("", resultAction.exData.Message.ToString() + " | " + resultAction.exData.GetType().ToString() + " | " +
                            "Невозможно сохранить изменения. Нажмите обновить страницу и повторить действия. Если проблема повторится, обратитесь к системному администратору.");
                    }
                }
            }

            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " | " + ex.GetType().ToString() + " | " + "Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
        }

        [Authorize]
        public ActionResult EditClinicGroup(int id)
        {
            ClinicGroup obj = db.GetClinicGroup(id);
            ViewBag.ClinicGroupIdReturn = id;
            return View(obj);
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditClinicGroup(ClinicGroup obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditClinicGroup(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                        return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
                    }

                    if (id == -1)
                    {
                        db.DetachClinicGroup(obj);
                        Clinic oldObj = db.GetClinic(obj.ClinicGroupID);
                        ModelState.AddModelError("", "Ошибка параллельного доступа к данным. Если проблема повторится, обратитесь к системному администратору.");
                        if (oldObj.Description != obj.Description)
                            ModelState.AddModelError("Description", "Текущее значение: " + oldObj.Description.ToString());
                        obj.Timestamp = oldObj.Timestamp;
                    }
                    if (id == -2)
                    {
                        ModelState.AddModelError("", resultAction.exData.Message.ToString() + " | " + resultAction.exData.GetType().ToString() + " | " +
                            "Невозможно сохранить изменения. Нажмите обновить страницу и повторить действия. Если проблема повторится, обратитесь к системному администратору.");
                    }
                }
            }

            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " | " + ex.GetType().ToString() + " | " + "Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
        }

        [Authorize]
        public ActionResult CreateClinic(int id)
        {
            var clinicGroupList = db.GetClinicGroupList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var obj in clinicGroupList)
            {
                items.Add(new SelectListItem { Text = obj.Description.ToString(), Value = obj.ClinicGroupID.ToString() });
                           }
            ViewBag.ClinicGroupDesc = db.GetClinicGroup(id);
            ViewBag.clinicGroupList = items;
            Clinic cl = new Clinic();
            cl.ClinicGroupID = id;
            return View(cl);
        }

        [HttpPost]
        [Authorize]
        public ActionResult CreateClinic(Clinic obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = db.AddClinic(obj);
                    return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
        }

        [Authorize]
        public ActionResult CreateClinicGroup()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult CreateClinicGroup(ClinicGroup obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = db.AddClinicGroup(obj);
                    return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("ClinicGroupList", new { clinicGroupID = obj.ClinicGroupID });
        }

        [Authorize]
        public ActionResult DeleteClinic(int id)
        {
            var obj = db.GetClinic(id);
            int IclinicGroupID = (int)obj.ClinicGroupID;
            try
            {
                db.DeleteClinic(id);
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("ClinicGroupList", new { clinicGroupID = IclinicGroupID });
        }
        [Authorize]
        public ActionResult DeleteClinicGroup(int id)
        {
            try
            {
                db.DeleteClinicGroup(id);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError(ex.Message.ToString(), "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("ClinicGroupList", new { clinicGroupID = 0 });
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

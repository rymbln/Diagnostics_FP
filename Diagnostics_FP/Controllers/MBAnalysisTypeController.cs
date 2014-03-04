using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;
using PagedList;
using System.Data.Entity.Infrastructure;

namespace Diagnostics_FP.Controllers
{
    public class MBAnalysisTypeController : Controller
    {

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        //
        // GET: /MBAnalysisType/

        [Authorize]
        public ViewResult Index(string sortOrder, string currentFilter = "", string searchString = "", int? pageNum = 0)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.DescriptionSortParm = sortOrder == "Description" ? "Description Desc" : "Description";
            ViewBag.ActiveSortParm = sortOrder == "Active" ? "Active Desc" : "Active";
            ViewBag.CodeSortPArm = sortOrder == "Code" ? "Code Desc" : "Code";
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                pageNum = 0;
            }
            ViewBag.CurrentFilter = searchString;
            var objs = from o in db.GetMBAnalysisTypeList()
                       select o;
            if (!String.IsNullOrEmpty(searchString))
            {
                objs = objs.Where(o => o.DescriptionRus.ToUpper().Contains(searchString.ToUpper()) || o.Code.ToUpper().Contains(searchString.ToUpper())
                    || o.DescriptionEng.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Code":
                    objs.OrderBy(o => o.Code);
                    break;
                case "Code Desc":
                    objs.OrderByDescending(o => o.Code);
                    break;
                case "Description":
                    objs = objs.OrderBy(o => o.DescriptionRus);
                    break;
                case "Description Desc":
                    objs = objs.OrderByDescending(o => o.DescriptionRus);
                    break;
                case "Active":
                    objs = objs.OrderBy(o => o.DescriptionRus);
                    break;
                case "Active Desc":
                    objs = objs.OrderByDescending(o => o.DescriptionRus);
                    break;
                default:
                    objs = objs.OrderBy(o => o.DescriptionRus);
                    break;
            }
            int pageSize = 15;
            int itemsCount = objs.Count();
            ViewData["pageSize"] = pageSize;
            ViewData["pageNum"] = pageNum;
            ViewData["itemsCount"] = itemsCount;
            ViewData["activeSortOrder"] = sortOrder;
            ViewData["activeFilterString"] = searchString;
            objs = objs.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();

            return View(objs);
        }



        // GET: /MBAnalysisType/Create

        [Authorize]
        public ActionResult Create()
        {
            var itemsLogic = db.GetLogicList();
            List<SelectListItem> listLogic = new List<SelectListItem>();
            foreach (var item in itemsLogic)
            {
                listLogic.Add(new SelectListItem { Text = item.DescriptionRus.ToString(), Value = item.LogicID.ToString() });
            }
            var selectLogic = new SelectList(listLogic, "Value", "Text", 1);
            ViewData["logicList"] = selectLogic;

            return View();
        }

        //
        // POST: /MBAnalysisType/Create

        [HttpPost]
        [Authorize]
        public ActionResult Create(MBAnalysisType obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = db.AddMBAnalysisType(obj);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("Index");
        }

        //
        // GET: /MBAnalysisType/Edit/5

        [Authorize]
        public ActionResult Edit(int id)
        {
            MBAnalysisType obj = db.GetMBAnalysisType(id);

            var itemsLogic = db.GetLogicList();
            List<SelectListItem> listLogic = new List<SelectListItem>();
            foreach (var item in itemsLogic)
            {
                listLogic.Add(new SelectListItem { Text = item.DescriptionRus.ToString(), Value = item.LogicID.ToString() });
            }
            var selectLogic = new SelectList(listLogic, "Value", "Text", obj.IsInUse);
            ViewData["logicList"] = selectLogic;
            
            return View(obj);
        }

        //
        // POST: /MBAnalysisType/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult Edit(MBAnalysisType obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditMBAnalysisType(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                        return RedirectToAction("Index");
                    }

                    if (id == -1)
                    {
                        db.DetachMBAnalysisType(obj);
                        MBAnalysisType oldObj = db.GetMBAnalysisType(obj.MBAnalysisTypeID);
                        ModelState.AddModelError("", "Ошибка параллельного доступа к данным. Если проблема повторится, обратитесь к системному администратору.");
                        if (oldObj.DescriptionRus != obj.DescriptionRus)
                            ModelState.AddModelError("Description", "Текущее значение: " + oldObj.DescriptionRus.ToString());
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

            return View(obj);
        }

        //
        // GET: /MBAnalysisType/Delete/5

        [Authorize]
        public ActionResult Delete(int id)
        {
            try
            {
                db.DeleteMBAnalysisType(id);
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /MBAnalysisType/Delete/5



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
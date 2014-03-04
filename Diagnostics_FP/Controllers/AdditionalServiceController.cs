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
    public class AdditionalServiceController : Controller
    {

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        //
        // GET: /AdditionalService/

        [Authorize]
        public ViewResult Index(string sortOrder, string currentFilter = "", string searchString = "", int? pageNum = 0)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.DescriptionSortParm = sortOrder == "Description" ? "Description Desc" : "Description";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "Price Desc" : "Price";
            ViewBag.ActiveSortParm = sortOrder == "Active" ? "Active Desc" : "Active";
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                pageNum = 0;
            }
            ViewBag.CurrentFilter = searchString;
            var objs = from o in db.GetAdditionalServicesListWithLogic()
                       select o;
            if (!String.IsNullOrEmpty(searchString))
            {

                objs = objs.Where(o => o.Description.ToUpper().Contains(searchString.ToUpper())
                    || o.Description.ToUpper().Contains(searchString.ToUpper()));

            }
            switch (sortOrder)
            {
                case "Description":
                    objs = objs.OrderBy(o => o.Description);
                    break;
                case "Description Desc":
                    objs = objs.OrderByDescending(o => o.Description);
                    break;
                case "Price":
                    objs = objs.OrderBy(o => o.Price);
                    break;
                case "Price Desc":
                    objs = objs.OrderByDescending(o => o.Price);
                    break;
                case "Active":
                    objs = objs.OrderBy(o => o.DescriptionRus);
                    break;
                case "Active Desc":
                    objs = objs.OrderByDescending(o => o.DescriptionRus);
                    break;
                default:
                    objs = objs.OrderBy(o => o.Description);
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



        // GET: /AdditionalService/Create

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
        // POST: /AdditionalService/Create

        [HttpPost]
        [Authorize]
        public ActionResult Create(AdditionalService obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = db.AddAdditionalService(obj);
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
        // GET: /AdditionalService/Edit/5

        [Authorize]
        public ActionResult Edit(int id)
        {
            AdditionalService obj = db.GetAdditionalService(id);
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
        // POST: /AdditionalService/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult Edit(AdditionalService obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditAdditionalService(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                        return RedirectToAction("Index");
                    }

                    if (id == -1)
                    {
                        db.DetachAdditionalService(obj);
                        AdditionalService oldObj = db.GetAdditionalService(obj.AdditionalServiceID);
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

            return View(obj);
        }

        //
        // GET: /AdditionalService/Delete/5

        [Authorize]
        public ActionResult Delete(int id)
        {
            try
            {
                db.DeleteAdditionalService(id);
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /AdditionalService/Delete/5



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
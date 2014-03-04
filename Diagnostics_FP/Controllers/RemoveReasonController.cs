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
    public class RemoveReasonController : Controller
    {

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        //
        // GET: /RemoveReason/

        [Authorize] public ViewResult Index(string sortOrder, string currentFilter = "", string searchString = "", int? pageNum = 0)
        {   
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CodeSortParm = sortOrder == "Code" ? "Code Desc" : "Code";
            ViewBag.DescriptionEngSortParm = sortOrder == "DescriptionEng" ? "DescriptionEng Desc" : "DescriptionEng";
            ViewBag.DescriptionRusSortParm = sortOrder == "DescriptionRus" ? "DescriptionRus Desc" : "DescriptionRus";
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                pageNum = 0;
            }
            ViewBag.CurrentFilter = searchString;
            var objs = from o in db.GetRemoveReasonList()
                       select o;
            if (!String.IsNullOrEmpty(searchString))
            {

                objs = objs.Where(o => o.DescriptionRus.ToUpper().Contains(searchString.ToUpper()) || o.DescriptionRus.ToUpper().Contains(searchString.ToUpper()) || o.Code.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Code":
                    objs = objs.OrderBy(o => o.Code);
                    break;
                case "Code Desc":
                    objs = objs.OrderByDescending(o => o.Code);
                    break;
                case "DescriptionEng":
                    objs = objs.OrderBy(o => o.DescriptionEng);
                    break;
                case "DescriptionEng Desc":
                    objs = objs.OrderByDescending(o => o.DescriptionEng);
                    break;
                case "DescriptionRus":
                    objs = objs.OrderBy(o => o.DescriptionRus);
                    break;
                case "DescriptionRus Desc":
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


       
        // GET: /RemoveReason/Create

        [Authorize] public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RemoveReason/Create

        [HttpPost]
        [Authorize] public ActionResult Create(RemoveReason  obj)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int id = db.AddRemoveReason(obj);
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
        // GET: /RemoveReason/Edit/5

        [Authorize] public ActionResult Edit(int id)
        {
            RemoveReason obj = db.GetRemoveReason(id);
            return View(obj);
        }

        //
        // POST: /RemoveReason/Edit/5

        [HttpPost]
        [Authorize] public ActionResult Edit(RemoveReason obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditRemoveReason(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                    return RedirectToAction("Index");
                    }

                    if (id == -1)
                    {
                        db.DetachRemoveReason(obj);
                        RemoveReason oldObj = db.GetRemoveReason(obj.RemoveReasonID);
                        ModelState.AddModelError("", "Ошибка параллельного доступа к данным. Если проблема повторится, обратитесь к системному администратору.");
                        if (oldObj.Code != obj.Code)
                            ModelState.AddModelError("Code", "Текущее значение: " + oldObj.Code.ToString());
                        if (oldObj.DescriptionEng != obj.DescriptionEng)
                            ModelState.AddModelError("DescriptionEng", "Текущее значение: " + oldObj.DescriptionEng.ToString());
                        if (oldObj.DescriptionRus.ToString() != obj.DescriptionRus.ToString())
                            ModelState.AddModelError("DescriptionRus", "Текущее значение: " + oldObj.DescriptionRus.ToString());
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
        // GET: /RemoveReason/Delete/5

        [Authorize] public ActionResult Delete(int id)
        {
            try
            {
                db.DeleteRemoveReason(id);
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /RemoveReason/Delete/5



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
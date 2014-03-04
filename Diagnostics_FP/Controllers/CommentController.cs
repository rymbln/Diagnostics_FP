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
    public class CommentController : Controller
    {

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        //
        // GET: /Comment/

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
            var objs = from o in db.GetCommentList()
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


       
        // GET: /Comment/Create

        [Authorize] public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Comment/Create

        [HttpPost]
        [Authorize] public ActionResult Create(Comment  obj)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int id = db.AddComment(obj);
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
        // GET: /Comment/Edit/5

        [Authorize] public ActionResult Edit(int id)
        {
            Comment obj = db.GetComment(id);
            return View(obj);
        }

        //
        // POST: /Comment/Edit/5

        [HttpPost]
        [Authorize] public ActionResult Edit(Comment obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbActionResult resultAction = new dbActionResult();
                    resultAction = db.EditComment(obj);
                    int id = resultAction.intResult;
                    if (id >= 0)
                    {
                    return RedirectToAction("Index");
                    }

                    if (id == -1)
                    {
                        db.DetachComment(obj);
                        Comment oldObj = db.GetComment(obj.CommentID);
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
        // GET: /Comment/Delete/5

        [Authorize] public ActionResult Delete(int id)
        {
            try
            {
                db.DeleteComment(id);
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Удаление не удалось. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /Comment/Delete/5



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
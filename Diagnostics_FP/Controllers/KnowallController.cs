using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.Controllers
{
    public class KnowallController : Controller
    {
        //
        // GET: /Knowall/

        [Authorize] public ActionResult Index()
        {
            ViewBag.Message = "Выберите интересующий вас справочник";
            return View();
        }

    }
}

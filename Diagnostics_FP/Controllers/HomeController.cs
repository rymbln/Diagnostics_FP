using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Infrastructure;
using Diagnostics_FP.Models;
using Diagnostics_FP.ViewModels;
using System.Web.Script.Serialization;

namespace Diagnostics_FP.Controllers
{
    public class HomeController : Controller
    {
        DataManager db = new DataManager();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            vwClinicWard obj = new vwClinicWard();

            var itemsClinics = db.GetClinicGroupList();
            List<SelectListItem> listClinic = new List<SelectListItem>();
            foreach (var item in itemsClinics)
            {
                listClinic.Add(new SelectListItem { Text = item.Description , Value = item.ClinicGroupID.ToString() });
            }
            var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
            ViewData["selectClinicGroup"] = selectClinic;

            return View(obj);
        }

        public string GetClinicsForClinicGroup(string id)
        {
            // get the products from the repository 

            
            var itemsForClinicGroup = db.GetClinicListForClinicGroup(int.Parse(id));
            List<SelectListItem> listClinicsForClinicGroup = new List<SelectListItem>();
            foreach (var item in itemsForClinicGroup)
            {
                listClinicsForClinicGroup.Add(new SelectListItem { Text = item.Description, Value = item.ClinicID.ToString() });
            }

            return new JavaScriptSerializer().Serialize(listClinicsForClinicGroup);
        }

        public void GetUserManual()
        {
            string resAddress = "\\UserManual.pdf";
            Response.ContentType = "application/text";
            Response.AddHeader("Content-Disposition", @"filename=""userManual.pdf");
            Response.TransmitFile(@resAddress);
        }
    }
}

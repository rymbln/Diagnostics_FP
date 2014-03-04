using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;
using Diagnostics_FP.ViewModels;
using Diagnostics_FP.GeneratedXML;

namespace Diagnostics_FP.Controllers
{
    public class ReportController : Controller
    {

        DataManager db = new DataManager();
        mlabEntities dbm = new mlabEntities();
        //
        // GET: /Report/

        [Authorize]
        public ActionResult ClinicsList(string ID)
        {
            List<SelectListItem> listClinic = new List<SelectListItem>();
            if (ID == "ALL")
            {
                var itemsClinic = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Select(o => new { o.ClinicContractID, o.ClinicDesc, o.ClinicGroupDesc, o.ContractDesc }).Distinct().OrderBy(o => o.ContractDesc ).ToList();
                
                listClinic.Add(new SelectListItem { Text = "Все ЛПУ", Value = "ALL" });
                foreach (var item in itemsClinic)
                {
                    listClinic.Add(new SelectListItem { Text = item.ContractDesc + " - " + item.ClinicGroupDesc + " - " + item.ClinicDesc, Value = item.ClinicContractID.ToString() });
                }           
            }
            else
            {
                var itemsClinic = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Where(o => o.ContractDesc == ID).Select(o => new { o.ClinicContractID, o.ClinicDesc, o.ClinicGroupDesc, o.ContractDesc  }).Distinct().OrderBy(o => o.ContractDesc ).ToList();
        
                listClinic.Add(new SelectListItem { Text = "Все ЛПУ", Value = "ALL" });
                foreach (var item in itemsClinic)
                {
                    listClinic.Add(new SelectListItem { Text = item.ContractDesc + " - " + item.ClinicGroupDesc + " - " + item.ClinicDesc, Value = item.ClinicContractID.ToString() });
                }
            }
            var selectClinic = new MultiSelectList(listClinic, "Value", "Text", "ALL");
            
            if (HttpContext.Request.IsAjaxRequest())
              return Json(selectClinic, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }



        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            vwReportIndex model = new vwReportIndex();

            var itemsContract = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Select(o => new { o.ContractID, o.ContractDesc }).Distinct().OrderBy(o => o.ContractDesc).ToList();
            List<SelectListItem> listContract = new List<SelectListItem>();
            listContract.Add(new SelectListItem { Text = "Все контракты", Value = "ALL" });
            foreach (var item in itemsContract)
            {
                listContract.Add(new SelectListItem { Text = item.ContractDesc, Value = item.ContractID.ToString() });
            }

            var selectContract = new MultiSelectList(listContract, "Value", "Text", "ALL");
            ViewData["selectContract"] = selectContract;

            var itemsClinic = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Select(o => new { o.ClinicContractID, o.ClinicDesc, o.ClinicGroupDesc, o.ContractDesc }).Distinct().OrderBy(o => o.ClinicGroupDesc).ToList();
            List<SelectListItem> listClinic = new List<SelectListItem>();
            listClinic.Add(new SelectListItem { Text = "Все ЛПУ", Value = "ALL" });
            foreach (var item in itemsClinic)
            {
                listClinic.Add(new SelectListItem { Text =item.ContractDesc + " - " + item.ClinicGroupDesc + " - " + item.ClinicDesc, Value = item.ClinicContractID.ToString() });
            }

            var selectClinic = new MultiSelectList(listClinic, "Value", "Text", "ALL");
            ViewData["selectClinic"] = selectClinic;

            var itemsMBAnalysis = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Select(o => new { o.MBAnalysisTypeID, o.MBAnalysisDesc }).Distinct().OrderBy(o => o.MBAnalysisDesc).ToList();
            List<SelectListItem> listMBAnalysis = new List<SelectListItem>();
            listMBAnalysis.Add(new SelectListItem { Text = "Все анализы", Value = "ALL" });
            foreach (var item in itemsMBAnalysis)
            {
                listMBAnalysis.Add(new SelectListItem { Text = item.MBAnalysisDesc, Value = item.MBAnalysisTypeID.ToString() });
            }
            var selectMBAnalysis = new MultiSelectList(listMBAnalysis, "Value", "Text", "ALL");
            ViewData["selectMBAnalysis"] = selectMBAnalysis;

            var itemsClinicMaterial = dbm.vwContract_Clinic_Analysis_ClinicMaterial_ForReports.Select(o => new { o.ClinicMaterialID, o.ClinicMaterialDesc }).Distinct().OrderBy(o => o.ClinicMaterialDesc).ToList();
            List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
            listClinicMaterial.Add(new SelectListItem { Text = "Все клин.материалы", Value = "ALL" });
            foreach (var item in itemsClinicMaterial)
            {
                listClinicMaterial.Add(new SelectListItem { Text = item.ClinicMaterialDesc, Value = item.ClinicMaterialDesc.ToString() });
            }
            var selectClinicMaterial = new MultiSelectList(listClinicMaterial, "Value", "Text", "ALL");
            ViewData["selectClinicMaterial"] = selectClinicMaterial;

            model.dateStart = DateTime.Now.ToShortDateString();
            model.dateEnd = DateTime.Now.ToShortDateString();

            return View(model);
        }

        [Authorize]
        public void Index(vwReportIndex model)
        {
            int statusContract = 0;
            int statusClinic = 0;
            int statusMBAnalysis = 0;
            int statusClinicMaterials = 0;
            if (model.selectedClinic[0] == "ALL")
            {
                statusClinic = 1;
            }
            if (model.selectedClinicMaterial[0] == "ALL")
            {
                statusClinicMaterials = 1;
            }
            if (model.selectedContract[0] == "ALL")
            {
                statusContract = 1;
            }
            if (model.selectedMBAnalysis[0] == "ALL")
            {
                statusMBAnalysis = 1;
            }
            IEnumerable<vwTotalInfoForReport> obj = dbm.vwTotalInfoForReports.ToList();
            if (statusContract != 1)
            {
                //var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2 && arr.Contains(o.SampleID))
             obj = obj.Where(o => model.selectedContract.Contains(o.ContractID.ToString() )).ToList();   
            }

            if (statusClinic != 1)
            {
                //var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2 && arr.Contains(o.SampleID))
                obj = obj.Where(o => model.selectedClinic.Contains(o.ClinicContractID.ToString())).ToList();
            }

            if (statusClinicMaterials != 1)
            {
                //var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2 && arr.Contains(o.SampleID))
                obj = obj.Where(o => model.selectedClinicMaterial.Contains(o.ClinicMaterialID.ToString())).ToList();
            }

            if (statusMBAnalysis != 1)
            {
                //var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2 && arr.Contains(o.SampleID))
                obj = obj.Where(o => model.selectedMBAnalysis.Contains(o.MBAnalysisTypeID.ToString())).ToList();
            }

            obj = obj.Where(o => o.DatetimeDelivery >= DateTime.Parse(model.dateStart) && o.DatetimeDelivery <= (DateTime.Parse(model.dateEnd)).AddDays(1));
            

            Printing objPrinter = new Printing();
            string resAddress = objPrinter.PrintReport(obj);
            Response.ContentType = "application/text";
            Response.AddHeader("Content-Disposition", @"filename=""report_" + DateTime.Now.ToString() + ".xls");
            Response.TransmitFile(@resAddress);
        }

    }
}

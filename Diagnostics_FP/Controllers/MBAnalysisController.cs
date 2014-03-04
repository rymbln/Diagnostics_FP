using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;
using System.Data.Entity.Infrastructure;
using Diagnostics_FP.ViewModels;
using Diagnostics_FP.Infrastructure;

namespace Diagnostics_FP.Controllers
{
    public class MBAnalysisController : Controller
    {
        //
        // GET: /MBAnalysis/
        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult SetStatusInWork(string[] selectedMBAnalysis, int queue = -1)
        {
            try
            {
                int cnt = 0;
                foreach (var item in selectedMBAnalysis)
                {
                    int temp = int.Parse(item);
                    MBAnalysi obj = dbm.MBAnalysis.SingleOrDefault(o => o.MBAnalysisID == temp);
                    obj.MBStatusID = 4;
                    obj.DateUpdate = DateTime.Now;
                    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                    //   dbm.MBAnalysis.Attach(obj);
                    //  dbm.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                    dbm.SaveChanges();
                    cnt++;
                }
                string strMessage = "Статус в работе успешно применен для " + cnt.ToString() + " анализов";
                return RedirectToAction("MBAnalysisList", new {message = strMessage, queue = 1 });
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + " при установке статуса.";
                return RedirectToAction("MBAnalysisList", new { message = strMessage , queue = 1 });
            }
        }

        [Authorize]
        public ActionResult MBAnalysisList(int? mbAnalysisId, string sortOrder, 
            string clinicMaterialFilter = "", string sampleFilter = "", string analysisFilter = "", int? pageNum = 0, string message = "", int queue = -1)
        {
            try
            {

                ViewBag.SampleFilter = sampleFilter;
                ViewBag.analysisFilter = analysisFilter;
                ViewBag.ClinicmaterialFilter = clinicMaterialFilter;
                vwMBAnalysisList model = new vwMBAnalysisList();

                if (queue == -1)
                {
                    model.MBAnalysisList = db.GetMBAnalysisListForInterface();
                    ViewBag.Queue = -1;
                    ViewData["title"] = "Список анализов";
                }
                else
                {
                    model.MBAnalysisList = db.GetMBAnalysisListForInterfaceQueue();
                    ViewBag.Queue = 1;
                    ViewData["title"] = "Очередь анализов";
                }

                if (!String.IsNullOrEmpty(sampleFilter))
                {
                    model.MBAnalysisList = model.MBAnalysisList
                     .Where(o => o.Sample.SampleID.ToString() == sampleFilter);
                }
                if (!String.IsNullOrEmpty(clinicMaterialFilter))
                {
                    model.MBAnalysisList = model.MBAnalysisList
                     .Where(o => o.Sample.ClinicMaterial.Description.Contains(clinicMaterialFilter));
                }
                if (!String.IsNullOrEmpty(analysisFilter))
                {
                    model.MBAnalysisList = model.MBAnalysisList
                     .Where(o => o.MBAnalysisType.DescriptionRus.Contains(analysisFilter));
                }
                // первоначальный набор данных получен
                ViewBag.CurrentSort = sortOrder;
                ViewBag.SampleNumberSortParm = sortOrder == "SampleNumber" ? "SampleNumber Desc" : "SampleNumber";
                ViewBag.MBAnalysisSortParm = sortOrder == "MBAnalysis" ? "MBAnalysis Desc" : "MBAnalysis";
                ViewBag.ClinicMaterialSortParm = sortOrder == "ClinicMaterial" ? "ClinicMateriale Desc" : "ClinicMaterial";
                ViewBag.StatusSortParm = sortOrder == "Status" ? "Status Desc" : "Status";
                ViewBag.ResultSortParm = sortOrder == "Result" ? "Result Desc" : "Result";
                ViewBag.DeliverySortParm = sortOrder == "Delivery" ? "Delivery Desc" : "Delivery";
                ViewBag.CaptureSortParm = sortOrder == "Capture" ? "Capture Desc" : "Capture";
                switch (sortOrder)
                {
                    case "MBAnalysis":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.MBAnalysisType.DescriptionRus);
                        break;
                    case "MBAnalysis Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.MBAnalysisType.DescriptionRus);
                        break;
                    case "Status":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.MBStatus.DescriptionRus);
                        break;
                    case "Status Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.MBStatus.DescriptionRus);
                        break;
                    case "Result":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.MBAnalysisResult.DescriptionRus);
                        break;
                    case "Result Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.MBAnalysisResult.DescriptionRus);
                        break;
                    case "Capture":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.Sample.DatetimeCapture);
                        break;
                    case "Capture Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.Sample.DatetimeCapture);
                        break;
                    case "ClinicMaterial":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.Sample.ClinicMaterial.Description);
                        break;
                    case "ClinicMaterial Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.Sample.ClinicMaterial.Description);
                        break;
                    case "SampleNumber":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.Sample.SampleID);
                        break;
                    case "SampleNumber Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.Sample.SampleID);
                        break;
                    case "Delivery":
                        model.MBAnalysisList = model.MBAnalysisList.OrderBy(o => o.Sample.DatetimeDelivery);
                        break;
                    case "Delivery Desc":
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.Sample.DatetimeDelivery);
                        break;
                    default:
                        model.MBAnalysisList = model.MBAnalysisList.OrderByDescending(o => o.MBAnalysisID);
                        break;
                }
                int pageSize = 10;
                int itemsCount = model.MBAnalysisList.Count();
                ViewData["pageSize"] = pageSize;
                ViewData["pageNum"] = pageNum;
                ViewData["itemsCount"] = itemsCount;
                ViewData["activeSortOrder"] = sortOrder;
                ViewData["message"] = message;
                model.MBAnalysisList = model.MBAnalysisList.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();

                //отображение подробных сведений


                return View(model);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Список анализов не получен";
                Response.Write(strMessage);
                return null;
            }
        }


        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialClinicalTestEdit(int mbAnalysisId = -1,int roId = -1, int clinicalTestId = -1, string text = "")
        {
            ROandClinicalTest obj = new ROandClinicalTest();
            //редактирование
            if ((mbAnalysisId != -1) && (clinicalTestId != -1) && (roId != -1))
            {
                obj = dbm.ROandClinicalTests.Include(o => o.RO).SingleOrDefault(o => o.ROClinicalTestID == clinicalTestId);
                
                ViewData["titleText"] = "Редактирование чувствительности для " + text ;
                ViewData["buttonText"] = "Сохранить";
            }
            //добавление
            if ((mbAnalysisId != -1) && (clinicalTestId == -1) && (roId != -1))
            {
                obj.ROClinicalTestID = -1;
                obj.ROID = roId;
                obj.RO = dbm.ROes.SingleOrDefault(o => o.ROID == roId);
                ViewData["titleText"] = "Добавление чувствительности для " + text;
                ViewData["buttonText"] = "Добавить";
            }

            var itemsAbType = db.GetAntibioticTypeList().ToList();
            List<SelectListItem> listAbType = new List<SelectListItem>();
            foreach (var item in itemsAbType)
            {
                listAbType.Add(new SelectListItem { Text = item.DescriptionEng, Value = item.AntibioticTypeID.ToString() });
            }
            var selectAbType = new SelectList(listAbType, "Value", "Text");
            ViewData["selectAbType"] = selectAbType;

            List<SelectListItem> listSIR = new List<SelectListItem>();
            //S;I;R;N;D
            listSIR.Add(new SelectListItem { Text = "S", Value = "S" });
            listSIR.Add(new SelectListItem { Text = "I", Value = "I" });
            listSIR.Add(new SelectListItem { Text = "R", Value = "R" });
            listSIR.Add(new SelectListItem { Text = "N", Value = "N" });
            listSIR.Add(new SelectListItem { Text = "D", Value = "D" });
            var selectSIR = new SelectList(listSIR, "Value", "Text");
            ViewData["selectSIR"] = selectSIR;

            var itemsMethod = db.GetMethodList();
            List<SelectListItem> listMethod = new List<SelectListItem>();
            foreach(var item in itemsMethod)
            {
                listMethod.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MethodID.ToString() });
            }
            var selectMethod = new SelectList(listMethod , "Value", "Text");
            ViewData["selectMethod"] = selectMethod;

            return PartialView("PartialClinicalTestEdit", obj);
        }

        [HttpPost]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialClinicalTestEdit(ROandClinicalTest obj)
        {
              try
            {
            if (ModelState.IsValid)
            {
                if ((obj.ROClinicalTestID != -1) && (obj.ROID != -1))
                {
                    // редактирование для анализа
                    db.EditROandClinicalTest(obj);
                    ModelState.Clear();
                    var tmp = dbm.ROes.SingleOrDefault(o => o.ROID == obj.ROID);
                    return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = tmp.MBAnalysisID, sampleId = tmp.SampleID , showRO = 1 });
                }
                // if ((roId != -1) && (sampleId == -1) && (mbAnalysisId == -1))
                if ((obj.ROClinicalTestID == -1) && (obj.ROID != -1))
                {
                    // сохранение из анализа
                    db.AddROandClinicalTest(obj);
                    ModelState.Clear();
                    var tmp = dbm.ROes.SingleOrDefault(o => o.ROID == obj.ROID);

                    return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = tmp.MBAnalysisID, sampleId = tmp.SampleID, showRO = 1 });
                }


            }

            return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.RO.MBAnalysisID, showRO = 1 });
            }
              catch (DataException ex)
              {
                  var tmp = dbm.ROes.SingleOrDefault(o => o.ROID == obj.ROID);
                  string strMessage = "Ошибка! Показатели бактериоскопии сохранить не удалось. Возможно введены повторяющиеся значения";
                  return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = tmp.MBAnalysisID, sampleId = tmp.SampleID, showRO = 1, message = strMessage  });
              }
        }

        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialBacEdit(int mbAnalysisBacId = -1, int mbAnalysisId = -1 , int sampleId = -1)
        {
            MBAnalysisBacterioscopy obj = new MBAnalysisBacterioscopy();
            if ((mbAnalysisBacId != -1) && (mbAnalysisId != -1))
            {
                //редактирование показателей бактериоскопии
                obj = dbm.MBAnalysisBacterioscopies.Include(o => o.MBAnalysi).SingleOrDefault(o => o.MBAnalysisBacterioscopyID == mbAnalysisBacId);
                ViewData["titleText"] = "Редактирование показателей бактериоскопии";
                ViewData["buttonText"] = "Сохранить";
            }
            if ((mbAnalysisBacId == -1) && (mbAnalysisId != -1))
            {
                // добавление показателя бактериоскопии
                obj.MBAnalysisID = mbAnalysisId;
                obj.MBAnalysisBacterioscopyID = -1;
                obj.MBAnalysi = dbm.MBAnalysis.SingleOrDefault(o => o.MBAnalysisID == mbAnalysisId );
                ViewData["titleText"] = "Добавление показателей бактериоскопии";
                ViewData["buttonText"] = "Сохранить";
            }

            var itemsBacOrg = dbm.MBBacterioscopyOrganismTypes.ToList();
            List<SelectListItem> listBacOrg = new List<SelectListItem>();
            foreach (var item in itemsBacOrg)
            {
                listBacOrg.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBBacterioscopyOrganismTypeID.ToString() });
            }
            var selectBacOrg = new SelectList(listBacOrg, "Value", "Text");
            ViewData["selectBacOrg"] = selectBacOrg;

            //100;x100;1000;x1000
            List<SelectListItem> listViewField = new List<SelectListItem>();
            listViewField.Add(new SelectListItem { Text = "100", Value = "100" });
            listViewField.Add(new SelectListItem { Text = "x100", Value = "x100" });
            listViewField.Add(new SelectListItem { Text = "x1000", Value = "x1000" });
            listViewField.Add(new SelectListItem { Text = "1000", Value = "1000" });
            listViewField.Add(new SelectListItem { Text = "", Value = "" });
            var selectViewField = new SelectList(listViewField, "Value", "Text", "");
            ViewData["selectViewField"] = selectViewField;

            //0-10;10-15;15-20;25-30;35-40;45-50;55-100
            List<SelectListItem> listValue = new List<SelectListItem>();
            listValue.Add(new SelectListItem { Text = "0-10", Value = "0-10" });
            listValue.Add(new SelectListItem { Text = "10-15", Value = "10-15" });
            listValue.Add(new SelectListItem { Text = "15-20", Value = "15-20" });
            listValue.Add(new SelectListItem { Text = "25-30", Value = "25-30" });
            listValue.Add(new SelectListItem { Text = "35-40", Value = "35-40" });
            listValue.Add(new SelectListItem { Text = "45-50", Value = "45-50" });
            listValue.Add(new SelectListItem { Text = "55-100", Value = "55-100" });
            listValue.Add(new SelectListItem { Text = "", Value = "" });
            var selectValue = new SelectList( listValue , "Value", "Text", "");
            ViewData["selectValue"] = selectValue;

            return PartialView("PartialBacEdit", obj);
        }

        [HttpPost]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialBacEdit(MBAnalysisBacterioscopy obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var tmp = dbm.MBAnalysis.SingleOrDefault(o => o.MBAnalysisID == obj.MBAnalysisID);
                    if ((obj.MBAnalysisBacterioscopyID != -1) && (obj.MBAnalysisID != -1))
                    {
                        // редактирование для анализа
                        db.EditMBAnalysisBacterioscopy(obj);
                        ModelState.Clear();
                        tmp = dbm.MBAnalysis.SingleOrDefault(o => o.MBAnalysisID == obj.MBAnalysisID);
                        string strMessage = "Показатели бактериоскопии успешно сохранены";
                        return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, showBac = 1, sampleId = tmp.SampleID, message = strMessage });
                    }
                    // if ((roId != -1) && (sampleId == -1) && (mbAnalysisId == -1))
                    if ((obj.MBAnalysisBacterioscopyID == -1) && (obj.MBAnalysisID != -1))
                    {
                        // сохранение из анализа
                        db.AddMBAnalysisBacterioscopy(obj);
                        ModelState.Clear();
                        tmp = dbm.MBAnalysis.SingleOrDefault(o => o.MBAnalysisID == obj.MBAnalysisID);
                        string strMessage = "Показатели бактериоскопии успешно сохранены";
                        return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, showBac = 1, sampleId = tmp.SampleID, message = strMessage });
                    }


                    return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, showBac = 1, sampleId = tmp.SampleID, message = "Показатели бактериоскопии успешно сохранены" });
                }
                else
                {
                    string strMessage = "Ошибка! Показатели бактериоскопии сохранить не удалось. Возможно введены повторяющиеся значения";
                    return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, showBac = 1, message = strMessage });
           
                }
                
             
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка! Показатели бактериоскопии сохранить не удалось. Возможно введены повторяющиеся значения";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, showBac = 1, message = strMessage  });
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteRO(int roId = -1, int sampleId = -1, int mbAnalysisId = -1)
        {
            try
            {
                var obj = dbm.ROes.SingleOrDefault(o => o.ROID == roId);
                dbm.ROes.DeleteObject(obj);
                dbm.SaveChanges();
                string strMessage = "Удаление реидентификации произведено успешно";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showRO = 1 , message = strMessage });
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка! "+ ex.Message + " Удаление реидентификации не удалось";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showRO = 1, message = strMessage });
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteBac(int mbAnalysisBacId = -1, int sampleId = -1, int mbAnalysisId = -1)
        {
            try
            {
                var obj = dbm.MBAnalysisBacterioscopies.SingleOrDefault(o => o.MBAnalysisBacterioscopyID == mbAnalysisBacId);
                dbm.MBAnalysisBacterioscopies.DeleteObject(obj);
                dbm.SaveChanges();
                string strMessage = "Удаление показателя бактериоскопии произведено успешно";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showBac = 1, message = strMessage  });
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка! " + ex.Message + " Удаление показателя бактериоскопии не удалось";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showBac = 1, message = strMessage });
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteClinicalTest(int clinicalTestId = -1, int sampleId = -1, int mbAnalysisId = -1)
        {
            try
            {
                var obj = dbm.ROandClinicalTests.SingleOrDefault(o => o.ROClinicalTestID == clinicalTestId);
                dbm.ROandClinicalTests.DeleteObject(obj);
                dbm.SaveChanges();
                string strMessage = "Удаление тестирования реидентификации произведено успешно";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showRO = 1, message = strMessage });
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка! " + ex.Message + " Удаление тестирования реидентификации не удалось";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = mbAnalysisId, sampleId = sampleId, showRO = 1, message = strMessage });
            }
        }

        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialROEdit( int roId = -1, int sampleId = -1, int mbAnalysisId = -1)
        {

            RO obj = new RO();
            // Возможно 3 случая - если реидентификация
            // добавление для анализа (sampleId - mbAnalysisId)
            // редактирование (roId)
            // добавление для образца (sampleId)


            // добавление для анализа
            if ((sampleId != -1) && (mbAnalysisId != -1) && (roId == -1))
            {
                obj.ROID = -1;
                obj.SampleID = sampleId;
                obj.MBAnalysisID = mbAnalysisId;
                obj.DateOfReidentify = DateTime.Now.ToString();
                obj.PrimaryProjectID = 160;
                obj.MBStatusID = 1;
                obj.RemoveReasonID = 1;
                ViewData["titleText"] = "Добавление реидентификации для анализа";
                ViewData["buttonText"] = "Добавить";
            }
            // добавление для образца
            //if ((sampleId != -1) && (mbAnalysisId == -1) && (roId == -1))
            //{
            //    obj.SampleID = sampleId;
            //    obj.DateOfReidentify = DateTime.Now.ToString();
            //    obj.MBStatusID = 1;
            //    obj.RemoveReasonID = 1;
            //    ViewData["titleText"] = "Добавление реидентификации для образца";
            //    ViewData["buttonText"] = "Добавить";
            //}
            // редактирование из анализа
            if ((roId != -1) && (sampleId != -1) && (mbAnalysisId != -1))
            {
                obj = dbm.ROes.SingleOrDefault(o => o.ROID == roId);
                ViewData["titleText"] = "Редактирование реидентификации";
                ViewData["buttonText"] = "Сохранить";
            }

            var itemsOrgType = db.GetOrganismTypeList();
            List<SelectListItem> listOrgType = new List<SelectListItem>();
            foreach (var item in itemsOrgType)
            {
                listOrgType.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.OrganismTypeID.ToString() });
            }
            var selectOrgType = new SelectList(listOrgType, "Value", "Text", 1);
            ViewData["selectOrgType"] = selectOrgType ;

            List<SelectListItem> listBacValue = new List<SelectListItem>();
            // "10^2";"10^3";"10^4";"10^5";">=10^5";"1";"2";"3";"4"
            listBacValue.Add(new SelectListItem { Text = "10^2", Value = "10^2" });
            listBacValue.Add(new SelectListItem { Text = "10^3", Value = "10^3" });
            listBacValue.Add(new SelectListItem { Text = "10^4", Value = "10^4" });
            listBacValue.Add(new SelectListItem { Text = "10^5", Value = "10^5" });
            listBacValue.Add(new SelectListItem { Text = ">=10^5", Value = ">=10^5" });
            listBacValue.Add(new SelectListItem { Text = "1", Value = "1" });
            listBacValue.Add(new SelectListItem { Text = "2", Value = "2" });
            listBacValue.Add(new SelectListItem { Text = "3", Value = "3" });
            listBacValue.Add(new SelectListItem { Text = "4", Value = "4" });
            listBacValue.Add(new SelectListItem { Text = "", Value = "" });
            var selectBacValue = new SelectList(listBacValue, "Value", "Text", "");
            ViewData["selectBacValue"] = selectBacValue;

            List<SelectListItem> listBacUnit = new List<SelectListItem>();
            //"КОЕ/мл";"Степ.";"КОЕ/г"
            listBacUnit.Add(new SelectListItem { Text = "КОЕ/мл", Value = "КОЕ/мл" });
            listBacUnit.Add(new SelectListItem { Text = "Степ.", Value = "Степ." });
            listBacUnit.Add(new SelectListItem { Text = "КОЕ/г", Value = "КОЕ/г" });
            listBacUnit.Add(new SelectListItem { Text = "", Value = "" });
            var selectBacUnit = new SelectList(listBacUnit, "Value", "Text", "");
            ViewData["selectBacUnit"] = selectBacUnit;

            return PartialView("PartialROEdit", obj);

        }

  


        [HttpPost]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialROEdit(RO obj)
        {
            try
            {
                int temp = -1;
                if (ModelState.IsValid)
                {
                    // Возможно 3 случая - если реидентификация
                    // добавление для анализа (sampleId - mbAnalysisId)
                    // сохранение (roId)
                    // добавление для образца (sampleId)


                    if ((obj.SampleID != -1) && (obj.MBAnalysisID != -1) && (obj.ROID == -1))
                    {
                        // добавление для анализа
                        db.AddRO(obj);
                        ModelState.Clear();
                        string strMessage = "Изменения в реидентификации применены успешно";
                        return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, sampleId = obj.SampleID, showRO = 1, message = strMessage });
                    }
                    // if ((roId != -1) && (sampleId == -1) && (mbAnalysisId == -1))
                    if ((obj.ROID != 0) && (obj.SampleID != -1) && (obj.MBAnalysisID != -1))
                    {
                        // сохранение из анализа
                        db.EditRO(obj);
                        ModelState.Clear();
                        string strMessage = "Изменения в реидентификации применены успешно";
                        return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, sampleId = obj.SampleID, showRO = 1, message = strMessage });
                    }


                }
                else
                {
                    string strMessage = "Ошибка. Изменения в реидентификации сохранить не удалось";
                    return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, sampleId = obj.SampleID, showRO = 1, message = strMessage });
         
                }
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, sampleId = obj.SampleID, showRO = 1, message = "" });
                
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Изменения в реидентификации сохранить не удалось";
                return RedirectToAction("MBAnalysisEdit", new { mbAnalysisId = obj.MBAnalysisID, sampleId = obj.SampleID, showRO = 1, message = strMessage  });
            }
        }


        [HttpGet]
        [Authorize]
        public ActionResult MBAnalysisEdit( int mbAnalysisId = -1, int sampleId = -1, int patientId = -1, int showRO = -1, int showBac = -1, string message = "", int queue = -1 )
        {
            ViewData["Message"] = message;
            ViewBag.Queue = queue;
            vwMBAnaysisEdit model = new vwMBAnaysisEdit();
            model.PatientObj = new Patient();
            model.SampleObj = new Sample();
            model.MBAnalysisObj = new MBAnalysi();
    
           // if (patientId != -1)
           // {
            var temp = dbm.MBAnalysis.Include(o => o.Sample).SingleOrDefault(o => o.MBAnalysisID == mbAnalysisId);
                model.SampleObj = dbm.Samples.SingleOrDefault(o => o.SampleID == temp.SampleID);
                model.PatientObj = dbm.Patients.SingleOrDefault(o => o.PatientID == temp.Sample.PatientID);
                model.MBAnalysisObj = db.GetMBAnalysisForSampleSingle(mbAnalysisId);
                model.listMBAnalysisBacterioscopy = db.GetBacterioscopyForMBAnalysis(mbAnalysisId);
                model.listRO = db.GetROListforSampleAndMBAnalysis(mbAnalysisId);
            //}

            var itemsAnalysis = db.GetMBAnalysisTypeListActive();
            List<SelectListItem> listAnalysis = new List<SelectListItem>();
            foreach (var item in itemsAnalysis)
            {
                listAnalysis.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBAnalysisTypeID.ToString() });
            }
            var selectAnalysis = new SelectList(listAnalysis, "Value", "Text", model.MBAnalysisObj.MBAnalysisID);
            ViewData["selectAnalysis"] = selectAnalysis;

            var itemsResults = db.GetMBAnalysisResultList();
            List<SelectListItem> listResults = new List<SelectListItem>();
            foreach (var item in itemsResults)
            {
                listResults.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBAnalysisResultID.ToString() });
            }
            var selectResults = new SelectList( listResults, "Value", "Text", model.MBAnalysisObj.MBAnalysisResultID.ToString() );
            ViewData["selectResults"] = selectResults;

            var itemsStatus = db.GetMBStatusList();
            List<SelectListItem> listStatuses = new List<SelectListItem>();
            foreach (var item in itemsStatus)
            {
                listStatuses.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBStatusID.ToString() });
            }
            var selectStatuses = new SelectList(listStatuses, "Value", "Text", model.MBAnalysisObj.MBStatusID.ToString());
            ViewData["selectStatuses"] = selectStatuses;

            if (showBac > 0)
            {
                model.listMBAnalysisBacterioscopy = db.GetBacterioscopyForMBAnalysis(mbAnalysisId);
            }
            else
            {
                model.listMBAnalysisBacterioscopy = null;
            }
            if (showRO > 0)
            {
                model.listRO = db.GetROListforSampleAndMBAnalysis(mbAnalysisId);
            }
            else
            {
                model.listRO = null;
            }
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult MBAnalysisEdit(vwMBAnaysisEdit model)
        {
            try
            {

                MBAnalysi obj = new MBAnalysi();

                obj = model.MBAnalysisObj;
                db.EditMBAnalysis(obj);
                var tmp = dbm.Samples.SingleOrDefault(o => o.SampleID == model.MBAnalysisObj.SampleID);
                string strMessage = "Результаты анализа " + model.MBAnalysisObj.MBAnalysisType.DescriptionRus + " для образца " + model.SampleObj.SampleID + " сохранены успешно ";
                return RedirectToAction("MBAnalysisList", new { message = strMessage, queue = 1 });
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка" + ex.Message + ". Результаты анализа " + model.MBAnalysisObj.MBAnalysisType.DescriptionRus + " для образца " + model.SampleObj.SampleID + " не удалось сохранить ";
                return RedirectToAction("MBAnalysisList", new { message = strMessage, queue = 1 });
            }
            
        }
    }
}

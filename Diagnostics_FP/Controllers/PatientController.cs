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
using Diagnostics_FP.GeneratedXML;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;



namespace Diagnostics_FP.Controllers
{
    public class PatientController : Controller
    {
        //
        // GET: /Patient/

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();

        public string AlignStr(string str, byte digNo)
        {
            string tmpNumberStr = str;
            tmpNumberStr = tmpNumberStr.Replace(" ", "");
            tmpNumberStr = tmpNumberStr.Replace(")", "");
            tmpNumberStr = tmpNumberStr.Replace("\\", "-");
            tmpNumberStr = tmpNumberStr.Replace("//", "-");
            tmpNumberStr = tmpNumberStr.Replace(".", "-");
            tmpNumberStr = tmpNumberStr.Replace(",", "-");
            tmpNumberStr = tmpNumberStr.Replace("(", "-");
            if (tmpNumberStr.Length <= digNo)
            {
                do
                {
                    tmpNumberStr = "0" + tmpNumberStr;
                }
                while (tmpNumberStr.Length >= digNo);
            }
            //else
            //{
            //    do
            //    {
            //        tmpNumberStr = tmpNumberStr.end
            //    }
            //    while ((tmpNumberStr.Length <= digNo) || (tmpNumberStr.StartsWith("0"))
            //}
            return tmpNumberStr;
        }

        //Private Function AlignStr(ByVal Str_ As String, ByVal DigNo As Byte) As String
        //    Dim TempNumberStr As String
        //    TempNumberStr = Str_
        //    TempNumberStr = Replace(TempNumberStr, " ", "", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, ")", "", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, "\", "-", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, "/", "-", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, ".", "-", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, ",", "-", , , vbTextCompare)
        //    TempNumberStr = Replace(TempNumberStr, "(", "-", , , vbTextCompare)
        //    If Len(TempNumberStr) <= DigNo Then
        //        Do Until Len(TempNumberStr) >= DigNo
        //            TempNumberStr = "0" & TempNumberStr
        //        Loop
        //    Else
        //        Do Until (Len(TempNumberStr) <= DigNo) Or (Left(TempNumberStr, 1) <> "0")
        //            TempNumberStr = Right(TempNumberStr, Len(TempNumberStr) - 1)
        //        Loop
        //    End If
        //    AlignStr = UCase(TempNumberStr)
        //End Function

        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialPatientEdit(int sampleId = -1, string returnString = "", int queue = -1)
        {
            try
            {

                vwPatientEdit obj = new vwPatientEdit();
                var temp = dbm.Samples.Include(o => o.Patient).SingleOrDefault(o => o.SampleID == sampleId);
                obj.Birthdate = DateTime.Parse(temp.Patient.Birthdate.ToString());
                obj.ClinicMaterialID = temp.ClinicMaterialID;
                obj.DatetimeCapture = temp.DatetimeCapture;
                obj.DatetimeDelivery = temp.DatetimeDelivery;
                obj.DoctorID = temp.DoctorID;
                obj.Initials = temp.Patient.Initials;
                obj.Lastname = temp.Patient.Lastname;
                obj.PatientID = temp.PatientID;
                obj.SampleID = temp.SampleID;
                obj.Sex = temp.Patient.Sex;

                List<SelectListItem> listSex = new List<SelectListItem>();
                listSex.Add(new SelectListItem { Text = "Неизвестно", Value = "1" });
                listSex.Add(new SelectListItem { Text = "Мужской", Value = "2" });
                listSex.Add(new SelectListItem { Text = "Женский", Value = "3" });
                var selectSex = new SelectList(listSex, "Value", "Text", 1);
                ViewData["selectSex"] = selectSex;

                var itemsClinicMaterials = db.GetClinicMaterialsList();
                List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
                foreach (var item in itemsClinicMaterials)
                {
                    listClinicMaterial.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicMaterialGroup.DescriptionRus, Value = item.ClinicMaterialID.ToString() });
                }
                var selectClinicMaterial = new SelectList(listClinicMaterial, "Value", "Text", 1);
                ViewData["selectClinicMaterial"] = selectClinicMaterial;

                var itemsDoctors = db.GetDoctorsList();
                List<SelectListItem> listDoctor = new List<SelectListItem>();
                foreach (var item in itemsDoctors)
                {
                    listDoctor.Add(new SelectListItem { Text = item.Lastname + " " + item.Initials, Value = item.DoctorID.ToString() });
                }
                var selectDoctor = new SelectList(listDoctor, "Value", "Text", 1);
                ViewData["selectDoctor"] = selectDoctor;

                ViewBag.Queue = queue;
                ViewBag.ReturnString = returnString;

                return PartialView(obj);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Попробуйте повторить действие. В случае постоянного возникновения ошибки обратитесь к администратору";

                int temp = -1;
                if (queue == 1)
                {
                    temp = 1;
                }
                if (returnString == "PatientListFree")
                {
                    return RedirectToAction("PatientListFree", "Patient", new { message = strMessage, queue = temp });
                }
                else
                {
                    return RedirectToAction("PatientListPaid", "Patient", new { message = strMessage, queue = temp });
                }
            }
        }

        [HttpPost]
        [Authorize]
        //    [Ajax(true)]
        public ActionResult PartialPatientEdit(vwPatientEdit obj, string queue = "", string returnString = "")
        {
            if (ModelState.IsValid)
            {
                Patient patientObj = dbm.Patients.SingleOrDefault(o => o.PatientID == obj.PatientID);
                patientObj.Lastname = obj.Lastname;
                patientObj.Initials = obj.Initials;
                patientObj.Birthdate = obj.Birthdate;
                string tempSex;
                switch (obj.Sex)
                {
                    case "1":
                        tempSex = "Неизвестно";
                        break;
                    case "2":
                        tempSex = "Мужской";
                        break;
                    case "3":
                        tempSex = "Женский";
                        break;
                    default:
                        tempSex = "Неизвестно";
                        break;
                }
                patientObj.Sex = tempSex;
                dbm.SaveChanges();
                Sample sampleObj = dbm.Samples.SingleOrDefault(o => o.SampleID == obj.SampleID);
                sampleObj.ClinicMaterialID = obj.ClinicMaterialID;
                sampleObj.DoctorID = obj.DoctorID;
                sampleObj.DatetimeCapture = obj.DatetimeCapture;
                sampleObj.DatetimeDelivery = obj.DatetimeDelivery;
                dbm.SaveChanges();



                string strMessage = "Изменения в данных пацента " + obj.Lastname + " " + obj.Initials + " успешно сохранены";

                int temp = -1;
                if (queue == "1")
                {
                    temp = 1;
                }
                if (returnString == "PatientListFree")
                {
                   return  RedirectToAction("PatientListFree","Patient", new { message = strMessage, queue = temp });
                }
                else
                {
                    return  RedirectToAction("PatientListPaid","Patient", new { message = strMessage, queue = temp });
                }
            }
            else
            {
                int temp = -1;
                if (queue == "1")
                {
                    temp = 1;
                }
                ModelState.AddModelError("", "Невозможно сохранить изменения. Проверьте правильность заполнения всех полей.");
                string strMessage = "Изменения в данных пацента " + obj.Lastname + " " + obj.Initials + " не были сохранены из-за ошибок ввода";
                if (returnString == "PatientListFree")
                {
                    return RedirectToAction("PatientListFree", "Patient", new { message = strMessage, queue = temp });
                }
                else
                {
                    return RedirectToAction("PatientListPaid", "Patient", new { message = strMessage, queue = temp });
                }
            }
        }

        [Authorize]
        public void PrintPatientResult(int id)
        {
            try
            {

                objPatientResults obj = new objPatientResults();
                var sp = dbm.Samples
                    .Include(o => o.Patient)
                    .Include(o => o.Clinic)
                      .Include(o => o.Clinic.ClinicGroup)
                      .Include(o => o.ClinicMaterial)
                      .Include(o => o.Doctor)
                      .SingleOrDefault(o => o.SampleID == id);
                obj.SampleID = sp.SampleID.ToString();
                obj.Clinic = sp.Clinic.ClinicGroup.Description + " - " + sp.Clinic.Description;
                if (sp.SamplePaymentTypeID == 1)
                {
                    obj.Clinic += " (О)";
                }
                else
                {
                    obj.Clinic += " (К)";
                }
                obj.DoctorFIO = sp.Doctor.Lastname + " " + sp.Doctor.Initials;
                obj.PatientFIO = sp.Patient.Lastname + " " + sp.Patient.Initials;
                obj.PatientSex = sp.Patient.Sex;
                obj.BirthDate = DateTime.Parse(sp.Patient.Birthdate.ToString()).ToShortDateString();
                obj.ClinicMaterial = sp.ClinicMaterial.Description;
                obj.DateDeliverySample = sp.DatetimeDelivery.ToString();
                obj.DateRecieveSample = sp.DatetimeCapture.ToString();
                Patient patientObj = sp.Patient;
                patientObj.PrintedResults = 1;
                dbm.SaveChanges();
                // Получение собственно результатов
                obj.listAnalysis = new List<_itemAnalysis>();
                // получаем анализы для пациента
                int tempsample = int.Parse(obj.SampleID);
                var model = dbm.MBAnalysis.Where(o => o.SampleID == tempsample).ToList();
                foreach (var itemAnalysis in model)
                {
                    var itemsBac = dbm.MBAnalysisBacterioscopies.Include(o => o.MBBacterioscopyOrganismType).Where(o => o.MBAnalysisID == itemAnalysis.MBAnalysisID).ToList();
                    var itemsRO = dbm.ROes.Include(o => o.OrganismType).Include(o => o.ROandClinicalTests).Where(o => o.MBAnalysisID == itemAnalysis.MBAnalysisID).ToList();
                    _itemAnalysis tempIA = new _itemAnalysis();
                    tempIA.itemMBAnalysis = itemAnalysis;
                    tempIA.listBacterioscopy = itemsBac;
                    tempIA.listROes = new List<_itemRO>();
                    foreach (var itemRO in itemsRO)
                    {
                        var itemsROClinicTest = dbm.ROandClinicalTests.Include(o => o.AntibioticType).Include(o => o.Method).Where(o => o.ROID == itemRO.ROID).ToList();

                        _itemRO tempRO = new _itemRO();
                        tempRO.itemRO = itemRO;
                        tempRO.listROandClinicalTests = itemsROClinicTest;
                        tempIA.listROes.Add(tempRO);
                    }
                    obj.listAnalysis.Add(tempIA);
                }

                // Завершение получения результатов

                Printing objPrinter = new Printing();
                string resAddress = objPrinter.PrintPatientResults(obj);
                Response.ContentType = "application/text";
                Response.AddHeader("Content-Disposition", @"filename=""result_" + obj.SampleID.ToString() + ".rtf");
                Response.TransmitFile(@resAddress);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Попробуйте повторить действие. В случае постоянного возникновения ошибки обратитесь к администратору";
                Response.Write(strMessage);
            }
        }

        [Authorize]
        public void PrintPatientContract(int id)
        {
            try
            {
                objPatientContract obj = new objPatientContract();
                var sp = dbm.Samples
                    .Include(o => o.Patient)
                    .Include(o => o.Clinic)
                      .Include(o => o.Clinic.ClinicGroup)
                      .Include(o => o.ClinicMaterial)
                      .Include(o => o.Doctor)
                      .SingleOrDefault(o => o.SampleID == id);
                obj.SampleID = sp.SampleID.ToString();
                obj.Clinic = sp.Clinic.ClinicGroup.Description + " - " + sp.Clinic.Description;
                if (sp.SamplePaymentTypeID == 1)
                {
                    obj.Clinic += " (О)";
                }
                else
                {
                    obj.Clinic += " (К)";
                }
                obj.DoctorFIO = sp.Doctor.Lastname + " " + sp.Doctor.Initials;
                obj.PatientFIO = sp.Patient.Lastname + " " + sp.Patient.Initials;
                obj.PatientSex = sp.Patient.Sex;
                obj.BirthDate = DateTime.Parse(sp.Patient.Birthdate.ToString()).ToShortDateString();
                obj.ClinicMaterial = sp.ClinicMaterial.Description;
                obj.DateDeliverySample = sp.DatetimeDelivery.ToString();
                obj.DateRecieveSample = sp.DatetimeCapture.ToString();
                obj.DateContractStart = DateTime.Now.ToShortDateString();
                obj.DateContractEnd = DateTime.Now.AddDays(5).ToShortDateString();

                decimal total = 0;
                var al = dbm.vwMBAnalysisForSampleWithPrices.Where(o => o.SampleID == id).OrderBy(o => o.MBAnalysisTypesDesc).ToList();
                int cntAl = 0;
                obj.AnalysisList = new List<TableAnalysisItem>();
                foreach (var itemal in al)
                {
                    cntAl++;
                    total += (decimal)itemal.Price;
                    obj.AnalysisList.Add(new TableAnalysisItem
                    {
                        AnalysisPosition = cntAl.ToString(),
                        AnalysisCode = itemal.Code,
                        AnalysisDescription = itemal.MBAnalysisTypesDesc,
                        AnalysisPrice = itemal.Price.ToString()
                    });
                }

                var ads = dbm.SamplesAndAdditionalServices.Include(o => o.AdditionalService).Where(o => o.SampleID == id).OrderBy(o => o.AdditionalService.Description).ToList();
                int cntAds = 0;
                obj.AddServiceList = new List<TableAddServiceItem>();
                foreach (var itemads in ads)
                {
                    cntAds++;
                    total += (decimal)itemads.AdditionalService.Price;
                    obj.AddServiceList.Add(new TableAddServiceItem
                    {
                        AddServicePosition = cntAds.ToString(),
                        AddServiceCode = "-",
                        AddServiceDescription = itemads.AdditionalService.Description,
                        AddServicePrice = itemads.AdditionalService.Price.ToString()
                    });
                }
                int sum = (int)total;
                obj.TotalSum = sum.ToString();
                //new Diagnostics_FP.GeneratedXML.GeneratedPatientContract().CreatePackage(AppDomain.CurrentDomain.BaseDirectory + "Output" + obj.SampleID + ".docx", obj);
                //   string path = AppDomain.CurrentDomain.BaseDirectory;
                //  string fileName = "Output.docx";

                Printing objPrinter = new Printing();
                string resAddress = objPrinter.PrintContractForPatient(obj);
                Response.ContentType = "application/text";
                Response.AddHeader("Content-Disposition", @"filename=""contract_" + obj.SampleID.ToString() + ".rtf");
                Response.TransmitFile(@resAddress);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Попробуйте повторить действие. В случае постоянного возникновения ошибки обратитесь к администратору";
                Response.Write(strMessage);
            }

        }


        [Authorize]
        public ActionResult ContractsList(string ID)
        {
            var contracts = db.GetContractsForClinic(int.Parse(ID));
            List<SelectListItem> listContracts = new List<SelectListItem>();
            foreach (var item in contracts)
            {
                listContracts.Add(new SelectListItem { Text = item.Contract.Description.ToString(), Value = item.ClinicContractID.ToString() });
            }
            var selectContracts = new SelectList(listContracts, "Value", "Text", 25);
            if (HttpContext.Request.IsAjaxRequest())
                return Json(selectContracts, JsonRequestBehavior.AllowGet);
            return RedirectToAction("CreatePatientPaid");
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeletePatient(int patientId, string redirectAddr, int queue)
        {
            try
            {
                var tempSample = dbm.Samples.Include(o => o.Patient).SingleOrDefault(o => o.SampleID == patientId);
                //var mbAnalysisList = dbm.MBAnalysis.Where(o => o.SampleID == tempSample.SampleID).ToList();
                //int cntReady = 0;
                //foreach (var item in mbAnalysisList)
                //{
                //    if (item.MBStatusID != 2)
                //    {
                //        cntReady++;
                //    }
                //}
                string strMessage = "";
                //if (cntReady > 0)
                //{
                //    ViewData["Message"] = "Удаление пациента невозможно, поскольку за ним числятся завершенные анализы!";
                //}
                //else
                //{
                var obj = dbm.Patients.SingleOrDefault(o => o.PatientID == tempSample.PatientID);
                db.DeletePatient(patientId);
                strMessage = "Пациент " + obj.Lastname + " " + obj.Initials + " успешно удален.";
                // }
                if (redirectAddr == "Free")
                {
                    if (queue == 1)
                    {
                        return RedirectToAction("PatientListFree", new { message = strMessage, queue = 1 });
                    }
                    else
                    {
                        return RedirectToAction("PatientListFree", new { message = strMessage });
                    }
                }
                else
                {
                    if (queue == 1)
                    {
                        return RedirectToAction("PatientListPaid", new { message = strMessage, queue = 1 });
                    }
                    else
                    {
                        return RedirectToAction("PatientListPaid", new { message = strMessage, queue = 1 });
                    }
                }
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Удаление пациента закончилось с ошибкой.";
                if (redirectAddr == "Free")
                {
                    if (queue == 1)
                    {
                        return RedirectToAction("PatientListFree", new { message = strMessage, queue = 1 });
                    }
                    else
                    {
                        return RedirectToAction("PatientListFree", new { message = strMessage });
                    }
                }
                else
                {
                    if (queue == 1)
                    {
                        return RedirectToAction("PatientListPaid", new { message = strMessage, queue = 1 });
                    }
                    else
                    {
                        return RedirectToAction("PatientListPaid", new { message = strMessage, queue = 1 });
                    }
                }
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult PatientListFree(int? sampleId, string sortOrder, string patientFilter = "", string sampleFilter = "", string searchString = "", int? pageNum = 0, string message = "", int queue = -1)
        {
            try
            {
                vwPatientListFree obj = new vwPatientListFree();

                if (Request.HttpMethod == "GET")
                {
                    searchString = patientFilter;
                }
                else
                {
                    pageNum = 0;
                }
                ViewBag.CurrentFilter = searchString;
                // получение первоначального набора данных
                if (queue == -1)
                {

                    if (!String.IsNullOrEmpty(patientFilter) && !String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsFree().Where(o => o.Patient.Lastname.ToUpper().Contains(patientFilter.ToUpper()) && o.SampleID.ToString() == sampleFilter);
                    }
                    else if (!String.IsNullOrEmpty(patientFilter) && String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsFree().Where(o => o.Patient.Lastname.ToUpper().Contains(patientFilter.ToUpper()));
                    }
                    else if (String.IsNullOrEmpty(patientFilter) && !String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsFree().Where(o => o.SampleID.ToString() == sampleFilter);
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsFree();
                    }
                    ViewBag.Queue = -1;
                    ViewData["title"] = "Бесплатные анализы - Пациенты";
                }
                else
                {
                    ViewBag.Queue = 1;
                    ViewData["title"] = "Бесплатные анализы - Очередь пациентов";
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        obj.SamplesList = db.GetSamplesForContractsFreeQueue().Where(o => o.Patient.Lastname.ToUpper().Contains(searchString.ToUpper()));
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsFreeQueue();
                    }
                    if (!String.IsNullOrEmpty(sampleFilter))
                    {

                        obj.SamplesList = db.GetSamplesForContractsFreeQueue().Where(o => o.SampleNumber == int.Parse(sampleFilter));
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsFreeQueue();
                    }
                }
                //первоначальный набор данных получен

                ViewBag.CurrentSort = sortOrder;
                ViewBag.SampleNumberSortParm = sortOrder == "SampleNumber" ? "SampleNumber Desc" : "SampleNumber";
                ViewBag.FIOSortParm = sortOrder == "FIO" ? "FIO Desc" : "FIO";
                ViewBag.BirthDateSortParm = sortOrder == "BirthDate" ? "BirthDate Desc" : "BirthDate";
                ViewBag.SexSortParm = sortOrder == "Sex" ? "Sex Desc" : "Sex";
                ViewBag.ClinicSortParm = sortOrder == "Clinic" ? "Clinic Desc" : "Clinic";
                ViewBag.DoctorSortParm = sortOrder == "Doctor" ? "Doctor Desc" : "Doctor";
                ViewBag.DeliverySortParm = sortOrder == "Delivery" ? "Delivery Desc" : "Delivery";
                ViewBag.ClinicMaterialSortPArm = sortOrder == "ClinicMaterial" ? "ClinicMaterial Desc" : "ClinicMaterial";
                ViewBag.CaptureSortParm = sortOrder == "Capture" ? "Capture Desc" : "Capture";
                switch (sortOrder)
                {
                    case "Capture":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.DatetimeCapture);
                        break;
                    case "Capture Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.DatetimeCapture);
                        break;
                    case "ClinicMaterial":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.ClinicMaterial.Description);
                        break;
                    case "ClinicMaterial Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.ClinicMaterial.Description);
                        break;
                    case "SampleNumber":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.SampleNumber);
                        break;
                    case "SampleNumber Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.SampleNumber);
                        break;
                    case "FIO":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Lastname);
                        break;
                    case "FIO Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Lastname);
                        break;
                    case "BirthDate":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Birthdate);
                        break;
                    case "BirthDate Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Birthdate);
                        break;
                    case "Sex":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Sex);
                        break;
                    case "Sex Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Sex);
                        break;
                    case "Clinic":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Clinic.Description);
                        break;
                    case "Clinic Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Clinic.Description);
                        break;
                    case "Doctor":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Doctor.Lastname);
                        break;
                    case "Doctor Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Doctor.Lastname);
                        break;
                    case "Delivery":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.DatetimeDelivery);
                        break;
                    case "Delivery Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.DatetimeDelivery);
                        break;
                    default:
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.SampleNumber);
                        break;
                }

                int pageSize = 15;
                int itemsCount = obj.SamplesList.Count();
                ViewData["pageSize"] = pageSize;
                ViewData["pageNum"] = pageNum;
                ViewData["itemsCount"] = itemsCount;
                ViewData["activeSortOrder"] = sortOrder;
                ViewData["activeFilterString"] = searchString;
                ViewData["message"] = message;
                obj.SamplesList = obj.SamplesList.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();
                // отображение подробных сведений
                ViewBag.CountReadyAnalysis = -1;
                if (sampleId != null)
                {
                    ViewData["sampleId"] = sampleId;
                    ViewBag.SampleID = sampleId;
                    obj.MBAnalysisListForSample = dbm.vwMBAnalysisForSampleWithPrices.Where(o => o.SampleID == sampleId).OrderBy(o => o.MBAnalysisTypesDesc).ToList();
                    obj.AdditionalServicesForSample = dbm.SamplesAndAdditionalServices.Include(o => o.AdditionalService).Where(o => o.SampleID == sampleId).OrderBy(o => o.AdditionalService.Description).ToList();
                    var sampleItem = dbm.Samples.SingleOrDefault(o => o.SampleID == sampleId);
                    var clinicContractItem = dbm.ClinicsAndContracts.Include(o => o.Contract).SingleOrDefault(o => o.ClinicContractID == sampleItem.ClinicContractID);
                    ViewData["contractText"] = clinicContractItem.Contract.Description + " - рег.№ " + clinicContractItem.Contract.AccountNumber;
                    obj.totalAddServices = 0;
                    obj.totalAnalysis = 0;
                    obj.totalAll = 0;
                    int countReadyAnalysis = 0;
                    int countNotReadyAnalysis = 0;
                    foreach (var itemAnalysis in obj.MBAnalysisListForSample)
                    {
                        obj.totalAnalysis += (decimal)itemAnalysis.Price;
                        obj.totalAll += (decimal)itemAnalysis.Price;
                        if (itemAnalysis.MBStatusesDesc == "Получен результат")
                        {
                            countReadyAnalysis += 1;
                        }
                        if (itemAnalysis.MBStatusesDesc == "Неизвестно")
                        {
                            countNotReadyAnalysis += 1;
                        }

                    }
                    ViewBag.CountReadyAnalysis = countReadyAnalysis;
                    ViewBag.CountNotReadyAnalysis = countNotReadyAnalysis;
                    foreach (var itemAddService in obj.AdditionalServicesForSample)
                    {
                        obj.totalAddServices += (decimal)itemAddService.AdditionalService.Price;
                        obj.totalAll += (decimal)itemAddService.AdditionalService.Price;
                    }
                }
                else
                {
                    ViewBag.SampleID = null;
                }

                // ОПТИМИЗИРОВАТЬ, ЧТОБЫ ВЫДАВАЛА НЕ ВЕСЬ ПЕРЕЧЕНЬ, А ТОЛЬКО НУЖНУЮ СТРАНИЦУ ДАННЫХ
                //obj.SamplesList = db.GetSamplesForContractsFree();

                return View(obj);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Получение списка пациентов не удалось.";
                Response.Write(strMessage);
                return null;
            }
        }

        [Authorize]
        public ActionResult PatientListPaid(int? sampleId, string sortOrder, string patientFilter = "", string sampleFilter = "", string searchString = "", int? pageNum = 0, string message = "", int queue = -1)
        {
            try
            {
                vwPatientListPaid obj = new vwPatientListPaid();

                if (Request.HttpMethod == "GET")
                {
                    searchString = patientFilter;
                }
                else
                {
                    pageNum = 0;
                }
                ViewBag.CurrentFilter = searchString;
                // получение первоначального набора данных
                if (queue == -1)
                {

                    if (!String.IsNullOrEmpty(patientFilter) && !String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaid().Where(o => o.Patient.Lastname.ToUpper().Contains(patientFilter.ToUpper()) && o.SampleID.ToString() == sampleFilter);
                    }
                    else if (!String.IsNullOrEmpty(patientFilter) && String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaid().Where(o => o.Patient.Lastname.ToUpper().Contains(patientFilter.ToUpper()));
                    }
                    else if (String.IsNullOrEmpty(patientFilter) && !String.IsNullOrEmpty(sampleFilter))
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaidQueue().Where(o => o.SampleID.ToString() == sampleFilter);
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaid();
                    }
                    ViewBag.Queue = -1;
                    ViewData["title"] = "Платные анализы - Пациенты";
                }
                else
                {
                    ViewBag.Queue = 1;
                    ViewData["title"] = "Платные анализы - Очередь пациентов";
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaidQueue().Where(o => o.Patient.Lastname.ToUpper().Contains(searchString.ToUpper()));
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaidQueue();
                    }
                    if (!String.IsNullOrEmpty(sampleFilter))
                    {

                        obj.SamplesList = db.GetSamplesForContractsPaidQueue().Where(o => o.SampleNumber == int.Parse(sampleFilter));
                    }
                    else
                    {
                        obj.SamplesList = db.GetSamplesForContractsPaidQueue();
                    }
                }
                // Завершение получения первоначального набора данных

                ViewBag.CurrentSort = sortOrder;
                ViewBag.SampleNumberSortParm = sortOrder == "SampleNumber" ? "SampleNumber Desc" : "SampleNumber";
                ViewBag.FIOSortParm = sortOrder == "FIO" ? "FIO Desc" : "FIO";
                ViewBag.BirthDateSortParm = sortOrder == "BirthDate" ? "BirthDate Desc" : "BirthDate";
                ViewBag.SexSortParm = sortOrder == "Sex" ? "Sex Desc" : "Sex";
                ViewBag.ClinicSortParm = sortOrder == "Clinic" ? "Clinic Desc" : "Clinic";
                ViewBag.DoctorSortParm = sortOrder == "Doctor" ? "Doctor Desc" : "Doctor";
                ViewBag.DeliverySortParm = sortOrder == "Delivery" ? "Delivery Desc" : "Delivery";
                ViewBag.ClinicMaterialSortParm = sortOrder == "ClinicMaterial" ? "ClinicMaterial Desc" : "ClinicMaterial";
                ViewBag.CaptureSortParm = sortOrder == "Capture" ? "Capture Desc" : "Capture";
                switch (sortOrder)
                {
                    case "Capture":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.DatetimeCapture);
                        break;
                    case "Capture Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.DatetimeCapture);
                        break;
                    case "ClinicMaterial":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.ClinicMaterial.Description);
                        break;
                    case "ClinicMaterial Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.ClinicMaterial.Description);
                        break;
                    case "SampleNumber":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.SampleNumber);
                        break;
                    case "SampleNumber Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.SampleNumber);
                        break;
                    case "FIO":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Lastname);
                        break;
                    case "FIO Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Lastname);
                        break;
                    case "BirthDate":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Birthdate);
                        break;
                    case "BirthDate Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Birthdate);
                        break;
                    case "Sex":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Patient.Sex);
                        break;
                    case "Sex Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Patient.Sex);
                        break;
                    case "Clinic":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Clinic.Description);
                        break;
                    case "Clinic Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Clinic.Description);
                        break;
                    case "Doctor":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.Doctor.Lastname);
                        break;
                    case "Doctor Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.Doctor.Lastname);
                        break;
                    case "Delivery":
                        obj.SamplesList = obj.SamplesList.OrderBy(o => o.DatetimeDelivery);
                        break;
                    case "Delivery Desc":
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.DatetimeDelivery);
                        break;
                    default:
                        obj.SamplesList = obj.SamplesList.OrderByDescending(o => o.SampleNumber);
                        break;
                }

                int pageSize = 15;
                int itemsCount = obj.SamplesList.Count();
                ViewData["pageSize"] = pageSize;
                ViewData["pageNum"] = pageNum;
                ViewData["itemsCount"] = itemsCount;
                ViewData["activeSortOrder"] = sortOrder;
                ViewData["activeFilterString"] = searchString;
                ViewData["message"] = message;
                obj.SamplesList = obj.SamplesList.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();
                // отображение подробных сведений
                ViewBag.CountReadyAnalysis = -1;
                if (sampleId != null)
                {
                    ViewData["sampleId"] = sampleId;
                    ViewBag.SampleID = sampleId;
                    obj.MBAnalysisListForSample = dbm.vwMBAnalysisForSampleWithPrices.Where(o => o.SampleID == sampleId).OrderBy(o => o.MBAnalysisTypesDesc).ToList();
                    obj.AdditionalServicesForSample = dbm.SamplesAndAdditionalServices.Include(o => o.AdditionalService).Where(o => o.SampleID == sampleId).OrderBy(o => o.AdditionalService.Description).ToList();
                    var sampleItem = dbm.Samples.SingleOrDefault(o => o.SampleID == sampleId);
                    var clinicContractItem = dbm.ClinicsAndContracts.Include(o => o.Contract).SingleOrDefault(o => o.ClinicContractID == sampleItem.ClinicContractID);
                    ViewData["contractText"] = clinicContractItem.Contract.Description + " - рег.№ " + clinicContractItem.Contract.AccountNumber;
                    obj.totalAddServices = 0;
                    obj.totalAnalysis = 0;
                    obj.totalAll = 0;
                    int countReadyAnalysis = 0;
                    int countNotReadyAnalysis = 0;
                    foreach (var itemAnalysis in obj.MBAnalysisListForSample)
                    {
                        obj.totalAnalysis += (decimal)itemAnalysis.Price;
                        obj.totalAll += (decimal)itemAnalysis.Price;
                        if (itemAnalysis.MBStatusesDesc == "Получен результат")
                        {
                            countReadyAnalysis += 1;
                        }
                        if (itemAnalysis.MBStatusesDesc == "Неизвестно")
                        {
                            countNotReadyAnalysis += 1;
                        }

                    }
                    ViewBag.CountReadyAnalysis = countReadyAnalysis;
                    ViewBag.CountNotReadyAnalysis = countNotReadyAnalysis;
                    foreach (var itemAddService in obj.AdditionalServicesForSample)
                    {
                        obj.totalAddServices += (decimal)itemAddService.AdditionalService.Price;
                        obj.totalAll += (decimal)itemAddService.AdditionalService.Price;
                    }
                }
                else
                {
                    ViewBag.SampleID = null;
                }

                // ОПТИМИЗИРОВАТЬ, ЧТОБЫ ВЫДАВАЛА НЕ ВЕСЬ ПЕРЕЧЕНЬ, А ТОЛЬКО НУЖНУЮ СТРАНИЦУ ДАННЫХ
                //obj.SamplesList = db.GetSamplesForContractsFree();

                return View(obj);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Получение списка пациентов не удалось.";
                Response.Write(strMessage);
                return null;
            }
        }

        [Authorize]
        public ActionResult CreatePatientFree()
        {
            try
            {
                vwCreatePatientFree obj = new vwCreatePatientFree();
                obj.SampleObj = new Sample();
                obj.SampleObj.DatetimeCapture = DateTime.Now;
                obj.SampleObj.DatetimeDelivery = DateTime.Now;
                obj.MBAdditionalServiceList = db.GetAdditionalServiceListActive();
                obj.MBAnalysisList = db.GetMBAnalysisTypeListActive();

                //   var itemsSex = 

                List<SelectListItem> listSex = new List<SelectListItem>();
                listSex.Add(new SelectListItem { Text = "Неизвестно", Value = "1" });
                listSex.Add(new SelectListItem { Text = "Мужской", Value = "2" });
                listSex.Add(new SelectListItem { Text = "Женский", Value = "3" });
                var selectSex = new SelectList(listSex, "Value", "Text", 1);
                ViewData["selectSex"] = selectSex;

                var itemsClinicMaterials = db.GetClinicMaterialsList();
                List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
                foreach (var item in itemsClinicMaterials)
                {
                    listClinicMaterial.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicMaterialGroup.DescriptionRus, Value = item.ClinicMaterialID.ToString() });
                }
                var selectClinicMaterial = new SelectList(listClinicMaterial, "Value", "Text", 1);
                ViewData["selectClinicMaterial"] = selectClinicMaterial;

                var itemsDoctors = db.GetDoctorsList();
                List<SelectListItem> listDoctor = new List<SelectListItem>();
                foreach (var item in itemsDoctors)
                {
                    listDoctor.Add(new SelectListItem { Text = item.Lastname + " " + item.Initials, Value = item.DoctorID.ToString() });
                }
                var selectDoctor = new SelectList(listDoctor, "Value", "Text", 1);
                ViewData["selectDoctor"] = selectDoctor;

                var itemsClinics = db.GetClinicList();
                List<SelectListItem> listClinic = new List<SelectListItem>();
                foreach (var item in itemsClinics)
                {
                    listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                }
                var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
                ViewData["selectClinic"] = selectClinic;

                var itemsPatientStatusTypes = db.GetPatientStatusTypeList();
                List<SelectListItem> listPatientStatusTypes = new List<SelectListItem>();
                foreach (var item in itemsPatientStatusTypes)
                {
                    listPatientStatusTypes.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.PatientStatusTypeID.ToString() });
                }
                var selectPatientStatusTypes = new SelectList(listPatientStatusTypes, "Value", "Text", 1);
                ViewData["selectPatientStatusTypes"] = selectPatientStatusTypes;

                return View(obj);
            }
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Получение формы для ввода пациента не удалось";
                Response.Write(strMessage);
                return null;
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreatePatientFree(vwCreatePatientFree obj, string[] selectedMBAnalysis, string[] selectedAdditionalServices)
        {
            try
            {

                if ((ModelState.IsValidField("2")) && (ModelState.IsValidField("3")) && (ModelState.IsValidField("4")) && (ModelState.IsValidField("9")) && (ModelState.IsValidField("10"))
                    && (selectedAdditionalServices != null) && (selectedMBAnalysis != null))
                {
                    //Insert Patient

                    int resPatientID = db.AddPatientNewForDiagnosis(obj.PatientObj);
                    obj.SampleObj.PatientID = resPatientID;
                    var resClinicContract = db.GetClinicContractId(25, obj.SampleObj.ClinicID);
                    obj.SampleObj.ClinicContractID = resClinicContract.ClinicContractID;
                    //Insert Sample
                    int resSampleID = db.AddSampleNewForDiagnosisFree(obj.SampleObj);
                    //insert MBAnalysis
                    foreach (var item in selectedMBAnalysis)
                    {
                        db.AddMBAnalysisToSample(resSampleID, int.Parse(item.ToString()));
                    }
                    //insert AdditionalServices
                    foreach (var item in selectedAdditionalServices)
                    {
                        db.AddAdditionalServiceToSample(resSampleID, int.Parse(item.ToString()));
                    }
                    string strMessage = "Образец успешно добавлен в систему. Образцу, принятому от пацента " +
                        obj.PatientObj.Lastname + " " + obj.PatientObj.Initials +
                        " присвоен номер " + resSampleID.ToString();
                    return RedirectToAction("PatientListFree", new { message = strMessage, queue = 1 });
                }
                else
                {
                    List<SelectListItem> listSex = new List<SelectListItem>();
                    listSex.Add(new SelectListItem { Text = "Неизвестно", Value = "1" });
                    listSex.Add(new SelectListItem { Text = "Мужской", Value = "2" });
                    listSex.Add(new SelectListItem { Text = "Женский", Value = "3" });
                    var selectSex = new SelectList(listSex, "Value", "Text", 1);
                    ViewData["selectSex"] = selectSex;

                    var itemsClinicMaterials = db.GetClinicMaterialsList();
                    List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
                    foreach (var item in itemsClinicMaterials)
                    {
                        listClinicMaterial.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicMaterialGroup.DescriptionRus, Value = item.ClinicMaterialID.ToString() });
                    }
                    var selectClinicMaterial = new SelectList(listClinicMaterial, "Value", "Text", 1);
                    ViewData["selectClinicMaterial"] = selectClinicMaterial;

                    var itemsDoctors = db.GetDoctorsList();
                    List<SelectListItem> listDoctor = new List<SelectListItem>();
                    foreach (var item in itemsDoctors)
                    {
                        listDoctor.Add(new SelectListItem { Text = item.Lastname + " " + item.Initials, Value = item.DoctorID.ToString() });
                    }
                    var selectDoctor = new SelectList(listDoctor, "Value", "Text", 1);
                    ViewData["selectDoctor"] = selectDoctor;

                    var itemsClinics = db.GetClinicList();
                    List<SelectListItem> listClinic = new List<SelectListItem>();
                    foreach (var item in itemsClinics)
                    {
                        listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                    }
                    var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
                    ViewData["selectClinic"] = selectClinic;

                    var itemsPatientStatusTypes = db.GetPatientStatusTypeList();
                    List<SelectListItem> listPatientStatusTypes = new List<SelectListItem>();
                    foreach (var item in itemsPatientStatusTypes)
                    {
                        listPatientStatusTypes.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.PatientStatusTypeID.ToString() });
                    }
                    var selectPatientStatusTypes = new SelectList(listPatientStatusTypes, "Value", "Text", 1);
                    ViewData["selectPatientStatusTypes"] = selectPatientStatusTypes;

                    obj.MBAdditionalServiceList = db.GetAdditionalServiceListActive();
                    obj.MBAnalysisList = db.GetMBAnalysisTypeListActive();


                    ModelState.AddModelError("", "Невозможно сохранить изменения. Проверьте правильность заполнения всех полей.");
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " | " + ex.GetType().ToString() + " | " + "Невозможно сохранить изменения. Проверьте правильность заполнения всех полей.");
            }

            return View(obj);
        }


        [Authorize]
        public ActionResult CreatePatientPaid()
        {
            try
            {
                vwCreatePatientPaid obj = new vwCreatePatientPaid();
                obj.SampleObj = new Sample();
                obj.SampleObj.DatetimeCapture = DateTime.Now;
                obj.SampleObj.DatetimeDelivery = DateTime.Now;
                obj.MBAdditionalServiceList = db.GetAdditionalServiceListActive();
                obj.MBAnalysisList = db.GetMBAnalysisTypeListActive();

                //   var itemsSex = 

                List<SelectListItem> listSex = new List<SelectListItem>();
                listSex.Add(new SelectListItem { Text = "Неизвестно", Value = "1" });
                listSex.Add(new SelectListItem { Text = "Мужской", Value = "2" });
                listSex.Add(new SelectListItem { Text = "Женский", Value = "3" });
                var selectSex = new SelectList(listSex, "Value", "Text", 1);
                ViewData["selectSex"] = selectSex;

                var itemsClinicMaterials = db.GetClinicMaterialsList();
                List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
                foreach (var item in itemsClinicMaterials)
                {
                    listClinicMaterial.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicMaterialGroup.DescriptionRus, Value = item.ClinicMaterialID.ToString() });
                }
                var selectClinicMaterial = new SelectList(listClinicMaterial, "Value", "Text", 1);
                ViewData["selectClinicMaterial"] = selectClinicMaterial;

                var itemsDoctors = db.GetDoctorsList();
                List<SelectListItem> listDoctor = new List<SelectListItem>();
                foreach (var item in itemsDoctors)
                {
                    listDoctor.Add(new SelectListItem { Text = item.Lastname + " " + item.Initials, Value = item.DoctorID.ToString() });
                }
                var selectDoctor = new SelectList(listDoctor, "Value", "Text", 1);
                ViewData["selectDoctor"] = selectDoctor;

                var itemsClinics = db.GetClinicList();
                List<SelectListItem> listClinic = new List<SelectListItem>();
                foreach (var item in itemsClinics)
                {
                    listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                }
                var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
                ViewData["selectClinic"] = selectClinic;

                var itemsPatientStatusTypes = db.GetPatientStatusTypeList();
                List<SelectListItem> listPatientStatusTypes = new List<SelectListItem>();
                foreach (var item in itemsPatientStatusTypes)
                {
                    listPatientStatusTypes.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.PatientStatusTypeID.ToString() });
                }
                var selectPatientStatusTypes = new SelectList(listPatientStatusTypes, "Value", "Text", 1);
                ViewData["selectPatientStatusTypes"] = selectPatientStatusTypes;

                return View(obj);
            }
                  
            catch (DataException ex)
            {
                string strMessage = "Ошибка " + ex.Message + ". Получение формы для ввода пациента не удалось";
                Response.Write(strMessage);
                return null;
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreatePatientPaid(vwCreatePatientPaid obj, string[] selectedMBAnalysis, string[] selectedAdditionalServices, string Contract)
        {

            try
            {

                if ((ModelState.IsValidField("2")) && (ModelState.IsValidField("3")) && (ModelState.IsValidField("4")) && (ModelState.IsValidField("9")) && (ModelState.IsValidField("10"))
                    && (selectedAdditionalServices != null) && (selectedMBAnalysis != null))
                {
                    //Insert Patient

                    int resPatientID = db.AddPatientNewForDiagnosis(obj.PatientObj);
                    obj.SampleObj.PatientID = resPatientID;
                    obj.SampleObj.ClinicContractID = int.Parse(Contract.ToString());
                    //Insert Sample
                    int resSampleID = db.AddSampleNewForDiagnosisPaid(obj.SampleObj);
                    //insert MBAnalysis
                    foreach (var item in selectedMBAnalysis)
                    {
                        db.AddMBAnalysisToSample(resSampleID, int.Parse(item.ToString()));
                    }
                    //insert AdditionalServices
                    foreach (var item in selectedAdditionalServices)
                    {
                        db.AddAdditionalServiceToSample(resSampleID, int.Parse(item.ToString()));
                    }
                    string strMessage = "Образец успешно добавлен в систему. Образцу, принятому от пацента " +
                        obj.PatientObj.Lastname + " " + obj.PatientObj.Initials +
                        " присвоен номер " + resSampleID.ToString();
                    return RedirectToAction("PatientListPaid", new {message = strMessage, queue = 1 });

                }
                else
                {
                    obj.MBAdditionalServiceList = db.GetAdditionalServiceListActive();
                    obj.MBAnalysisList = db.GetMBAnalysisTypeListActive();

                    List<SelectListItem> listSex = new List<SelectListItem>();
                    listSex.Add(new SelectListItem { Text = "Неизвестно", Value = "1" });
                    listSex.Add(new SelectListItem { Text = "Мужской", Value = "2" });
                    listSex.Add(new SelectListItem { Text = "Женский", Value = "3" });
                    var selectSex = new SelectList(listSex, "Value", "Text", 1);
                    ViewData["selectSex"] = selectSex;

                    var itemsClinicMaterials = db.GetClinicMaterialsList();
                    List<SelectListItem> listClinicMaterial = new List<SelectListItem>();
                    foreach (var item in itemsClinicMaterials)
                    {
                        listClinicMaterial.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicMaterialGroup.DescriptionRus, Value = item.ClinicMaterialID.ToString() });
                    }
                    var selectClinicMaterial = new SelectList(listClinicMaterial, "Value", "Text", 1);
                    ViewData["selectClinicMaterial"] = selectClinicMaterial;

                    var itemsDoctors = db.GetDoctorsList();
                    List<SelectListItem> listDoctor = new List<SelectListItem>();
                    foreach (var item in itemsDoctors)
                    {
                        listDoctor.Add(new SelectListItem { Text = item.Lastname + " " + item.Initials, Value = item.DoctorID.ToString() });
                    }
                    var selectDoctor = new SelectList(listDoctor, "Value", "Text", 1);
                    ViewData["selectDoctor"] = selectDoctor;

                    var itemsClinics = db.GetClinicList();
                    List<SelectListItem> listClinic = new List<SelectListItem>();
                    foreach (var item in itemsClinics)
                    {
                        listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                    }
                    var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
                    ViewData["selectClinic"] = selectClinic;

                    var itemsPatientStatusTypes = db.GetPatientStatusTypeList();
                    List<SelectListItem> listPatientStatusTypes = new List<SelectListItem>();
                    foreach (var item in itemsPatientStatusTypes)
                    {
                        listPatientStatusTypes.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.PatientStatusTypeID.ToString() });
                    }
                    var selectPatientStatusTypes = new SelectList(listPatientStatusTypes, "Value", "Text", 1);
                    ViewData["selectPatientStatusTypes"] = selectPatientStatusTypes;

                    ModelState.AddModelError("", "Невозможно сохранить изменения. Проверьте правильность заполнения всех полей.");

                    return View(obj);

                   
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message.ToString() + " | " + ex.GetType().ToString() + " | " + "Невозможно сохранить изменения. Проверьте правильность заполнения всех полей.");
            }

            return View(obj);
        }

    }
}

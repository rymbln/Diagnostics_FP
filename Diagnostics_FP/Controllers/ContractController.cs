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
using Diagnostics_FP.Infrastructure;

namespace Diagnostics_FP.Controllers
{
    public class ContractController : Controller
    {

        private DataManager db = new DataManager();
        private mlabEntities dbm = new mlabEntities();
        //
        // GET: /Contract/

      
       
        [Authorize]
        public ActionResult ContractClinicDelete(int contractId, int clinicId)
        {
            db.DeleteClinicContract(contractId, clinicId);
            return RedirectToAction("EditContract", new { id = contractId, showClinic = 1 });
        }

        [Authorize]
        public ActionResult ContractMBAnalysisDelete(int contractAndMBAnalysisId, int contractId)
        {
            db.DeleteMBAnalysisInContract(contractAndMBAnalysisId);
            return RedirectToAction("EditContract", new { id = contractId, showAnalysis = 1 });
        }

        [Authorize]
        public ActionResult EditContract(int id, int showClinic = 0, int showAnalysis = 0)
        {
            vwEditContract obj = new vwEditContract();
            obj.selectedContract = dbm.Contracts.SingleOrDefault(o => o.ContractID == id);
            if (showClinic > 0)
            {
                obj.listClinicForContract = db.GetClinicsListForContract(id);
            }
            else
            {
                obj.listClinicForContract = null;
            }
            if (showAnalysis > 0)
            {
                obj.listMBAnalysisForContract = db.GetMBAnalysisListForContract(id);
            }
            else
            {
                obj.listMBAnalysisForContract = null;
            }
            return View(obj);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditContract(vwEditContract model)
        {
            Contract obj = new Contract();
            obj = model.selectedContract;
            db.EditContract(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialContractMBAnalysisEdit(int contractMBAnalysisId = -1, int contractId = -1)
        {
            ContractsAndMBAnalysisType model = new ContractsAndMBAnalysisType();
            if (contractMBAnalysisId > 0)
            {
                model = dbm.ContractsAndMBAnalysisTypes.SingleOrDefault(o => o.ContractAndMBAnalysisTypeID == contractMBAnalysisId);
                var itemsAnalysis = db.GetMBAnalysisTypeListActive();
                List<SelectListItem> listAnalysis = new List<SelectListItem>();
                foreach (var item in itemsAnalysis)
                {
                    listAnalysis.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBAnalysisTypeID.ToString() });
                }
                var selectAnalysis = new SelectList(listAnalysis, "Value", "Text", model.MBAnalysisTypeID);
                var itemsPaymentType = db.GetPaymentTypeList();
                List<SelectListItem> listPaymentType = new List<SelectListItem>();
                foreach (var item in itemsPaymentType)
                {
                    listPaymentType.Add(new SelectListItem { Text = item.Description, Value = item.PaymentTypeID.ToString() });
                }
                var selectPaymentType = new SelectList(listPaymentType, "Value", "Text", model.PaymentTypeID );
                ViewData["selectAnalysis"] = selectAnalysis;
                ViewData["selectPaymentType"] = selectPaymentType;
                ViewData["titleText"] = "Редактирование стоимости анализа";
                ViewData["buttonText"] = "Сохранить";
            }
            else
            {
                model.ContractAndMBAnalysisTypeID = -1;
                model.ContractID = contractId;
                var itemsAnalysis = db.GetMBAnalysisTypeListActive();
                List<SelectListItem> listAnalysis = new List<SelectListItem>();
                foreach (var item in itemsAnalysis)
                {
                    listAnalysis.Add(new SelectListItem { Text = item.DescriptionRus, Value = item.MBAnalysisTypeID.ToString() });
                }
                var selectAnalysis = new SelectList(listAnalysis, "Value", "Text");
                var itemsPaymentType = db.GetPaymentTypeList();
                List<SelectListItem> listPaymentType = new List<SelectListItem>();
                foreach (var item in itemsPaymentType)
                {
                    listPaymentType.Add(new SelectListItem { Text = item.Description, Value = item.PaymentTypeID.ToString() });
                }
                var selectPaymentType = new SelectList(listPaymentType, "Value", "Text");
                ViewData["selectAnalysis"] = selectAnalysis;
                ViewData["selectPaymentType"] = selectPaymentType;
                ViewData["titleText"] = "Добавление нового анализа в контракт";
                ViewData["buttonText"] = "Добавить";
            }
            return PartialView("PartialContractMBAnalysisEdit", model);
        }

        [HttpGet]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialContractClinicEdit(int clinicAndContractId = -1, int contractId = -1)
        {
            ClinicsAndContract model = new ClinicsAndContract();
            if (clinicAndContractId > 0)
            {
                model = dbm.ClinicsAndContracts.SingleOrDefault(o => o.ClinicContractID == clinicAndContractId);
                //  model.ContractID = contractId;
                var itemsClinics = db.GetClinicList();
                List<SelectListItem> listClinic = new List<SelectListItem>();
                foreach (var item in itemsClinics)
                {
                    listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                }
                var selectClinic = new SelectList(listClinic, "Value", "Text", model.ClinicContractID);
                ViewData["selectClinic"] = selectClinic;
                ViewData["titleText"] = "Редактирование ЛПУ и отделения";
                ViewData["buttonText"] = "Сохранить";

            }
            else
            {
                model.ClinicContractID = -1;
                model.ContractID = contractId;
                var itemsClinics = db.GetClinicList();
                List<SelectListItem> listClinic = new List<SelectListItem>();
                foreach (var item in itemsClinics)
                {
                    listClinic.Add(new SelectListItem { Text = item.Description + " - " + item.ClinicGroup.Description, Value = item.ClinicID.ToString() });
                }
                var selectClinic = new SelectList(listClinic, "Value", "Text", 1);
                ViewData["selectClinic"] = selectClinic;
                ViewData["titleText"] = "Добавление нового отделения";
                ViewData["buttonText"] = "Добавить";
            }
            return PartialView("PartialContractClinicEdit", model);
        }

        [HttpPost]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialContractMbAnalysisEdit(ContractsAndMBAnalysisType obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ContractAndMBAnalysisTypeID == -1)
                {
                    db.AddMBAnalysisToContract(int.Parse(obj.ContractID.ToString()), int.Parse(obj.MBAnalysisTypeID.ToString()), int.Parse(obj.PaymentTypeID.ToString()), decimal.Parse(obj.Price.ToString()));
                }
                else
                {
                    db.EditMBAnalysisInContract(obj);
                }
                ModelState.Clear();
            }
            return RedirectToAction("EditContract", new { id = obj.ContractID, showAnalysis = 1 });
        }

        [HttpPost]
        [Authorize]
        [Ajax(true)]
        public ActionResult PartialContractClinicEdit(ClinicsAndContract obj )
        {
            if (ModelState.IsValid)
            {
                if (obj.ClinicContractID == -1)
                {
                    db.AddClinicToContract(obj.ContractID, obj.ClinicID);
                }
                else
                {
                    db.EditClinicInContract(obj);
                }
                ModelState.Clear();
            }
            return RedirectToAction("EditContract", new { id = obj.ContractID, showClinic = 1 });
                    }

        [Authorize]
        public ActionResult PartialEditContractMBAnalysis()
        {
            return PartialView("PartialEditContractMBAnalysis");
        }

        [Authorize]
        public ViewResult Index(string sortOrder, string currentFilter = "", string searchString = "", int? pageNum = 0, string message = "", int contractId = 0)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CodeSortParm = sortOrder == "Code" ? "Code Desc" : "Code";
            ViewBag.DescriptionSortParm = sortOrder == "Description" ? "Description Desc" : "Description";
            ViewBag.AccountNumberSortParm = sortOrder == "AccountNumber" ? "AccountNumber Desc" : "AccountNumber";
            ViewBag.DateStartSortParm = sortOrder == "DateStart" ? "DateStart Desc" : "DateStart";
            ViewBag.DateEndSortParm = sortOrder == "DateEnd" ? "DateEnd Desc" : "DateEnd";
            if (Request.HttpMethod == "GET")
            {
                searchString = currentFilter;
            }
            else
            {
                pageNum = 0;
            }
            ViewBag.CurrentFilter = searchString;
            var objs = from o in db.GetContractsList()
                       select o;
            if (!String.IsNullOrEmpty(searchString))
            {
                objs = objs.Where(o => o.AccountNumber.ToUpper().Contains(searchString.ToUpper()) ||
                    o.Description.ToUpper().Contains(searchString.ToUpper()) ||
                    o.Code.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Code":
                    objs = objs.OrderBy(o => o.Code);
                    break;
                case "Code Desc":
                    objs = objs.OrderByDescending(o => o.Code);
                    break;
                case "Description":
                    objs = objs.OrderBy(o => o.Description);
                    break;
                case "Description Desc":
                    objs = objs.OrderByDescending(o => o.Description);
                    break;
                case "AccountNumber":
                    objs = objs.OrderBy(o => o.AccountNumber);
                    break;
                case "AccountNumber Desc":
                    objs = objs.OrderByDescending(o => o.AccountNumber);
                    break;
                case "DateStart":
                    objs = objs.OrderBy(o => o.DateStart);
                    break;
                case "DateStart Desc":
                    objs = objs.OrderByDescending(o => o.DateStart);
                    break;
                case "DateEnd":
                    objs = objs.OrderBy(o => o.DateEnd);
                    break;
                case "DateEnd Desc":
                    objs = objs.OrderByDescending(o => o.DateEnd);
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
            ViewData["message"] = message;
            objs = objs.Skip((int)(pageSize * pageNum)).Take(pageSize).ToList();

            if (contractId > 0)
            {
                ViewBag.contractId = contractId;
                ViewBag.listClinics = db.GetClinicsListForContract(contractId);
                ViewBag.listAnalysis = db.GetMBAnalysisListForContract(contractId);
            }
            else
            {
                ViewBag.contractId = null;
                ViewBag.listClinics = null;
                ViewBag.listAnalysis = null;
            }
            return View(objs);
        }


        [Authorize]
        public ActionResult CreateContract()
        {
            var logicList = db.GetLogicList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var obj in logicList)
            {
                items.Add(new SelectListItem { Text = obj.DescriptionRus.ToString(), Value = obj.LogicID.ToString() });
            }
            ViewBag.LogicList = items;
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult CreateContract(Contract obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = db.AddContract(obj);
                    return RedirectToAction("CreateContractWithClinics", new { id = id });
                }
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", ex.Message + " Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.");
            }
            return RedirectToAction("CreateContractWithClinics");
        }

        [Authorize]
        public ActionResult CreateContractWithClinics(int id)
        {
            Contract new_c = new Contract();
            new_c = db.GetContract(id);
            vwCreateContractWithClinic obj = new vwCreateContractWithClinic();
            obj.ContractItem = new_c;
            obj.ContractClinics = dbm.vw_ClinicList;
            return View(obj);
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateContractWithClinics(vwCreateContractWithClinic model, string[] selectedClinics)
        {
            if (selectedClinics != null)
            {
                foreach (var item in selectedClinics)
                {
                    db.AddClinicToContract(model.ContractItem.ContractID, int.Parse(item));
                }
            }
            return RedirectToAction("CreateContractWithMBAnalysis", new { id = model.ContractItem.ContractID });
        }

        public class tempSelectList
        {
            public int id { get; set; }
            public string Text { get; set; }
        }

        [Authorize]
        public ActionResult CreateContractWithMBAnalysis(int id)
        {

            //ContractsAndMBAnalysisType obj = new ContractsAndMBAnalysisType();
            //Contract new_c = new Contract();
            //ViewData["ContractItem"] = db.GetContract(id);
            vwCreateContractWithMBAnalysis dataObj = new vwCreateContractWithMBAnalysis();
            var obj = db.GetMBAnalysisListForContract(id).ToList();
            List<int> analysisID = new List<int>();
            int countItems = 0;
            foreach (var item in obj)
            {
                analysisID.Add(item.ContractAndMBAnalysisTypeID);
                countItems++;
            }
            ViewData["ContractMBAnalysis"] = obj;
            dataObj.ContractMBAnalysis = obj;
            ViewData["CountMBAnalysis"] = countItems;
            dataObj.CountMBAnalysis = countItems;
            ViewData["MBContractMBAnalysisIDList"] = analysisID;
            dataObj.MBContractMBAnalysisIDList = analysisID;
            //var MBAnalysisList = db.GetMBAnalysisTypeListActive();
            //var PaymentTypes = db.GetPaymentTypeList();
            //foreach (var item in MBAnalysisList)
            //{
            //    MBAnalysisForContract newItem = new MBAnalysisForContract();
            //    newItem.MBAnalysisID = item.MBAnalysisTypeID;
            //    newItem.MBAnalysisDesc = item.DescriptionRus;
            //    newItem.PaymentTypeID = 2;
            //    newItem.Price = 0;
            //    List<tempPayment> newList = new List<tempPayment>();
            //    foreach (var itm in PaymentTypes)
            //    {
            //        newList.Add(new tempPayment { id = itm.PaymentTypeID, Text = itm.Description });
            //    }
            //    var selectList = new SelectList(newList, "Id", "Text", newItem.PaymentTypeID);
            //    newItem.PaymentTypeSelectList = selectList;
            //    tempList.Add(newItem);
            //}
            //obj.ContractMBAnalysis = tempList;
            var PaymentTypes = db.GetPaymentTypeList();
            List<tempSelectList> newSelectList = new List<tempSelectList>();
            foreach (var item in PaymentTypes)
            {
                newSelectList.Add(new tempSelectList { id = item.PaymentTypeID, Text = item.Description });
            }
            var selectList = new SelectList(newSelectList, "Id", "Text", 2);
            ViewBag.SelectList = selectList;
            ViewData["Contract"] = db.GetContract(id);
            dataObj.ContractItem = db.GetContract(id);
            ViewBag.CountItems = countItems;
            ViewBag.AnalysisID = analysisID;
            return View(dataObj);
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateContractWithMBAnalysis(vwCreateContractWithMBAnalysis model, List<int> IDList, string[] PaymentTypeID, string[] Price)
        {
            for (int i = 0; i < IDList.Count; i++)
            {
                ContractsAndMBAnalysisType obj = new ContractsAndMBAnalysisType();
                obj = db.GetContractsAndMBAnalysisType(IDList[i]);
                db.UpdateMBAnalysisInContract(obj, IDList[i], null, null, int.Parse(PaymentTypeID[i]), decimal.Parse(Price[i]));
            }
            return RedirectToAction("Index", new { message = "Контракт " + "'" + model.ContractItem.Description + "' с регистрационным номером " + model.ContractItem.AccountNumber + " добавлен в систему." });
        }

        [Authorize]
        public ActionResult DeleteContract(int id)
        {
            Contract temp = new Contract();
            temp = db.GetContract(id);
            string name = temp.Description;
            string account = temp.AccountNumber;
            int result = db.DeleteContract(id);
            if (result == 0)
            {
                return RedirectToAction("Index", new { message = "Контракт " + "'" + name + "' с регистрационным номером " + account + " удален из системы." });
            }
            else
            {
                return RedirectToAction("Index", new { message = "Удаление контракта " + "'" + name + "' с регистрационным номером " + account + " невозможно, поскольку по данному контракту зарегистрированы образцы." });
            }

        }



      



    }
}

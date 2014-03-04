using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Data;
using System.Web.Security;
using System.Data.Entity.Infrastructure;
using Diagnostics_FP.Models;
using Diagnostics_FP.ViewModels;


namespace Diagnostics_FP.Models
{
    public class dbActionResult
    {
        public int intResult;
        public OptimisticConcurrencyException exConcur;
        public DataException exData;

    }



    public class DataManager
    {
        private mlabEntities db = new mlabEntities();

        public void Save()
        {
            db.SaveChanges();
        }

        //
        //Работа с пациентами
        //
        #region WorkWithPatients

        public void DeletePatient(int patientId)
        {

            var samples = db.Samples.Where(o => o.SampleID == patientId).ToList();
            foreach (var item in samples)
            {
                var analysis = db.MBAnalysis.Where(o => o.SampleID == item.SampleID).ToList();
                foreach (var a in analysis)
                {
                    db.MBAnalysis.DeleteObject(a);
                    db.SaveChanges();
                }
                db.Samples.DeleteObject(item);
                db.SaveChanges();
                var obj = db.Patients.SingleOrDefault(o => o.PatientID == item.PatientID);
                db.Patients.DeleteObject(obj);
                db.SaveChanges();
            }
        }

        public int AddPatientNewForDiagnosis(Patient obj)
        {
            var some = db.Patients.Max(o => o.PatientID);
            int patientNumber = int.Parse(some.ToString());
            patientNumber++;
            obj.PrintedResults = 0;
            obj.PatientID = patientNumber;
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.CardReadyDate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            string tempSex = "";
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
            obj.Sex = tempSex;
            db.Patients.AddObject(obj);
            db.SaveChanges();
            return obj.PatientID;
        }

        #endregion

        //
        //Работа с образцами
        //
        #region WorkWithSamples



        public IEnumerable<Sample> GetSamplesForContractsPaid()
        {
            var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2)
                .Include(o => o.Patient)
                .Include(o => o.Doctor)
                .Include(o => o.Clinic)
                .Include(o => o.ClinicMaterial)
                .Include(o => o.MBAnalysis)
                .OrderByDescending(o => o.SampleID)
                .ToList();
            return obj;
        }

        public List<Sample> GetSamplesForContractsPaidQueue()
        {
            List<int> arr = new List<int>();
            var tmp = db.Patients.Where(o => o.PrintedResults != 1).ToList();
            foreach (var item in tmp)
            {
                arr.Add(item.PatientID);
            }

            var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 2 && arr.Contains(o.PatientID))
                .Include(o => o.Patient)
                .Include(o => o.Doctor)
                .Include(o => o.Clinic)
                .Include(o => o.ClinicMaterial)
                .Include(o => o.MBAnalysis)
                .OrderByDescending(o => o.SampleID)
                .ToList();

            return obj;
        }

        public IEnumerable<Sample> GetSamplesForContractsFree()
        {
            var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 1)
                .Include(o => o.Patient)
                .Include(o => o.Doctor)
                .Include(o => o.Clinic)
                .Include(o => o.ClinicMaterial)
                .Include(o => o.MBAnalysis)
                .OrderByDescending(o => o.SampleID)
                .ToList();
            return obj;
        }

        public List<Sample> GetSamplesForContractsFreeQueue()
        {
            List<int> arr = new List<int>();
            var tmp = db.Patients.Where(o => o.PrintedResults != 1).ToList();
            foreach (var item in tmp)
            {
                arr.Add(item.PatientID);
            }

            var obj = db.Samples.Where(o => o.SamplePaymentTypeID == 1 && arr.Contains(o.PatientID))
                .Include(o => o.Patient)
                .Include(o => o.Doctor)
                .Include(o => o.Clinic)
                .Include(o => o.ClinicMaterial)
                .Include(o => o.MBAnalysis)
                .OrderByDescending(o => o.SampleID)
                .ToList();

            return obj;
        }

        public int AddSampleNewForDiagnosisFree(Sample obj)
        {
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();

            // Получаем организм по умолчанию
            obj.OrganismTypeID = 1;
            // Получаем центр и проект
            // obj.CenterProjectID = 2;
            // получаем код бесплатного образца
            obj.SamplePaymentTypeID = 1;
            // Получаем код RemoveReason
            obj.RemoveReasonID = 1;
            // Получаем SampleNumber
            var some = db.Samples.Max(o => o.SampleID);
            int sampleNumber = int.Parse(some.ToString());
            sampleNumber++;
            obj.SampleID = sampleNumber;
            obj.SampleNumber = sampleNumber;
            db.Samples.AddObject(obj);
            db.SaveChanges();
            return sampleNumber;
        }

        public int AddSampleNewForDiagnosisPaid(Sample obj)
        {
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();

            // Получаем организм по умолчанию
            obj.OrganismTypeID = 1;
            // Получаем центр и проект
            //  obj.CenterProjectID = 2;
            // получаем код платного образца
            obj.SamplePaymentTypeID = 2;
            // Получаем код RemoveReason
            obj.RemoveReasonID = 1;
            // Получаем SampleNumber
            var some = db.Samples.Max(o => o.SampleID);
            int sampleNumber = int.Parse(some.ToString());
            sampleNumber++;
            obj.SampleID = sampleNumber;
            obj.SampleNumber = sampleNumber;
            db.Samples.AddObject(obj);
            db.SaveChanges();
            return sampleNumber;
        }


        #endregion

        //
        // Работа с анализами MBAnalysis
        //
        #region WorkWithMBAnalysis

        public MBAnalysi GetMBAnalysisForSampleSingle(int mbAnalysisId)
        {
            var obj = db.MBAnalysis
                .Include(o => o.MBStatus)
                .Include(o => o.MBAnalysisType)
                .Include(o => o.MBAnalysisResult)
                .SingleOrDefault(o => o.MBAnalysisID == mbAnalysisId);
            return obj;
        }

        public IEnumerable<MBAnalysi> GetMBAnalysisAndStatusesForSample(int sampleId)
        {
            var obj = db.MBAnalysis
                .Include(o => o.MBStatus)
                .Include(o => o.MBAnalysisType)
                .Include(o => o.MBAnalysisResult)
                .Include(o => o.MBAnalysisType.ContractsAndMBAnalysisTypes)
                .Where(o => o.SampleID == sampleId)
                .ToList();
            return obj;
        }

        public int AddMBAnalysisToSample(int sampleId, int mbAnalysisTypeId)
        {
            MBAnalysi obj = new MBAnalysi();
            obj.MBAnalysisTypeID = mbAnalysisTypeId;
            obj.SampleID = sampleId;
            // добавление дефолта результата
            obj.MBAnalysisResultID = 14;
            // добавление дефолта статуса
            obj.MBStatusID = 2;
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBAnalysis.AddObject(obj);
            db.SaveChanges();
            return obj.MBAnalysisID;
        }

        public dbActionResult EditMBAnalysis(MBAnalysi obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBAnalysis.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBAnalysisID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }

        }
        #endregion

        //
        // Работа  с бактериоскопией
        //
        #region WorkWithBacterioscopy

        public int AddMBAnalysisBacterioscopy(MBAnalysisBacterioscopy obj)
        {
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBAnalysisBacterioscopies.AddObject(obj);
            db.SaveChanges();
            return obj.MBAnalysisBacterioscopyID;
        }

        public dbActionResult EditMBAnalysisBacterioscopy(MBAnalysisBacterioscopy obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBAnalysisBacterioscopies.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBAnalysisBacterioscopyID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }

        #endregion

        //
        //Работа с чуствительностью
        //
        #region WorkWithRoAndCLinicalTest

        public int AddROandClinicalTest(ROandClinicalTest obj)
        {
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ROandClinicalTests.AddObject(obj);
            db.SaveChanges();
            return obj.ROClinicalTestID;
        }

        public dbActionResult EditROandClinicalTest(ROandClinicalTest obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ROandClinicalTests.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ROClinicalTestID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        #endregion

        //
        //Работа с реидентификациями RO
        //
        #region WorkWithRO

        public dbActionResult EditRO(RO obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ROes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ROID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }

        public int AddRO(RO obj)
        {
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ROes.AddObject(obj);
            db.SaveChanges();
            ROandProject RoPr = new ROandProject();
            RoPr.ROID = obj.ROID;
            RoPr.ProjectID = (int)obj.PrimaryProjectID;
            RoPr.DateAdd = DateTime.Now;
            RoPr.DateUpdate = DateTime.Now;
            RoPr.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ROandProjects.AddObject(RoPr);
            db.ObjectStateManager.ChangeObjectState(RoPr, EntityState.Added);
            db.SaveChanges();
            return obj.ROID;
        }

        public vwRO GetROwithFullInfo(int roId)
        {
            vwRO obj = new vwRO();
            obj.ROObj = new RO();
            obj.ROObj = db.ROes.SingleOrDefault(o => o.ROID == roId);
            obj.listROChar = db.ROChars.Include(o => o.ROCharName).Where(o => o.ROID == roId).ToList();
            obj.listROClinicalTest = db.ROandClinicalTests.Include(o => o.AntibioticType).Include(o => o.Method).Where(o => o.ROID == roId).ToList();
            obj.listROComment = db.ROandComments.Include(o => o.Comment).Where(o => o.ROID == roId).ToList();
            obj.listROFenotype = db.ROandFenotypes.Include(o => o.Fenotype).Where(o => o.ROID == roId).ToList();
            obj.listROProject = db.ROandProjects.Include(o => o.Project).Where(o => o.ROID == roId).ToList();
            return obj;
        }

        public List<vwRO> GetROListforSampleAndMBAnalysis(int mbAnalysisId = -1)
        {
            List<vwRO> obj = new List<vwRO>();
            if (mbAnalysisId != -1)
            {
                var roids = db.ROes.Where(o => o.MBAnalysisID == mbAnalysisId).ToList();
                foreach (var item in roids)
                {
                    obj.Add(GetROwithFullInfo(item.ROID));
                }
            }
            
            return obj;
        }

        #endregion


        //
        //Работа с бактериоскопией для анализов MBAnalysisBacterioscopy
        //
        #region WorkWithMBAnalysisBacterioscopy

        public IEnumerable<MBAnalysisBacterioscopy> GetBacterioscopyForMBAnalysis(int mbAnalysisId)
        {
            var obj = db.MBAnalysisBacterioscopies
                .Include(o => o.MBBacterioscopyOrganismType)
                .Where(o => o.MBAnalysisID == mbAnalysisId)
                .ToList();
            return obj;
        }

        #endregion

        //
        //Работа с Клиниками
        //
        #region WorkWithClinic

        public void DeleteClinic(int id)
        {
            var cl = db.Clinics.SingleOrDefault(c => c.ClinicID == id);
            db.Clinics.DeleteObject(cl);
            db.SaveChanges();
        }

        public void DeleteClinicGroup(int id)
        {
            var clg = db.ClinicGroups.SingleOrDefault(c => c.ClinicGroupID == id);
            //var clinicList = db.Clinics.Where(cl => cl.ClinicGroupID == id);
            //if (clinicList != null)
            //{
            //    foreach (var item in clinicList)
            //    {
            //        DeleteClinic((int)item.ClinicID);
            //        //db.SaveChanges();
            //    }
            //}
            db.ClinicGroups.DeleteObject(clg);
            db.SaveChanges();
        }

        public int AddClinic(Clinic obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Clinics.AddObject(obj);
            db.SaveChanges();

            ClinicsAndContract objCaC = new ClinicsAndContract();
            objCaC.ClinicID = obj.ClinicID;
            // Заменить на default
            objCaC.ContractID = 25;
            objCaC.DateUpdate = DateTime.Now;
            objCaC.DateAdd = DateTime.Now;
            objCaC.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ClinicsAndContracts.AddObject(objCaC);
            db.SaveChanges();

            ClinicsAndContract objCaC2 = new ClinicsAndContract();
            objCaC2.ClinicID = obj.ClinicID;
            // Заменить на default
            objCaC2.ContractID = 26;
            objCaC2.DateUpdate = DateTime.Now;
            objCaC2.DateAdd = DateTime.Now;
            objCaC2.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ClinicsAndContracts.AddObject(objCaC2);
            db.SaveChanges();

            return (obj.ClinicID);
        }

        public int AddClinicGroup(ClinicGroup obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ClinicGroups.AddObject(obj);
            db.SaveChanges();
            return (obj.ClinicGroupID);
        }

        public ClinicGroup GetClinicGroup(int id)
        {
            return db.ClinicGroups.SingleOrDefault(o => o.ClinicGroupID == id);
        }

        public IEnumerable<Clinic> GetWardListForClinic(int id)
        {
            return db.Clinics.Where(o => o.ClinicGroupID == id).OrderBy(o => o.Description);
        }

        public IEnumerable<ClinicGroup> GetClinicGroupList()
        {
            return db.ClinicGroups;
        }

        public Clinic GetClinic(int id)
        {
            return db.Clinics.SingleOrDefault(i => i.ClinicID == id);
        }

        public IEnumerable<Clinic> GetClinicListForClinicGroup(int clinicGroupId)
        {
            var obj = db.Clinics.Where(o => o.ClinicGroupID == clinicGroupId).ToList();
            return obj;
        }

        public IEnumerable<Clinic> GetClinicList()
        {
            return db.Clinics.Include(c => c.ClinicGroup).OrderBy(c => c.ClinicGroup.Description);
        }

        public dbActionResult EditClinic(Clinic obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Clinics.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ClinicID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }

        public dbActionResult EditClinicGroup(ClinicGroup obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ClinicGroups.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ClinicGroupID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }

        public void DetachClinic(Clinic obj)
        {
            db.Clinics.Detach(obj);
        }

        public void DetachClinicGroup(ClinicGroup obj)
        {
            db.ClinicGroups.Detach(obj);
        }
        #endregion

        //
        //Работа с настройками по умолчанию
        //
        #region WorkWithDefaultProperties

        public int GetDefaultValueByName(string str)
        {
            DefaultProperty obj = new DefaultProperty();
            obj = db.DefaultProperties.Where(o => o.DefaultPropertyName == str).SingleOrDefault();
            return obj.DefaultPropertyValue;
        }
        #endregion

        //
        //Работы с контрактами
        //
        #region WorkWithContracts;

        public ClinicsAndContract GetClinicContractId(int contractId, int clinicId)
        {
            var obj = db.ClinicsAndContracts.SingleOrDefault(o => o.ContractID == contractId && o.ClinicID == clinicId);
            return obj;
        }

        public IEnumerable<ClinicsAndContract> GetContractsForClinic(int clinicId)
        {
            var obj = db.ClinicsAndContracts.Include(o => o.Contract).Where(o => o.ClinicID == clinicId).Distinct().ToList();
            return obj;
        }

        public List<ContractsAndMBAnalysisType> GetPriceForContractAndMBAnalysis(int contractId, int[] MBAnalysisTypesIds)
        {
            List<ContractsAndMBAnalysisType> obj = new List<ContractsAndMBAnalysisType>();
            foreach (var id in MBAnalysisTypesIds)
            {
                obj.Add(db.ContractsAndMBAnalysisTypes.SingleOrDefault(o => o.ContractID == contractId && o.MBAnalysisTypeID == id));
            }
            return obj;
        }

        public void DetachContract(Contract obj)
        {
            db.Contracts.Detach(obj);
        }

        public dbActionResult EditContract(Contract obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Contracts.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ContractID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }

        }

        public IEnumerable<Contract> GetContractsList()
        {
            return db.Contracts;
        }

        public Contract GetContractFullInfo(int id)
        {
            var obj = db.Contracts.Include(o => o.ClinicsAndContracts).Include(o => o.ContractsAndMBAnalysisTypes).SingleOrDefault(o => o.ContractID == id);
            return obj;
        }

        public IEnumerable<ClinicsAndContract> GetClinicsListForContract(int contractId)
        {
            var obj = db.ClinicsAndContracts.Include(o => o.Clinic).Include(o => o.Clinic.ClinicGroup).Where(o => o.ContractID == contractId).OrderBy(o => o.Clinic.ClinicGroup.Description);
            return obj;
        }

        public IEnumerable<MBAnalysi> GetMBAnalysisListForInterface()
        {
            var obj = db.MBAnalysis
                .Include(o => o.Sample)
                .Include(o => o.Sample.ClinicMaterial)
                .Include(o => o.MBStatus)
                .Include(o => o.MBAnalysisResult)
                .Include(o => o.MBAnalysisType)
                .OrderByDescending(o => o.MBAnalysisID)
                .ToList();
            return obj;
        }

        public IEnumerable<MBAnalysi> GetMBAnalysisListForInterfaceQueue()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(4);
            var obj = db.MBAnalysis
                .Include(o => o.Sample)
                .Include(o => o.Sample.ClinicMaterial)
                .Include(o => o.MBStatus)
                .Include(o => o.MBAnalysisResult)
                .Include(o => o.MBAnalysisType)
                .Where(o => arr.Contains((int)o.MBStatusID))
                .OrderByDescending(o => o.MBAnalysisID)
                .ToList();
            return obj;
        }

        public IEnumerable<ContractsAndMBAnalysisType> GetMBAnalysisListForContract(int contractId)
        {
            return db.ContractsAndMBAnalysisTypes.Include(o => o.MBAnalysisType).Where(o => o.ContractID == contractId).OrderBy(o => o.MBAnalysisType.DescriptionRus);
            //  return db.ContractsAndMBAnalysisTypes.Include(o => o.MBAnalysisType);
        }
        public int AddContract(Contract obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Contracts.AddObject(obj);
            db.SaveChanges();
            int contractID = obj.ContractID;
            var MBAnalysisList = GetMBAnalysisTypeListActive().Select(o => o.MBAnalysisTypeID).Distinct().ToList();
            //List<int> MBAnalysisList = new List<int>();
            //foreach(var item in MBAnalysis)
            //{
            //    int temp = int.Parse(item.ToString());
            //    MBAnalysisList.Add(int.Parse(item.ToString()));
            //}
            foreach (var item in MBAnalysisList)
            {
                AddMBAnalysisToContract(contractID, int.Parse(item.ToString()), 2, 0);
            }
            db.SaveChanges();
            return (obj.ContractID);
        }
        public int DeleteContract(int id)
        {
            int samplesCount = 0;
            samplesCount = db.Samples.Include(o => o.ClinicsAndContract).Where(o => o.ClinicsAndContract.ContractID == id).Count();
            if (samplesCount == 0)
            {
                var obj = db.Contracts.SingleOrDefault(o => o.ContractID == id);
                db.Contracts.DeleteObject(obj);
                db.SaveChanges();
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public dbActionResult EditClinicInContract(ClinicsAndContract obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ClinicsAndContracts.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ClinicContractID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }

        public int AddClinicToContract(int ContractID, int ClinicID)
        {
            var test = db.ClinicsAndContracts.SingleOrDefault(o => o.ClinicID == ClinicID && o.ContractID == ContractID);
            if (test == null)
            {
                ClinicsAndContract obj = new ClinicsAndContract();
                obj.ContractID = ContractID;
                obj.ClinicID = ClinicID;
                obj.DateAdd = DateTime.Now;
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ClinicsAndContracts.AddObject(obj);
                db.SaveChanges();
                return obj.ClinicContractID;
            }
            else
            {
                return -1;
            }
        }
        public void DeleteClinicContract(int ContractID, int ClinicID)
        {
            var obj = db.ClinicsAndContracts.SingleOrDefault(o => o.ClinicID == ClinicID && o.ContractID == ContractID);
            db.ClinicsAndContracts.DeleteObject(obj);
            db.SaveChanges();
        }
        public int AddMBAnalysisToContract(int ContractID, int MBAnalysisID, int PaymentTypeID, decimal Price)
        {
            try
            {
                ContractsAndMBAnalysisType obj = new ContractsAndMBAnalysisType();
                obj.ContractID = ContractID;
                obj.MBAnalysisTypeID = MBAnalysisID;
                obj.PaymentTypeID = PaymentTypeID;
                obj.Price = Price;
                obj.DateAdd = DateTime.Now;
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ContractsAndMBAnalysisTypes.AddObject(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Added);
                db.SaveChanges();
            }
            catch (DataException ex)
            {
                string temp = ex.Message + " Невозможно сохранить изменения. Попробуйте повторить действия. Если проблема повторится, обратитесь к системному администратору.";
            }
            //return obj.ContractAndMBAnalysisTypeID;
            return 0;
        }

        public ContractsAndMBAnalysisType GetContractsAndMBAnalysisType(int id)
        {
            return db.ContractsAndMBAnalysisTypes.SingleOrDefault(o => o.ContractAndMBAnalysisTypeID == id);
        }

        public dbActionResult EditMBAnalysisInContract(ContractsAndMBAnalysisType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ContractsAndMBAnalysisTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ContractAndMBAnalysisTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }


        public void DeleteMBAnalysisInContract(int contractAndMBAnalysisId)
        {
            var obj = db.ContractsAndMBAnalysisTypes.SingleOrDefault(o => o.ContractAndMBAnalysisTypeID == contractAndMBAnalysisId);
            db.ContractsAndMBAnalysisTypes.DeleteObject(obj);
            db.SaveChanges();
        }


        public int UpdateMBAnalysisInContract(ContractsAndMBAnalysisType obj, int itemID, int? contractID, int? mbAnalysisTypeID, int paymentTypeID, decimal price)
        {
            if ((contractID == null) && (mbAnalysisTypeID == null))
            {
                //ContractsAndMBAnalysisType obj = new ContractsAndMBAnalysisType();
                obj = db.ContractsAndMBAnalysisTypes.Where(o => o.ContractAndMBAnalysisTypeID == itemID).SingleOrDefault();
                //obj.ContractID = contractID;
                //obj.MBAnalysisTypeID = mbAnalysisID;
                obj.PaymentTypeID = paymentTypeID;
                obj.Price = price;
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                //db.ContractsAndMBAnalysisTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
            }
            else
            {
                // ContractsAndMBAnalysisType obj = new ContractsAndMBAnalysisType();
                obj = db.ContractsAndMBAnalysisTypes.Where(o => o.ContractAndMBAnalysisTypeID == itemID).SingleOrDefault();
                obj.ContractID = contractID;
                obj.MBAnalysisTypeID = mbAnalysisTypeID;
                obj.PaymentTypeID = paymentTypeID;
                obj.Price = price;
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                //db.ContractsAndMBAnalysisTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
            }
            return 0;
        }

        public Contract GetContract(int id)
        {
            return db.Contracts
                //  .Include(c => c.Acts)
                .Include(c => c.ClinicsAndContracts)
                .Include(c => c.ContractsAndMBAnalysisTypes)
                .Where(c => c.ContractID == id)
                .SingleOrDefault();
        }
        #endregion


        //
        //Работы с LOGIC
        //
        #region WorkWithLogic
        public IEnumerable<Logic> GetLogicList()
        {
            return (db.Logics.ToList());
        }

        public Logic GetLogic(int id)
        {
            return (db.Logics.SingleOrDefault(o => o.LogicID == id));
        }
        #endregion

        //
        // Работа с AdditionalServices
        //
        #region WorkWithAdditionalServices

        public int AddAdditionalServiceToSample(int sampleId, int addServiceId)
        {
            SamplesAndAdditionalService obj = new SamplesAndAdditionalService();
            obj.SampleID = sampleId;
            obj.AdditionalServiceID = addServiceId;
            obj.DateAdd = DateTime.Now;
            obj.DateUpdate = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.SamplesAndAdditionalServices.AddObject(obj);
            db.SaveChanges();
            return obj.SampleAndAdditionalServiceID;
        }

        public void DetachAdditionalService(AdditionalService obj)
        {
            db.AdditionalServices.Detach(obj);
        }

        public int AddAdditionalService(AdditionalService obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.AdditionalServices.AddObject(obj);
            db.SaveChanges();
            return (obj.AdditionalServiceID);
        }

        public dbActionResult EditAdditionalService(AdditionalService obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.AdditionalServices.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.AdditionalServiceID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteAdditionalService(int id)
        {
            var ads = db.AdditionalServices.SingleOrDefault(a => a.AdditionalServiceID == id);
            db.AdditionalServices.DeleteObject(ads);
            db.SaveChanges();
        }
        public AdditionalService GetAdditionalService(int id)
        {
            var ads = db.AdditionalServices.SingleOrDefault(a => a.AdditionalServiceID == id);
            return ads;
        }
        public IEnumerable<vw_AdditionalServiceListWithLogic> GetAdditionalServicesListWithLogic()
        {
            return (db.vw_AdditionalServiceListWithLogic.OrderBy(o => o.DescriptionRus));
        }
        public IEnumerable<AdditionalService> GetAdditionalServiceListActive()
        {
            return db.AdditionalServices.Where(o => o.IsInUse == 1).OrderBy(o => o.Description).ToList();
        }

        public List<AdditionalService> GetPriceForAdditionalServices(int[] AdditionalServicesIds)
        {
            List<AdditionalService> obj = new List<AdditionalService>();
            foreach (var id in AdditionalServicesIds)
            {
                obj.Add(db.AdditionalServices.SingleOrDefault(o => o.AdditionalServiceID == id));
            }
            return obj;
        }
        #endregion

        //
        // Работа с Value
        //
        #region workWithValue
        public void DetachValue(Value obj) { db.Values.Detach(obj); }
        public int AddValue(Value obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Values.AddObject(obj);
            db.SaveChanges();
            return (obj.ValueID);
        }
        public dbActionResult EditValue(Value obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Values.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ValueID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteValue(int id)
        {
            var ab = db.Values.SingleOrDefault(a => a.ValueID == id);
            db.Values.DeleteObject(ab);
            db.SaveChanges();
        }
        public Value GetValue(int id)
        {
            var ab = db.Values.SingleOrDefault(a => a.ValueID == id);
            return ab;
        }
        public IEnumerable<Value> GetValueList()
        { return (db.Values); }
        #endregion

        //
        // Работа с Project
        //
        #region WorkWithProjects
        public void DetachProject(Project obj) { db.Projects.Detach(obj); }
        public int AddProject(Project obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Projects.AddObject(obj);
            db.SaveChanges();
            return (obj.ProjectID);
        }
        public dbActionResult EditProject(Project obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Projects.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ProjectID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteProject(int id)
        {
            var ab = db.Projects.SingleOrDefault(a => a.ProjectID == id);
            db.Projects.DeleteObject(ab);
            db.SaveChanges();
        }
        public Project GetProject(int id)
        {
            var ab = db.Projects.SingleOrDefault(a => a.ProjectID == id);
            return ab;
        }
        public IEnumerable<Project> GetProjectList()
        { return (db.Projects); }
        #endregion
        //
        // Работа с PaymentType
        //
        #region WorkWithPaymentType
        public void DetachPaymentType(PaymentType obj) { db.PaymentTypes.Detach(obj); }
        public int AddPaymentType(PaymentType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.PaymentTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.PaymentTypeID);
        }
        public dbActionResult EditPaymentType(PaymentType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.PaymentTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.PaymentTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeletePaymentType(int id)
        {
            var ab = db.PaymentTypes.SingleOrDefault(a => a.PaymentTypeID == id);
            db.PaymentTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public PaymentType GetPaymentType(int id)
        {
            var ab = db.PaymentTypes.SingleOrDefault(a => a.PaymentTypeID == id);
            return ab;
        }
        public IEnumerable<PaymentType> GetPaymentTypeList()
        { return (db.PaymentTypes); }
        #endregion

        //
        // Работа с MBAnalysisType
        //
        #region WorkWithMBAnalysisType
        public void DetachMBAnalysisType(MBAnalysisType obj) { db.MBAnalysisTypes.Detach(obj); }
        public int AddMBAnalysisType(MBAnalysisType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBAnalysisTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.MBAnalysisTypeID);
        }
        public dbActionResult EditMBAnalysisType(MBAnalysisType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBAnalysisTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBAnalysisTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteMBAnalysisType(int id)
        {
            var ab = db.MBAnalysisTypes.SingleOrDefault(a => a.MBAnalysisTypeID == id);
            db.MBAnalysisTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public MBAnalysisType GetMBAnalysisType(int id)
        {
            var ab = db.MBAnalysisTypes.SingleOrDefault(a => a.MBAnalysisTypeID == id);
            return ab;
        }

        public IEnumerable<vw_MBAnalysisTypeWithLogic> GetMBAnalysisTypeList()
        {
            return (db.vw_MBAnalysisTypeWithLogic.OrderBy(o => o.DescriptionRus));
        }
        public IEnumerable<MBAnalysisType> GetMBAnalysisTypeListActive()
        {
            return (db.MBAnalysisTypes.OrderBy(o => o.DescriptionRus).Where(o => o.IsInUse == 1));
        }
        #endregion
        //
        // Работа с Logic
        //
        #region WorkWithLogic
        public void DetachLogic(Logic obj) { db.Logics.Detach(obj); }
        public int AddLogic(Logic obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Logics.AddObject(obj);
            db.SaveChanges();
            return (obj.LogicID);
        }
        public dbActionResult EditLogic(Logic obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Logics.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.LogicID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteLogic(int id)
        {
            var ab = db.Logics.SingleOrDefault(a => a.LogicID == id);
            db.Logics.DeleteObject(ab);
            db.SaveChanges();
        }
        #endregion
        //
        // Работа с Doctor
        //
        #region WorkWithDoctors

        public IEnumerable<Doctor> GetDoctorsList()
        {
            return db.Doctors.OrderBy(o => o.Lastname).ToList();
        }

        public void DetachDoctor(Doctor obj)
        {
            db.Doctors.Detach(obj);
        }
        public int AddDoctor(Doctor obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Doctors.AddObject(obj);
            db.SaveChanges();
            return (obj.DoctorID);
        }
        public dbActionResult EditDoctor(Doctor obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Doctors.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.DoctorID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteDoctor(int id)
        {
            var ab = db.Doctors.SingleOrDefault(a => a.DoctorID == id);
            db.Doctors.DeleteObject(ab);
            db.SaveChanges();
        }
        public Doctor GetDoctor(int id)
        {
            var ab = db.Doctors.SingleOrDefault(a => a.DoctorID == id);
            return ab;
        }
        public IEnumerable<Doctor> GetDoctorList()
        { return (db.Doctors); }
        #endregion


        //
        // Работа с SamplePaymentType
        //
        #region WorkWithSamplePaymentType
        public void DetachSamplePaymentType(SamplePaymentType obj) { db.SamplePaymentTypes.Detach(obj); }
        public int AddSamplePaymentType(SamplePaymentType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.SamplePaymentTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.SamplePaymentTypeID);
        }
        public dbActionResult EditSamplePaymentType(SamplePaymentType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.SamplePaymentTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.SamplePaymentTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteSamplePaymentType(int id)
        {
            var ab = db.SamplePaymentTypes.SingleOrDefault(a => a.SamplePaymentTypeID == id);
            db.SamplePaymentTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public SamplePaymentType GetSamplePaymentType(int id)
        {
            var ab = db.SamplePaymentTypes.SingleOrDefault(a => a.SamplePaymentTypeID == id);
            return ab;
        }
        public IEnumerable<SamplePaymentType> GetSamplePaymentTypeList()
        { return (db.SamplePaymentTypes); }
        #endregion
        //
        // Работа с ROCharName
        //
        #region
        public void DetachROCharName(ROCharName obj) { db.ROCharNames.Detach(obj); }
        public int AddROCharName(ROCharName obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ROCharNames.AddObject(obj);
            db.SaveChanges();
            return (obj.ROCharNameID);
        }
        public dbActionResult EditROCharName(ROCharName obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ROCharNames.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ROCharNameID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteROCharName(int id)
        {
            var ab = db.ROCharNames.SingleOrDefault(a => a.ROCharNameID == id);
            db.ROCharNames.DeleteObject(ab);
            db.SaveChanges();
        }
        public ROCharName GetROCharName(int id)
        {
            var ab = db.ROCharNames.SingleOrDefault(a => a.ROCharNameID == id);
            return ab;
        }
        public IEnumerable<ROCharName> GetROCharNameList()
        { return (db.ROCharNames); }
        #endregion
        //
        // Работа с RemoveReason
        //
        public void DetachRemoveReason(RemoveReason obj) { db.RemoveReasons.Detach(obj); }
        public int AddRemoveReason(RemoveReason obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.RemoveReasons.AddObject(obj);
            db.SaveChanges();
            return (obj.RemoveReasonID);
        }
        public dbActionResult EditRemoveReason(RemoveReason obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.RemoveReasons.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.RemoveReasonID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteRemoveReason(int id)
        {
            var ab = db.RemoveReasons.SingleOrDefault(a => a.RemoveReasonID == id);
            db.RemoveReasons.DeleteObject(ab);
            db.SaveChanges();
        }
        public RemoveReason GetRemoveReason(int id)
        {
            var ab = db.RemoveReasons.SingleOrDefault(a => a.RemoveReasonID == id);
            return ab;
        }
        public IEnumerable<RemoveReason> GetRemoveReasonList()
        { return (db.RemoveReasons); }

        //
        // Работа с PatientStatusType
        //
        #region WorkWithPatientStatusTypes

        public void DetachPatientStatusType(PatientStatusType obj)
        {
            db.PatientStatusTypes.Detach(obj);
        }
        public int AddPatientStatusType(PatientStatusType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.PatientStatusTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.PatientStatusTypeID);
        }
        public dbActionResult EditPatientStatusType(PatientStatusType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.PatientStatusTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.PatientStatusTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeletePatientStatusType(int id)
        {
            var ab = db.PatientStatusTypes.SingleOrDefault(a => a.PatientStatusTypeID == id);
            db.PatientStatusTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public PatientStatusType GetPatientStatusType(int id)
        {
            var ab = db.PatientStatusTypes.SingleOrDefault(a => a.PatientStatusTypeID == id);
            return ab;
        }
        public IEnumerable<PatientStatusType> GetPatientStatusTypeList()
        {
            return (db.PatientStatusTypes.OrderBy(o => o.DescriptionRus).ToList());
        }

        #endregion


        //
        // Работа с PatientCharName
        //
        //public void DetachPatientCharName(PatientCharName obj) { db.PatientCharNames.Detach(obj); }
        //public int AddPatientCharName(PatientCharName obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.PatientCharNames.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.PatientCharNameID);
        //}
        //public dbActionResult EditPatientCharName(PatientCharName obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.PatientCharNames.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.PatientCharNameID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeletePatientCharName(int id)
        //{
        //    var ab = db.PatientCharNames.SingleOrDefault(a => a.PatientCharNameID == id);
        //    db.PatientCharNames.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public PatientCharName GetPatientCharName(int id)
        //{
        //    var ab = db.PatientCharNames.SingleOrDefault(a => a.PatientCharNameID == id);
        //    return ab;
        //}
        //public IEnumerable<PatientCharName> GetPatientCharNameList()
        //{ return (db.PatientCharNames); }

        //
        // Работа с OrganismType
        //
        public void DetachOrganismType(OrganismType obj) { db.OrganismTypes.Detach(obj); }
        public int AddOrganismType(OrganismType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.OrganismTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.OrganismTypeID);
        }
        public dbActionResult EditOrganismType(OrganismType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.OrganismTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.OrganismTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteOrganismType(int id)
        {
            var ab = db.OrganismTypes.SingleOrDefault(a => a.OrganismTypeID == id);
            db.OrganismTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public OrganismType GetOrganismType(int id)
        {
            var ab = db.OrganismTypes.SingleOrDefault(a => a.OrganismTypeID == id);
            return ab;
        }
        public IEnumerable<OrganismType> GetOrganismTypeList()
        { return (db.OrganismTypes); }

        //
        // Работа с Method
        //
        public void DetachMethod(Method obj) { db.Methods.Detach(obj); }
        public int AddMethod(Method obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Methods.AddObject(obj);
            db.SaveChanges();
            return (obj.MethodID);
        }
        public dbActionResult EditMethod(Method obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Methods.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MethodID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteMethod(int id)
        {
            var ab = db.Methods.SingleOrDefault(a => a.MethodID == id);
            db.Methods.DeleteObject(ab);
            db.SaveChanges();
        }
        public Method GetMethod(int id)
        {
            var ab = db.Methods.SingleOrDefault(a => a.MethodID == id);
            return ab;
        }
        public IEnumerable<Method> GetMethodList()
        { return (db.Methods); }

        //
        // Работа с MedicalUnit
        //
        //public void DetachMedicalUnit(MedicalUnit obj) { db.MedicalUnits.Detach(obj); }
        //public int AddMedicalUnit(MedicalUnit obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.MedicalUnits.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.MedicalUnitID);
        //}
        //public dbActionResult EditMedicalUnit(MedicalUnit obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.MedicalUnits.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.MedicalUnitID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteMedicalUnit(int id)
        //{
        //    var ab = db.MedicalUnits.SingleOrDefault(a => a.MedicalUnitID == id);
        //    db.MedicalUnits.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public MedicalUnit GetMedicalUnit(int id)
        //{
        //    var ab = db.MedicalUnits.SingleOrDefault(a => a.MedicalUnitID == id);
        //    return ab;
        //}
        //public IEnumerable<MedicalUnit> GetMedicalUnitList()
        //{ return (db.MedicalUnits); }

        //
        // Работа с MedicalRoute
        //
        //public void DetachMedicalRoute(MedicalRoute obj) { db.MedicalRoutes.Detach(obj); }
        //public int AddMedicalRoute(MedicalRoute obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.MedicalRoutes.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.MedicalRouteID);
        //}
        //public dbActionResult EditMedicalRoute(MedicalRoute obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.MedicalRoutes.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.MedicalRouteID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteMedicalRoute(int id)
        //{
        //    var ab = db.MedicalRoutes.SingleOrDefault(a => a.MedicalRouteID == id);
        //    db.MedicalRoutes.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public MedicalRoute GetMedicalRoute(int id)
        //{
        //    var ab = db.MedicalRoutes.SingleOrDefault(a => a.MedicalRouteID == id);
        //    return ab;
        //}
        //public IEnumerable<MedicalRoute> GetMedicalRouteList()
        //{ return (db.MedicalRoutes); }

        //
        // Работа с MedicalForm
        //
        //public void DetachMedicalForm(MedicalForm obj) { db.MedicalForms.Detach(obj); }
        //public int AddMedicalForm(MedicalForm obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.MedicalForms.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.MedicalFormID);
        //}
        //public dbActionResult EditMedicalForm(MedicalForm obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.MedicalForms.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.MedicalFormID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteMedicalForm(int id)
        //{
        //    var ab = db.MedicalForms.SingleOrDefault(a => a.MedicalFormID == id);
        //    db.MedicalForms.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public MedicalForm GetMedicalForm(int id)
        //{
        //    var ab = db.MedicalForms.SingleOrDefault(a => a.MedicalFormID == id);
        //    return ab;
        //}
        //public IEnumerable<MedicalForm> GetMedicalFormList()
        //{ return (db.MedicalForms); }

        //
        // Работа с MBStatus
        //
        public void DetachMBStatus(MBStatus obj) { db.MBStatuses.Detach(obj); }
        public int AddMBStatus(MBStatus obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBStatuses.AddObject(obj);
            db.SaveChanges();
            return (obj.MBStatusID);
        }
        public dbActionResult EditMBStatus(MBStatus obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBStatuses.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBStatusID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteMBStatus(int id)
        {
            var ab = db.MBStatuses.SingleOrDefault(a => a.MBStatusID == id);
            db.MBStatuses.DeleteObject(ab);
            db.SaveChanges();
        }
        public MBStatus GetMBStatus(int id)
        {
            var ab = db.MBStatuses.SingleOrDefault(a => a.MBStatusID == id);
            return ab;
        }
        public IEnumerable<MBStatus> GetMBStatusList()
        { return (db.MBStatuses); }

        //
        // Работа с MBBacterioscopyOrganismType
        //
        public void DetachMBBacterioscopyOrganismType(MBBacterioscopyOrganismType obj) { db.MBBacterioscopyOrganismTypes.Detach(obj); }
        public int AddMBBacterioscopyOrganismType(MBBacterioscopyOrganismType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBBacterioscopyOrganismTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.MBBacterioscopyOrganismTypeID);
        }
        public dbActionResult EditMBBacterioscopyOrganismType(MBBacterioscopyOrganismType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBBacterioscopyOrganismTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBBacterioscopyOrganismTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteMBBacterioscopyOrganismType(int id)
        {
            var ab = db.MBBacterioscopyOrganismTypes.SingleOrDefault(a => a.MBBacterioscopyOrganismTypeID == id);
            db.MBBacterioscopyOrganismTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public MBBacterioscopyOrganismType GetMBBacterioscopyOrganismType(int id)
        {
            var ab = db.MBBacterioscopyOrganismTypes.SingleOrDefault(a => a.MBBacterioscopyOrganismTypeID == id);
            return ab;
        }
        public IEnumerable<MBBacterioscopyOrganismType> GetMBBacterioscopyOrganismTypeList()
        { return (db.MBBacterioscopyOrganismTypes); }

        //
        // Работа с MBAnalysisResult
        //
        public void DetachMBAnalysisResult(MBAnalysisResult obj) { db.MBAnalysisResults.Detach(obj); }
        public int AddMBAnalysisResult(MBAnalysisResult obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.MBAnalysisResults.AddObject(obj);
            db.SaveChanges();
            return (obj.MBAnalysisResultID);
        }
        public dbActionResult EditMBAnalysisResult(MBAnalysisResult obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.MBAnalysisResults.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.MBAnalysisResultID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteMBAnalysisResult(int id)
        {
            var ab = db.MBAnalysisResults.SingleOrDefault(a => a.MBAnalysisResultID == id);
            db.MBAnalysisResults.DeleteObject(ab);
            db.SaveChanges();
        }
        public MBAnalysisResult GetMBAnalysisResult(int id)
        {
            var ab = db.MBAnalysisResults.SingleOrDefault(a => a.MBAnalysisResultID == id);
            return ab;
        }
        public IEnumerable<MBAnalysisResult> GetMBAnalysisResultList()
        { return (db.MBAnalysisResults); }

        //
        // Работа с Heavy
        //
        //public void DetachHeavy(Heavy obj) { db.Heavies.Detach(obj); }
        //public int AddHeavy(Heavy obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.Heavies.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.HeavyID);
        //}
        //public dbActionResult EditHeavy(Heavy obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.Heavies.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.HeavyID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteHeavy(int id)
        //{
        //    var ab = db.Heavies.SingleOrDefault(a => a.HeavyID == id);
        //    db.Heavies.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public Heavy GetHeavy(int id)
        //{
        //    var ab = db.Heavies.SingleOrDefault(a => a.HeavyID == id);
        //    return ab;
        //}
        //public IEnumerable<Heavy> GetHeavyList()
        //{ return (db.Heavies); }


        //
        // Работа с Frequency
        //
        //public void DetachFrequency(Frequency obj) { db.Frequencies.Detach(obj); }
        //public int AddFrequency(Frequency obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.Frequencies.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.FrequencyID);
        //}
        //public dbActionResult EditFrequency(Frequency obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.Frequencies.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.FrequencyID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteFrequency(int id)
        //{
        //    var ab = db.Frequencies.SingleOrDefault(a => a.FrequencyID == id);
        //    db.Frequencies.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public Frequency GetFrequency(int id)
        //{
        //    var ab = db.Frequencies.SingleOrDefault(a => a.FrequencyID == id);
        //    return ab;
        //}
        //public IEnumerable<Frequency> GetFrequencyList()
        //{ return (db.Frequencies); }


        //
        // Работа с Fenotype
        //
        public void DetachFenotype(Fenotype obj) { db.Fenotypes.Detach(obj); }
        public int AddFenotype(Fenotype obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Fenotypes.AddObject(obj);
            db.SaveChanges();
            return (obj.FenotypeID);
        }
        public dbActionResult EditFenotype(Fenotype obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Fenotypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.FenotypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteFenotype(int id)
        {
            var ab = db.Fenotypes.SingleOrDefault(a => a.FenotypeID == id);
            db.Fenotypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public Fenotype GetFenotype(int id)
        {
            var ab = db.Fenotypes.SingleOrDefault(a => a.FenotypeID == id);
            return ab;
        }
        public IEnumerable<Fenotype> GetFenotypeList()
        { return (db.Fenotypes); }


        //
        // Работа с Drug
        //
        //public void DetachDrug(Drug obj) { db.Drugs.Detach(obj); }
        //public int AddDrug(Drug obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.Drugs.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.DrugID);
        //}
        //public dbActionResult EditDrug(Drug obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.Drugs.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.DrugID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteDrug(int id)
        //{
        //    var ab = db.Drugs.SingleOrDefault(a => a.DrugID == id);
        //    db.Drugs.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public Drug GetDrug(int id)
        //{
        //    var ab = db.Drugs.SingleOrDefault(a => a.DrugID == id);
        //    return ab;
        //}
        //public IEnumerable<Drug> GetDrugList()
        //{ return (db.Drugs); }

        //
        // Работа с Diagnosis
        //
        //public void DetachDiagnosis(Diagnosis obj) { db.Diagnoses.Detach(obj); }
        //public int AddDiagnosis(Diagnosis obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.Diagnoses.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.DiagnosisID);
        //}
        //public dbActionResult EditDiagnosis(Diagnosis obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.Diagnoses.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.DiagnosisID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteDiagnosis(int id)
        //{
        //    var ab = db.Diagnoses.SingleOrDefault(a => a.DiagnosisID == id);
        //    db.Diagnoses.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public Diagnosis GetDiagnosis(int id)
        //{
        //    var ab = db.Diagnoses.SingleOrDefault(a => a.DiagnosisID == id);
        //    return ab;
        //}
        //public IEnumerable<Diagnosis> GetDiagnosisList()
        //{ return (db.Diagnoses); }


        //
        // Работа с Comment
        //
        public void DetachComment(Comment obj) { db.Comments.Detach(obj); }
        public int AddComment(Comment obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Comments.AddObject(obj);
            db.SaveChanges();
            return (obj.CommentID);
        }
        public dbActionResult EditComment(Comment obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Comments.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.CommentID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteComment(int id)
        {
            var ab = db.Comments.SingleOrDefault(a => a.CommentID == id);
            db.Comments.DeleteObject(ab);
            db.SaveChanges();
        }
        public Comment GetComment(int id)
        {
            var ab = db.Comments.SingleOrDefault(a => a.CommentID == id);
            return ab;
        }
        public IEnumerable<Comment> GetCommentList()
        { return (db.Comments); }


        //
        // Работа с ClinicMaterialGroup
        //
        public void DetachClinicMaterialGroup(ClinicMaterialGroup obj) { db.ClinicMaterialGroups.Detach(obj); }
        public int AddClinicMaterialGroup(ClinicMaterialGroup obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.ClinicMaterialGroups.AddObject(obj);
            db.SaveChanges();
            return (obj.ClinicMaterialGroupID);
        }
        public dbActionResult EditClinicMaterialGroup(ClinicMaterialGroup obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.ClinicMaterialGroups.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.ClinicMaterialGroupID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteClinicMaterialGroup(int id)
        {
            var ab = db.ClinicMaterialGroups.SingleOrDefault(a => a.ClinicMaterialGroupID == id);
            db.ClinicMaterialGroups.DeleteObject(ab);
            db.SaveChanges();
        }
        public ClinicMaterialGroup GetClinicMaterialGroup(int id)
        {
            var ab = db.ClinicMaterialGroups.SingleOrDefault(a => a.ClinicMaterialGroupID == id);
            return ab;
        }
        public IEnumerable<ClinicMaterialGroup> GetClinicMaterialGroupList()
        { return (db.ClinicMaterialGroups); }


        //
        //Работа с Clinic Material
        //
        #region WorkWithClinicMaterial
        public IEnumerable<ClinicMaterial> GetClinicMaterialsList()
        {
            return db.ClinicMaterials.Include(o => o.ClinicMaterialGroup).OrderBy(o => o.Description).ToList();
        }
        #endregion


        //
        // Работа с City
        //
        public void DetachCity(City obj) { db.Cities.Detach(obj); }
        public int AddCity(City obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.Cities.AddObject(obj);
            db.SaveChanges();
            return (obj.CityID);
        }
        public dbActionResult EditCity(City obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.Cities.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.CityID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteCity(int id)
        {
            var ab = db.Cities.SingleOrDefault(a => a.CityID == id);
            db.Cities.DeleteObject(ab);
            db.SaveChanges();
        }
        public City GetCity(int id)
        {
            var ab = db.Cities.SingleOrDefault(a => a.CityID == id);
            return ab;
        }
        public IEnumerable<City> GetCityList()
        { return (db.Cities); }
        //
        // Работа с ABTherapyType
        //
        //public void DetachABTherapyType(ABTherapyType obj) { db.ABTherapyTypes.Detach(obj); }
        //public int AddABTherapyType(ABTherapyType obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.ABTherapyTypes.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.ABTherapyTypeID);
        //}
        //public dbActionResult EditABTherapyType(ABTherapyType obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.ABTherapyTypes.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.ABTherapyTypeID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }
        //}
        //public void DeleteABTherapyType(int id)
        //{
        //    var ab = db.ABTherapyTypes.SingleOrDefault(a => a.ABTherapyTypeID == id);
        //    db.ABTherapyTypes.DeleteObject(ab);
        //    db.SaveChanges();
        //}
        //public ABTherapyType GetABTherapyType(int id)
        //{
        //    var ab = db.ABTherapyTypes.SingleOrDefault(a => a.ABTherapyTypeID == id);
        //    return ab;
        //}
        //public IEnumerable<ABTherapyType> GetABTherapyTypeList()
        //{ return (db.ABTherapyTypes); }

        //
        // Работа с AntibioticType
        //
        public void DetachAntibioticType(AntibioticType obj) { db.AntibioticTypes.Detach(obj); }
        public int AddAntibioticType(AntibioticType obj)
        {
            obj.DateUpdate = DateTime.Now;
            obj.DateAdd = DateTime.Now;
            obj.Suser = System.Web.Security.Membership.GetUser().ToString();
            db.AntibioticTypes.AddObject(obj);
            db.SaveChanges();
            return (obj.AntibioticTypeID);
        }
        public dbActionResult EditAntibioticType(AntibioticType obj)
        {
            try
            {
                obj.DateUpdate = DateTime.Now;
                obj.Suser = System.Web.Security.Membership.GetUser().ToString();
                db.AntibioticTypes.Attach(obj);
                db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
                db.SaveChanges();
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = obj.AntibioticTypeID;
                returnObj.exConcur = null;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (OptimisticConcurrencyException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -1;
                returnObj.exConcur = ex;
                returnObj.exData = null;
                return (returnObj);
            }
            catch (DataException ex)
            {
                dbActionResult returnObj = new dbActionResult();
                returnObj.intResult = -2;
                returnObj.exConcur = null;
                returnObj.exData = ex;
                return (returnObj);
            }
        }
        public void DeleteAntibioticType(int id)
        {
            var ab = db.AntibioticTypes.SingleOrDefault(a => a.AntibioticTypeID == id);
            db.AntibioticTypes.DeleteObject(ab);
            db.SaveChanges();
        }
        public AntibioticType GetAntibioticType(int id)
        {
            var ab = db.AntibioticTypes.SingleOrDefault(a => a.AntibioticTypeID == id);
            return ab;
        }
        public IEnumerable<AntibioticType> GetAntibioticTypeList()
        { return (db.AntibioticTypes); }

        //
        // Работа с DiagnosisType
        //

        //public void DetachDiagnosisType(DiagnosisType obj)
        //{
        //    db.DiagnosisTypes.Detach(obj);
        //}

        //public int AddDiagnosisType(DiagnosisType obj)
        //{
        //    obj.DateUpdate = DateTime.Now;
        //    obj.DateAdd = DateTime.Now;
        //    obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //    db.DiagnosisTypes.AddObject(obj);
        //    db.SaveChanges();
        //    return (obj.DiagnosisTypeID);
        //}

        //public dbActionResult EditDiagnosisType(DiagnosisType obj)
        //{
        //    try
        //    {
        //        obj.DateUpdate = DateTime.Now;
        //        obj.Suser = System.Web.Security.Membership.GetUser().ToString();
        //        db.DiagnosisTypes.Attach(obj);
        //        db.ObjectStateManager.ChangeObjectState(obj, EntityState.Modified);
        //        db.SaveChanges();
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = obj.DiagnosisTypeID;
        //        returnObj.exConcur = null;
        //        returnObj.exData = null;
        //        return (returnObj);

        //    }
        //    catch (OptimisticConcurrencyException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -1;
        //        returnObj.exConcur = ex;
        //        returnObj.exData = null;
        //        return (returnObj);
        //    }
        //    catch (DataException ex)
        //    {
        //        dbActionResult returnObj = new dbActionResult();
        //        returnObj.intResult = -2;
        //        returnObj.exConcur = null;
        //        returnObj.exData = ex;
        //        return (returnObj);
        //    }

        //}

        //public void DeleteDiagnosisType(int id)
        //{
        //    var ab = db.DiagnosisTypes.SingleOrDefault(a => a.DiagnosisTypeID == id);
        //    db.DiagnosisTypes.DeleteObject(ab);
        //    db.SaveChanges();
        //}

        //public DiagnosisType GetDiagnosisType(int id)
        //{
        //    var ab = db.DiagnosisTypes.SingleOrDefault(a => a.DiagnosisTypeID == id);
        //    return ab;
        //}

        //public IEnumerable<DiagnosisType> GetDiagnosisTypeList()
        //{
        //    return (db.DiagnosisTypes);
        //}
    }
}
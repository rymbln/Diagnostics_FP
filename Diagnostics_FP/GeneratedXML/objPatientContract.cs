using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.GeneratedXML
{
    public class TableAnalysisItem
    {
        public string AnalysisPosition { get; set; }
        public string AnalysisCode { get; set; }
        public string AnalysisDescription { get; set; }
        public string AnalysisPrice { get; set; }
    }
    public class TableAddServiceItem
    {
        public string AddServicePosition { get; set; }
        public string AddServiceCode { get; set; }
        public string AddServiceDescription { get; set; }
        public string AddServicePrice { get; set; }
    }
    public class objPatientContract
    {
        public string PatientID { get; set; }
        public string PatientSex { get; set; }
        public string SampleID { get; set; }
        public string Clinic { get; set; }
        public string DoctorFIO { get; set; }
        public string PatientFIO { get; set; }
        public string BirthDate { get; set; }
        public string ClinicMaterial { get; set; }
        public string DateRecieveSample { get; set; }
        public string DateDeliverySample { get; set; }
        public string DateContractStart { get; set; }
        public string DateContractEnd { get; set; }
        public List<TableAnalysisItem> AnalysisList { get; set; }
        public List<TableAddServiceItem> AddServiceList { get; set; }
        public string TotalSum { get; set; }
    }

    public class _itemRO
    {
        public RO itemRO { get; set; }
        public IEnumerable<ROandClinicalTest> listROandClinicalTests { get; set; }
    }

    public class _itemAnalysis
    {
        public MBAnalysi itemMBAnalysis { get; set; }
        public List<_itemRO> listROes { get; set; }
        public IEnumerable<MBAnalysisBacterioscopy> listBacterioscopy { get; set; }
    }

    public class objPatientResults
    {
        public string PatientID { get; set; }
        public string PatientSex { get; set; }
        public string SampleID { get; set; }
        public string Clinic { get; set; }
        public string DoctorFIO { get; set; }
        public string PatientFIO { get; set; }
        public string BirthDate { get; set; }
        public string ClinicMaterial { get; set; }
        public string DateRecieveSample { get; set; }
        public string DateDeliverySample { get; set; }
        public List<_itemAnalysis> listAnalysis { get; set; }
    }
}
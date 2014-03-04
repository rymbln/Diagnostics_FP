using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.ViewModels
{
    public class vwReportIndex
    {
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string[] selectedContract { get; set; }
        public string[] selectedClinic { get; set; }
        public string[] selectedMBAnalysis { get; set; }
        public string[] selectedClinicMaterial { get; set; }
        //public IEnumerable<Contract> itemsContract { get; set; }
        //public IEnumerable<ClinicsAndContract> itemsClinics { get; set; }
        //public IEnumerable<MBAnalysi> itemsMBAnalysis { get; set; }
        //public IEnumerable<ClinicMaterial> itemsClinicMaterials { get; set; }
    }
}
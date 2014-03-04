using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.ViewModels
{
    public class vwCreatePatientFree
    {
        public Patient PatientObj { get; set; }
        public Sample SampleObj { get; set; }
        public IEnumerable<MBAnalysisType> MBAnalysisList { get; set; }
        public IEnumerable<AdditionalService> MBAdditionalServiceList { get; set; }
    }
}
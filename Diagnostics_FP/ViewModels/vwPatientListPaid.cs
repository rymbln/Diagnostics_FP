using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.Web.Mvc;

namespace Diagnostics_FP.ViewModels
{
    public class vwPatientListPaid
    {
        public IEnumerable<Sample> SamplesList { get; set; }
        public IEnumerable<vwMBAnalysisForSampleWithPrice> MBAnalysisListForSample { get; set; }
        public IEnumerable<SamplesAndAdditionalService> AdditionalServicesForSample { get; set; }
        public decimal totalAnalysis { get; set; }
        public decimal totalAddServices { get; set; }
        public decimal totalAll { get; set; }
    }
}
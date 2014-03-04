using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.Web.Mvc;

namespace Diagnostics_FP.ViewModels
{
    public class vwPriceForPatient
    {
        public List<ContractsAndMBAnalysisType> priceAnalysis { get; set; }
        public List<AdditionalService> priceAdditionalServices { get; set; }
        public int totalAnalysis { get; set; }
        public int totalAdditionalServices { get; set; }
        public int totalSum { get; set; }
    }
}
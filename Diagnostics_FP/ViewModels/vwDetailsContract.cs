using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.Web.Mvc;

namespace Diagnostics_FP.ViewModels
{
    public class vwDetailsContract
    {
        public Contract ContractItem { get; set; }
        public IEnumerable<Clinic> ContractClinics { get; set; }
        public IEnumerable<ContractsAndMBAnalysisType> ContractMBAnalysis { get; set; }
    }
}
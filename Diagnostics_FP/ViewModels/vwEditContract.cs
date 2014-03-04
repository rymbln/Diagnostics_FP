using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;


namespace Diagnostics_FP.ViewModels
{
    public class vwEditContract
    {
        public Contract selectedContract { get; set; }
        public ClinicsAndContract ClinicAndContractToEdit { get; set; }
        public ContractsAndMBAnalysisType ContractAndMBAnalysisTypeToEdit { get; set; }
        public IEnumerable<ClinicsAndContract> listClinicForContract { get; set; }
        public IEnumerable<ContractsAndMBAnalysisType> listMBAnalysisForContract { get; set; }
    }
}
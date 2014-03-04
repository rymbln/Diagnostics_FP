using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Diagnostics_FP.Models;
namespace Diagnostics_FP.ViewModels
{
    //public class MBAnalysisForContract
    //{
    //    public int MBAnalysisID { get; set; }
    //    public string MBAnalysisDesc { get; set; }
    //    public int PaymentTypeID { get; set; }
    //    public decimal Price { get; set; }
    //    public SelectList PaymentTypeSelectList { get; set; }
    //}

    public class vwCreateContractWithMBAnalysis
    {
        public int CountMBAnalysis { get; set; }
        public List<int> MBContractMBAnalysisIDList { get; set; }
        public Contract ContractItem { get; set; }
        public IEnumerable<ContractsAndMBAnalysisType> ContractMBAnalysis { get; set; }
    }
}
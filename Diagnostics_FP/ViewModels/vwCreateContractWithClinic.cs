using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;


namespace Diagnostics_FP.ViewModels
{
    public class vwCreateContractWithClinic
    {
        public Contract ContractItem { get; set; }
        public IEnumerable<vw_ClinicList> ContractClinics { get; set; }
    }
}
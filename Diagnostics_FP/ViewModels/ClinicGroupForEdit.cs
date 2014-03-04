using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
namespace Diagnostics_FP.ViewModels
{
    public class ClinicGroupForEdit
    {
        public int ClinicGroupID { get; set; }
        public string Description { get; set; }
        public string INN { get; set; }
        public string WardName { get; set; }
        public decimal DateAdd { get; set; }
        public decimal DateUpdate { get; set; }
        public string Suser { get; set; }
        
    }
}
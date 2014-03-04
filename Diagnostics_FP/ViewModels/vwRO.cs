using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.ViewModels
{
    public class vwRO
    {
        public RO ROObj { get; set; }
        public IEnumerable<ROandClinicalTest> listROClinicalTest { get; set; }
        public IEnumerable<ROandComment> listROComment { get; set; }
        public IEnumerable<ROandFenotype> listROFenotype { get; set; }
        public IEnumerable<ROandProject> listROProject { get; set; }
        public IEnumerable<ROChar> listROChar { get; set; }
    }
}
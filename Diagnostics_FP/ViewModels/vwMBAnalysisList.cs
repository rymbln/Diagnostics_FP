using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.Web.Mvc;

namespace Diagnostics_FP.ViewModels
{
    public class vwMBAnalysisList
    {
        public IEnumerable<MBAnalysi> MBAnalysisList { get; set; }
        public vwMBAnaysisEdit MBanalysisEdit { get; set; }
    }
}
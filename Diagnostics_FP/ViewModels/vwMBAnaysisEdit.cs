using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;


namespace Diagnostics_FP.ViewModels
{
    public class vwMBAnaysisEdit
    {
        public Patient PatientObj { get; set; }
        public Sample SampleObj { get; set; }
        public MBAnalysi MBAnalysisObj { get; set; }
        public IEnumerable<MBAnalysisBacterioscopy> listMBAnalysisBacterioscopy { get; set; }
        public List<vwRO> listRO { get; set; }
    }
}
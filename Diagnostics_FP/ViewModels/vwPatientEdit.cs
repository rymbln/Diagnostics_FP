using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.ViewModels
{
    public class vwPatientEdit
    {
        public int PatientID { get; set; }
        public string Lastname { get; set; }
        public string Initials { get; set; }
        public DateTime Birthdate { get; set; }
        public string Sex { get; set; }
        public int SampleID { get; set; }
        public int ClinicMaterialID { get; set; }
        public int DoctorID { get; set; }
        public DateTime DatetimeDelivery { get; set; }
        public DateTime DatetimeCapture { get; set; }
    }
}
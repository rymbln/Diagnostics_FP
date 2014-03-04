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
    [MetadataType(typeof(ContractClinicMBAnalysisForCreateMetadata))]
    public class ContractClinicMBAnalysisForCreate
    {
        public int ContractID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public decimal DateStart { get; set; }
        public decimal DateEnd { get; set; }
        public int IsAutoGenerate { get; set; }
        public IEnumerable<Clinic> ClinicsForContract { get; set; }
        public IEnumerable<MBAnalysi> MBAnalysisForContract { get; set; }

        public class ContractClinicMBAnalysisForCreateMetadata
        {
            public int ContractID;

            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Display(Name = "Код")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Code { get; set; }

            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Description { get; set; }

            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string AccountNumber { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Обязательное поле")]
            public decimal DateStart { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Обязательное поле")]
            public decimal DateEnd { get; set; }

            [Required(ErrorMessage = "Обязательное поле")]
            public int IsAutoGenerate { get; set; }
        }
    }
}
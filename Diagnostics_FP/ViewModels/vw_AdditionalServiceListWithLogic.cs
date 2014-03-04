using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace Diagnostics_FP.ViewModels
{
    [MetadataType(typeof(vw_AdditionalServiceListWithLogicMetadata))]
    public class vw_AdditionalServiceListWithLogic { }
    public class vw_AdditionalServiceListWithLogicMetadata
    {
        public int AdditionalServiceID;

        [Display(Name = "Описание (Рус.)")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:C} руб.")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Активная услуга")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}
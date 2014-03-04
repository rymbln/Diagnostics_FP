using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diagnostics_FP.Models;

namespace Diagnostics_FP.ViewModels
{
    public class CityCenterIndexData
    {
        public IEnumerable<City > Cities { get; set; }
        public IEnumerable<Center> Centers { get; set; }
    }
}
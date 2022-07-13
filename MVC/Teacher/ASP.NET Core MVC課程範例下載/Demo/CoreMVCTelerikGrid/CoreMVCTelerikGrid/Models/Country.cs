using System;
using System.Collections.Generic;

namespace Kendo.Mvc.Examples.Models
{
    public partial class Country
    {
        public Country()
        {
            DetailProducts = new HashSet<DetailProduct>();
        }

        public int CountryID { get; set; }
        public string CountryNameShort { get; set; }
        public string CountryNameLong { get; set; }

        public virtual ICollection<DetailProduct> DetailProducts { get; set; }
    }
}

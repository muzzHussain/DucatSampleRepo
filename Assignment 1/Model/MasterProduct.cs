using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Model
{
    public class MasterProduct
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public double ListPrice { get; set; }
    }
}
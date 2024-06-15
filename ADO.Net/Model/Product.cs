using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }

    public class Product2
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}

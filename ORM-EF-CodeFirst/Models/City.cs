using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models
{
    public class City
    {
        // Isn't Master 
        // Its Details Of Province(Master of City)
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProvinceProvinceID { get; set; }
        
    }
}

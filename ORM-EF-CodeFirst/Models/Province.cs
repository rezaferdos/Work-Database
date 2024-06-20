using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models
{
    public class Province
    {
        // Master Of City
        // Its Details Of Country(Master of Province)
        public int ProvinceID { get; set; }
        public string Name { get; set; }
        public int CountryCountryID { get; set; }

        // Navigation Property
        public Country Country { get; set; } // Master Of Province
        public Collection<City> Cities { get; set; } // Details Of Province
    }
}

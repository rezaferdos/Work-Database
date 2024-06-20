using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models;

public class Country
{
    // Master Of Province
    // Isn't Details
    public int CountryID { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}

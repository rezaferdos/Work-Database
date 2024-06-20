using ORM_EF_CodeFirst.Models.CodeFirst_Mixed_DatabaseFirst;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }

        public Collection<LastDegree> lastDegree { get; set; }
    }
}

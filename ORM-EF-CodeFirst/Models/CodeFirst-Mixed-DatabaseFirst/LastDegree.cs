using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Models.CodeFirst_Mixed_DatabaseFirst
{
    public class LastDegree
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public int PersonID { get; set; }

        //Navigation Property
        //public Person Person { get; set; } // Bad Way (Extra Column in Grid)
    }
}

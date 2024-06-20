using ORM_EF_CodeFirst.Models;
using ORM_EF_CodeFirst.Models.CodeFirst_Mixed_DatabaseFirst;
using ORM_EF_CodeFirst.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Service
{
    public class LastDegreeService
    {
        public List<LastDegree> GetAll()
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            return ctx.LastDegree.ToList();
        }

        public void Add(LastDegree lastDegree)
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            ctx.LastDegree.Add(lastDegree);
            ctx.SaveChanges();
        }
    }
}

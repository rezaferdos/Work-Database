using ORM_EF_CodeFirst.Models;
using ORM_EF_CodeFirst.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Service
{
    public class PersonService
    {
        public List<Person> GetAll()
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            return ctx.Person.ToList();
        }

        public void Add(Person person)
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            ctx.Person.Add(person);
            ctx.SaveChanges();
        }
    }
}

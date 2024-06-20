using ORM_EF_CodeFirst.Models;
using ORM_EF_CodeFirst.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_CodeFirst.Service
{
    public class UserService
    {
        public void Add(User user)
        {
            using var Context = new Work_Database_ADVCSDbContext();
            Context.Users.Add(user);
            Context.SaveChanges();
        }

        public List<User> GetAll()
        {
            using var Context = new Work_Database_ADVCSDbContext();
            return Context.Users.ToList();
        }

    }
}

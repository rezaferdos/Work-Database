using Business_Service_DB_Code.Model;
using Business_Service_DB_Code.Repository;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Service_DB_Code.Service
{
    public class UserSrvice
    {
        Repository.Repository Repository;
        public UserSrvice()
        {
            Repository = new Repository.Repository();
        }

        public void Add(User user)
        {
            Repository.Add(user);
        }

        public List<User> GetIQueryable(bool? @bool = null, string? name = null)
        {
            var query = Repository.GetIQueryable();
            if (@bool != null)
                query = query.Where(x => x.IsActive == @bool);
            if (name != null)
                query = query.Where(query => query.Name.Contains(name));

            return query.ToList();  // Here Our Query Will Be Executed !!
        }

    }
}

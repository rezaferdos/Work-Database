using Business_Service_DB_Code.Context;
using Business_Service_DB_Code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Service_DB_Code.Repository
{
    public class Repository
    {
        public void Add(User user)
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }
        public void Delete(User user)
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            if(user.IsActive == true) 
                user.IsActive = false;
            ctx.SaveChanges();
        }
        public void Update(User user)
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            var model = ctx.Users.FirstOrDefault(u => u.Id == user.Id);
            if (model != null)
            {
                model.UserName = user.UserName;
                model.Name = user.Name;
                model.Email = user.Email;
                model.Password = user.Password;
                model.IsActive = user.IsActive; 
            }
            ctx.SaveChanges();
        }

        // For Reading
        /* This Way. Select All Record From DB in RAM 
         * Then Enter Condition On it 
         * Low Performance, Not Recomended!
         */
        public List<User> GetList()
        {
            using var ctx = new Work_Database_ADVCSDbContext();
            return ctx.Users.ToList(); // Executed Here! .ToList()/.ToArray()
        }
        /*
         * This Way Is Lazyt Code Lie Lambda Expression
         * Now, Not Execute. When We Call In App, Will be Executed!
         * Always Use  IQueryable  For Filtering On Query!
         */
        public IQueryable<User> GetIQueryable()
        {
            var ctx = new Work_Database_ADVCSDbContext();
            return ctx.Users.AsQueryable(); // Not Executed Here!
        }
    }
}

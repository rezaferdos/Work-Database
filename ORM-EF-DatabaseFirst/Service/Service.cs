using ORM_EF_DatabaseFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_DatabaseFirst.Service
{
    public class Service
    {
        /// ////////////////////////////////////////////////////////////
        // Read All Data
        public List<Products> GetAll()
        {
            using (var ctx = new NorthwindEntities())
            {
                return ctx.Products.ToList();
            }
        }
        /// ////////////////////////////////////////////////////////////
        // Get One Data
        public Products GetByID(int Id)
        {
            using (var ctx = new NorthwindEntities())
            {
                var model = ctx.Products.FirstOrDefault(n => n.ProductID == Id);
                return model;
            }
        }

        /// ////////////////////////////////////////////////////////////
        // Insert Data
        public bool Insert(Products p)
        {
            using (var ctx = new NorthwindEntities())
            {
                ctx.Products.Add(p);
                ctx.SaveChanges();
                return true;
            }
        }

        /// ////////////////////////////////////////////////////////////
        // Remove Data
        public bool Remove(Products p)
        {
            using (var ctx = new NorthwindEntities())
            {
                var model = ctx.Products.FirstOrDefault(n => n.ProductID == p.ProductID);
                ctx.Products.Remove(model);
                ctx.SaveChanges();
                return true;
            }
        }

        /// ////////////////////////////////////////////////////////////
        // Update Data
        public bool Update(Products p)
        {
            using (var ctx = new NorthwindEntities())
            {
                var model = ctx.Products.FirstOrDefault(n => n.ProductID == p.ProductID);
                if (model != null)
                {
                    model.ProductName = p.ProductName;
                    model.UnitPrice = p.UnitPrice;
                    model.Discontinued = p.Discontinued;
                }
                ctx.SaveChanges();
                return true;
            }
        }
    }
}

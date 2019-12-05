using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace ProductServices.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Products> Get()
        {
            using (ProductEntities entities = new ProductEntities())
            {
                return entities.Products.ToList();
            }
        }

        public Products Get(int id)
        {
            using (ProductEntities entities = new ProductEntities())
            {
                return entities.Products.FirstOrDefault(p => p.ID == id);
            }
        }

        //public static byte[] Hash(string id, byte[] salt)
        //{
        //    return Hash(Encoding.UTF8.GetBytes(id), salt);
        //}

        //public static byte[] Hash(byte[] value, byte[] salt)
        //{
        //    byte[] saltedValue = value.Concat(salt).ToArray();
        //    // Alternatively use CopyTo.
        //    //var saltedValue = new byte[value.Length + salt.Length];
        //    //value.CopyTo(saltedValue, 0);
        //    //salt.CopyTo(saltedValue, value.Length);

        //    return new SHA256Managed().ComputeHash(saltedValue);
        //}
    }
}

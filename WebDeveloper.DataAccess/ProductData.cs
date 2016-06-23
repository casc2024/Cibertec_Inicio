using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts() {
            return new List<Product>
            {
                new Product { Id = 1, Description = "Cristal", Price= 3.5, Date = System.DateTime.Now },
                new Product { Id = 1, Description = "Pilsen", Price= 0.0, Date = System.DateTime.Now },
                new Product { Id = 1, Description = "Cuzqueña", Price= 5.0, Date = System.DateTime.Now },
                new Product { Id = 1, Description = "Sublime", Price= 1.1, Date = null},
                new Product { Id = 1, Description = "Coca cola", Price= 2.0, Date = null }
            };
        }
               
    }
}

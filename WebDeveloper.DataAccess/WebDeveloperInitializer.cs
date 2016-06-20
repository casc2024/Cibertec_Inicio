using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    //cada vez que se ejecuta la aplicaion c elimina y se vuelve a crear DropCreateDatabaseAlways
    //cada vez que se actualiza la apliacion en el cliente se vuelve a actualizar DropCreateDatabaseIfModelChanges
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client> {
                new Client { Name = "Juan", LastName = "Perez"},
                new Client { Name = "Jose", LastName = "Perez"},
                new Client { Name = "Luis", LastName = "Perez"},
                new Client { Name = "Jorge", LastName = "Perez"},
                new Client { Name = "Miguel", LastName = "Perez"}
            };
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var employee = new List<Employees>
            {
                 new Employees {LastName="Perez", FirstName="Juan", Address="Lima 1", BirthDate = null},
                 new Employees {LastName="Perez", FirstName="Jose", Address="Lima 2", BirthDate = null},
                 new Employees {LastName="Perez", FirstName="Luis", Address="Lima 3", BirthDate = System.DateTime.Now.Date},
                 new Employees {LastName="Perez", FirstName="Jorge", Address="Lima 4", BirthDate = null},
                 new Employees {LastName="Perez", FirstName="Miguel", Address="Lima 5", BirthDate = null},
            };
            employee.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            var order = new List<Order>
            {
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = System.DateTime.Now.Date, ShippedDate = System.DateTime.Now.Date, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "511100", ShipCountry = "France"  },
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = System.DateTime.Now.Date, ShippedDate = System.DateTime.Now.Date, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "5110", ShipCountry = "France"  },
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = null, ShippedDate = System.DateTime.Now.Date, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "512300", ShipCountry = "France"  },
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = System.DateTime.Now.Date, ShippedDate = null, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "512330", ShipCountry = "France"  },
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = null, ShippedDate = System.DateTime.Now.Date, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "511150", ShipCountry = "France"  },
                new Order { OrderDate = System.DateTime.Now.Date, RequiredDate = System.DateTime.Now.Date, ShippedDate = null, Freight = 32.38, ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipRegion = "RJ", ShipPostalCode = "5111560", ShipCountry = "France"  }
            };
            order.ForEach(x => context.Order.Add(x));
            context.SaveChanges();

            var orderDetails = new List<Order_Details>
            {
                new Order_Details {OrderID = 1, ProductID = 11, UnitPrice = 14.00, Quantity = 15, Discount = 0 },
                new Order_Details {OrderID = 2, ProductID = 12, UnitPrice = 15.00, Quantity = 45, Discount = 0 },
                new Order_Details {OrderID = 2, ProductID = 14, UnitPrice = 19.00, Quantity = 56, Discount = 0 },
                new Order_Details {OrderID = 3, ProductID = 15, UnitPrice = 142.00, Quantity = 57, Discount = 0 },
                new Order_Details {OrderID = 3, ProductID = 16, UnitPrice = 142.00, Quantity = 75, Discount = 0 }
            };
            orderDetails.ForEach(x => context.Order_Details.Add(x));
            context.SaveChanges();

        }

    }
}

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
        }
    }
}

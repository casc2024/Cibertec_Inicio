using System;
using System.Linq;
using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData
    {
        public List<Client> GetFakeData()
        {
            return new List<Client> {
                new Client { Id =  1, Name = "Juan" , LastName = "Perez"},
                new Client { Id =  2, Name = "Raul" , LastName = "Ruidiaz"}
            };
        }

        public List<Client> GetList() {
            //Usamos using para no usar el Dispose
            using (var dbContext = new WebContextDb()) {
                return dbContext.Clients.ToList();
            }
        }
    }
}

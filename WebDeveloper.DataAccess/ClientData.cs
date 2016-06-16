using System;
using System.Linq;
using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData : BaseDataAccess<Client>
    {
        //Comentado la clase anterior
        //public List<Client> GetFakeData()
        //{
        //    return new List<Client> {
        //        new Client { Id =  1, Name = "Juan" , LastName = "Perez"},
        //        new Client { Id =  2, Name = "Raul" , LastName = "Ruidiaz"}
        //    };
        //}

        //public List<Client> GetList() {
        //    //Usamos using para no usar el Dispose
        //    using (var dbContext = new WebContextDb()) {
        //        return dbContext.Clients.ToList();
        //    }
        //}

        //public void Register(Client c) {
        //    using (var dbContext = new WebContextDb())
        //    {
        //        dbContext.Clients.Add(new Client() { Name = c.Name, LastName = c.LastName });
        //        dbContext.SaveChanges();
        //    }
        //}
        
        public Client GetClientById(int id) {
            return GetList().Where(x => x.Id == id).FirstOrDefault();
        }
        
    }
}

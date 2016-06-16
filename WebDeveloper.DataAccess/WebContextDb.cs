using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext //Contexto de datos
    {
        //Cuando llame al client genere la base de datos ya no el local db sino en la instancia de 
        //base de datos local
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            Database.SetInitializer(new WebDeveloperInitializer());
        }       
        //Le indicamos la tabla a la cual se va a relacionar,
        //El dbset te esta indicando que todo lo que venga con la llamada clients la va mapear
        //como aplicamos code first tendra este nombre clients asi q no tenemos problemas
        public DbSet<Client> Clients { get; set; }
        //Con esto deshabilitamos que se modifique el nombre de las tablas ejemplo:
        //Alumno => Alumnoes
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}

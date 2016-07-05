using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            //Implementacion de la inyeccion de dependencias
            var container = new ServiceContainer(); //definimos el contenedor
            //la funcion de un contenedor en una inyeccion de dependencias es 
            //tiene la instancia ya cargada en memoria x eso no se necesita definir un constructor adicional
            //comentamos la siguiente linea
            //container.Register<IDataAccess<Client>, ClientData>(); // con esto se define la inyeccion de dependencias
            //lo que falta es registrar hacia los controladores y que los controladores son del tipo MVC
            //registrar los ensamblados 
            container.RegisterAssembly(Assembly.GetExecutingAssembly()); //registra a los ensamblados por ejecucion
            container.RegisterAssembly("WebDeveloper.*.dll");
            container.RegisterControllers();
            container.EnableMvc(); // solo falta q los controladores llame al IDataAcess
        }
    }
}

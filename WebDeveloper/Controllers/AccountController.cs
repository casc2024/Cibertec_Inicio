using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Models.Account;

namespace WebDeveloper.Controllers
{
    [Authorize] //Paras todos los metodos sean logeados
    public class AccountController : Controller
    {
        public UserManager<WebDeveloperUser> UserManager { get; private set; }

        public AccountController() : this(new UserManager<WebDeveloperUser>(new UserStore<WebDeveloperUser>(new WebUserDbContext())))
        {
        }

        public AccountController(UserManager<WebDeveloperUser> userManager)
        {
            UserManager = userManager;
        }

        [AllowAnonymous]
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register() {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model) //Metodo asincrono
        {
            if (ModelState.IsValid)
            {
                var user = new WebDeveloperUser{ UserName =  model.UserName};
                var result = await UserManager.CreateAsync(user, model.Password); //Tarea Asincrona
                if (result.Succeeded) {
                    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                    var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignIn(new AuthenticationProperties {
                        IsPersistent = false
                    }, identity);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        private IAuthenticationManager AuthenticationManager {
            get { return HttpContext.GetOwinContext().Authentication; }
        }
    }
}
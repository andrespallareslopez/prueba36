using Microsoft.AspNet.Identity.EntityFramework;
using prueba36web.App_Start;
using prueba36web.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba36web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        ///public async System.Threading.Tasks.Task<string> AddUser()
        public string AddUser()
        {
            ApplicationUser user;
            //ApplicationUserStore store = new ApplicationUserStore(new ApplicationDBContext());
            var context = new ApplicationDBContext();
            var store = new UserStore<ApplicationUser>(context);
            ApplicationUserManager userManager = new ApplicationUserManager(store);
            user = new ApplicationUser
            {
                UserName = "AndresTest",
                Email = "Andres_Pallares@Hotmail.com"
            };

            //var result = await userManager.CreateAsync(user);
            //Otra manera de aplicar la asincronia
            
            var tarea = userManager.CreateAsync(user);
            tarea.Wait();
            if (!tarea.Result.Succeeded)
            {
                return tarea.Result.Errors.First();
            }
            /*
            if (!result.Succeeded)
            {
                return result.Errors.First();
            }
            */
            /*
             var result = userManager.Create(user);    
             if (!result.Succeeded)    {        
             return result.Errors.First();    
             }    
             */
            return "User Added";
        }
    }
    
}
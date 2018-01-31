using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hotel.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public Hotel_DB db = new Hotel_DB();
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect(FormsAuthentication.DefaultUrl);

            if(db.Users.Any(u=>u.Email==login.Email && u.Password==login.Password))
            {
                var us = db.Users.Where(u => u.Email == login.Email && u.Password == login.Password).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(us.ID.ToString(), false);

                return RedirectToAction("UserHome", "Home");

            }

            return RedirectToAction("Home","Home");
        }

        public ActionResult Register(Register reg)
        {
            if(reg !=null)
            {
                if(!db.Users.Any(u=>u.Email==reg.Email))
                {
                    User us = new Models.User();
                    us.Email = reg.Email;
                    us.Password = reg.Password;
                    us.Name = reg.Name;
                    us.LastName = reg.LastName;
                    us.Role = Role.User;
                    us.EditeDate = DateTime.Now.ToString();
                    us.RegisterDate= DateTime.Now.ToString();
                    us.PhoneNum ="1";
                    
                    

                    db.Users.Add(us);
                    db.SaveChanges();
                    ViewBag.message = "ثیت نام انجام شد";
                    return RedirectToAction("Home", "Home");
                }
            }

            ViewBag.message = "ثیت نام انجام نشد";
            return RedirectToAction("Home", "Home");
        }
    }
}
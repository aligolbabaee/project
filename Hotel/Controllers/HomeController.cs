using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;


namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        Hotel_DB db = new Hotel_DB();

        // GET: Home
        public ActionResult home()
        {
            return View();
        }
        public ActionResult UserHome()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Action()
        {
            return View();
        }
        public ActionResult AdminEditProfile()
        {

            return View(db.Users.Find(int.Parse(User.Identity.Name)));
        }
       
    }
}
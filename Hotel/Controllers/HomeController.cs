using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
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

       
        public ActionResult Action1()
        {
            return View();
        }
    }
}
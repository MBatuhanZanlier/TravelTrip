using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Controllers;
using TravelTrip.Models.Sınıflar;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        } 
        public ActionResult About()
        {
            return View();
        }
    }
}
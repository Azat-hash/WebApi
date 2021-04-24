using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace web_Приложение.Controllers
{
    public class HomeController : Controller
    {
        AnimalContext context = new AnimalContext();
        public ActionResult Index()
        {
            var animal1 = context.Animals.ToList();
            ViewBag.Title = "Home Page";
            return View(animal1);
        }

        public ActionResult GetInfo(int id)
        {
            var animal = context.Animals.Include(x => x.Pets).Include(c =>c.Wilds).FirstOrDefault(x => x.Id == id);

            if (animal == null)
                return HttpNotFound();

            return View(animal);
        }
    }
}

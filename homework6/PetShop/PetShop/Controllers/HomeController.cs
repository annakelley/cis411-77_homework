using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private PetDBContext db = new PetDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventory()
        {

            return View(db.Pets.ToList());
        }
    }
}
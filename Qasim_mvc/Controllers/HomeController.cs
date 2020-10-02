using Qasim_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Qasim_mvc.Controllers
{
    public class HomeController : Controller
    {
        dbCon emmp = new dbCon();

        // GET: Home
        public ActionResult Index()
        {
            return View(emmp.empp.ToList());
        }
        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp eem)
        {
            emmp.empp.Add(eem);
            emmp.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id) {

            Emp em = emmp.empp.Find(id);

            return View(em);
        }
    }
}
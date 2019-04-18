using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_nav.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Navigant()
        {
            return View();
        }
    }
}
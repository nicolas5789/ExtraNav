using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_nav.Controllers
{
    public class EntrepriseController : Controller
    {
        // GET: Entreprise
        public ActionResult Index()
        {
            ViewModels.NavigantsViewModel vm = new ViewModels.NavigantsViewModel
            {
                listeNavigants = Models.Navigants.listeNavigants()
            };

            ViewData["listeDispos"] = Models.Dispos.listeDispos();
            
            return View(vm);
        }
    }
}
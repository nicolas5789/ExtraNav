using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Projet_nav.Controllers
{
    public class FormulaireController : Controller
    {
        // GET: Formulaire
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InscriptionNav()
        {
            NameValueCollection nvc = Request.Form;
            string nom;
            string prenom;
            int fonction;
            int experience;
            string telephone;
            string email;


            if(!String.IsNullOrEmpty(nvc["nom"]) &&
               !String.IsNullOrEmpty(nvc["prenom"]) &&
               !String.IsNullOrEmpty(nvc["fonction"]) &&
               !String.IsNullOrEmpty(nvc["experience"]) && 
               !String.IsNullOrEmpty(nvc["telephone"]) && 
               !String.IsNullOrEmpty(nvc["email"]))
            {
                nom = nvc["nom"];
                prenom = nvc["prenom"];
                fonction = Convert.ToInt32(nvc["fonction"]);
                experience = Convert.ToInt32(nvc["experience"]);
                telephone = nvc["telephone"];
                email = nvc["email"];
                if (Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) &&
                    Regex.IsMatch(telephone, @"^(0|\+33)[1-9]([-. ]?[0-9]{2}){4}$", RegexOptions.IgnoreCase) &&
                    (fonction > 0 && fonction < 3) && // A modifier si ajout de poste
                    (experience > 0 && experience < 41)  
                    )
                {
                    ViewData["messageInscriptionNav"] = "Votre compte a bien été créé";
                    //ajout envoi vers fonction pour ajout dans bdd
                    //ajout return vers la bonne page
                }
                else
                {
                    ViewData["messageInscriptionNav"] = "Veuillez respecter les formats demandés";
                    //ajout renvoi vers le formulaire
                }
            } else
            {
                ViewData["messageInscriptionNav"] = "Tous les champs doivent être complétés";
                //ajout renvoi vers le formulaire
            }
            
            return View("~/Views/Inscription/Navigant.cshtml");   
        }
    }
}
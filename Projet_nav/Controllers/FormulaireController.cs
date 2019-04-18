﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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
            int telephone;
            string email;


            if(!String.IsNullOrEmpty(nvc["nom"]) &&
               !String.IsNullOrEmpty(nvc["prenom"]) &&
               !String.IsNullOrEmpty(nvc["fonction"]) &&
               !String.IsNullOrEmpty(nvc["experience"]) && 
               !String.IsNullOrEmpty(nvc["telephone"]) && 
               !String.IsNullOrEmpty(nvc["email"]))
            {
                ViewData["messageInscriptionNav"] = "Votre compte a bien été créé";

                nom = nvc["nom"];
                prenom = nvc["prenom"];
                fonction = Convert.ToInt32(nvc["fonction"]);
                experience = Convert.ToInt32(nvc["experience"]);
                telephone = Convert.ToInt32(nvc["telephone"]);
                email = nvc["email"];

            } else
            {
                ViewData["messageInscriptionNav"] = "Tous les champs doivent être complétés";
            }



            

            //ajouter controle des valeurs et renvoi si incorrect
            
            return View("~/Views/Inscription/Navigant.cshtml");   
        }
    }
}
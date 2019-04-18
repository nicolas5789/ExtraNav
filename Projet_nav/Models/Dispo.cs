﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_nav.Models
{
    public class Dispo
    {
        public int Id { get; set; }
        public int IdNavigant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeDebut { get; set; }
        public DateTime DateDeFin { get; set; }
        public int Note { get; set; }
        public string Fonction { get; set; }
    }
}
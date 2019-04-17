using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_nav.Models
{
    public class Navigant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdFonction { get; set; }
        public int Experience { get; set; }
        public DateTime DateDeCreation { get; set; }
        public DateTime DateDeModification { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Note { get; set; }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_nav.Models
{
    public class Navigants : Database
    {
        public static List<Navigant> listeNavigants() //READ
        {
            List<Navigant> listeNavigants = new List<Navigant>();

            MySqlCommand cmd = BddConnect().CreateCommand();
            cmd.CommandText = "select * from navigants";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listeNavigants.Add(new Navigant {
                    Id = Convert.ToInt32(reader.GetString("id")),
                    Nom = reader.GetString("nom"),
                    Prenom = reader.GetString("prenom"),
                    IdFonction = Convert.ToInt32(reader.GetString("idFonction")),
                    DateDeCreation = Convert.ToDateTime(reader.GetString("dateDeCreation")),
                    DateDeModification = Convert.ToDateTime(reader.GetString("dateDeModification")),
                    Experience = Convert.ToInt32(reader.GetString("experience")),
                    Telephone = reader.GetString("telephone"),
                    Email = reader.GetString("email"),
                    Note = Convert.ToInt32(reader.GetString("note")) 
                });
            }
            return listeNavigants;
        }
    }
}
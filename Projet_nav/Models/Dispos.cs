using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_nav.Models
{
    public class Dispos : Database
    {
        public static List<Dispo> listeDispos() //READ
        {
            List<Dispo> listeDispos = new List<Dispo>();

            MySqlCommand cmd = BddConnect().CreateCommand();
            cmd.CommandText = "SELECT * from dispos inner join navigants, fonctions where dispos.idNavigant = navigants.id and navigants.idFonction = fonctions.id";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listeDispos.Add(new Dispo
                {
                    Id = Convert.ToInt32(reader.GetString("id")),
                    IdNavigant = Convert.ToInt32(reader.GetString("idNavigant")),
                    DateDeDebut = Convert.ToDateTime(reader.GetString("dateDeDebut")),
                    DateDeFin = Convert.ToDateTime(reader.GetString("dateDeFin")),
                    Fonction = reader.GetString("fonction"),
                    Nom = reader.GetString("nom"),
                    Prenom = reader.GetString("prenom"),
                    Note = Convert.ToInt32(reader.GetString("note")) 
                });
            }
            return listeDispos;
        }
    }
}


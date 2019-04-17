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
            cmd.CommandText = "select * from dispos";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listeDispos.Add(new Dispo
                {
                    Id = Convert.ToInt32(reader.GetString("id")),
                    IdNavigant = Convert.ToInt32(reader.GetString("idNavigant")),
                    DateDeDebut = Convert.ToDateTime(reader.GetString("dateDeDebut")),
                    DateDeFin = Convert.ToDateTime(reader.GetString("dateDeFin"))
                });
            }
            return listeDispos;
        }
    }
}
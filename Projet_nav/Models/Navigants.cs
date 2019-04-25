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

        public static void ajoutNavigant(Navigant cible) //CREATE
        {
            //créer hashage du mdp et sécurisation injection html et sql

            MySqlCommand cmd = BddConnect().CreateCommand();
            cmd.CommandText = "INSERT INTO navigants(nom, prenom, idFonction, experience, dateDeCreation, dateDeModification, telephone, email, motDePasse, note) VALUES(@nom, @prenom, @idFonction, @experience, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, @telephone, @email, @motDePasse, @note )";
            cmd.Parameters.AddWithValue("@nom", cible.Nom);
            cmd.Parameters.AddWithValue("@prenom", cible.Prenom);
            cmd.Parameters.AddWithValue("@idFonction", cible.IdFonction);
            cmd.Parameters.AddWithValue("@experience", cible.Experience);
            cmd.Parameters.AddWithValue("@telephone", cible.Telephone);
            cmd.Parameters.AddWithValue("@email", cible.Email);
            cmd.Parameters.AddWithValue("@motDePasse", cible.MotDePasse);
            cmd.Parameters.AddWithValue("@note", "0");
            cmd.ExecuteNonQuery();
        }

        public static bool existeNavigant(Navigant cible)
        {
            List<Navigant> listing = listeNavigants();
            bool existe = false;

            for(int i = 0; i < listing.Count; i++)
            {
                if (listing[i].Email.ToLower().Contains(cible.Email.ToLower()))
                {
                    existe = true;
                }
                else if (listing[i].Telephone.Contains(cible.Telephone))
                {
                    existe = true;
                } 
            }
            return existe;
        }
        
    }
}
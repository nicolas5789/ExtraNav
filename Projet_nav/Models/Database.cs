using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_nav.Models
{
    public class Database
    {
        protected static MySqlConnection BddConnect()
        {
            string myConnectionString = "Database=nav;Data Source=localhost;Username=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            try
            {
                //Connexion à la base de donnée réussie
                myConnection.Open();
            }
            catch (Exception e)
            {
                //Connexion à la base de donnée échouée
            }
            return myConnection;
        }
    }
}
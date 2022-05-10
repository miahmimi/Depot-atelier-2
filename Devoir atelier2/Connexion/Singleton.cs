using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir_atelier2.Connexion
{
    class Singleton
    {
        MySqlConnection connexion = new MySqlConnection("Server=localhost;Database=atelier2;Uid=newutilisateur;Pwd=NjJqebA1B53LMGQ8");

        public static MySqlConnection
               GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
            //Coder les methodes : *****
        }
}

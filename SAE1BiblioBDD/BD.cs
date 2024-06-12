using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration.Assemblies;
using System;
using System.Data;


namespace SAE1BiblioBDD
{
    public static class BD
    {
         private static MySqlConnection conn;
         public static void Connexion(MySqlConnection conn)
            {
            
                string serveur = "10.1.139.235";
                string login = "f1";
                string mdp = "mdp";
                string bd = "basef1";

                string chaineConnexion = $"serveur={serveur};uid={login};pwd={mdp};database = {bd}";
                conn = new MySqlConnection(chaineConnexion);

                conn.Open();
             }
            public static void InitConnection(IDbConnection connection)
            {
                conn = (MySqlConnection)connection;
            }

            public static bool CloseConnection()
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Erreur de connexion : " + e.Message);
                }

                return false;
            }
            public static void NouvellePartie()
            {

            }
        }
}


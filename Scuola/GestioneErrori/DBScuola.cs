using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneErrori
{
    internal class DBScuola : IManagerScuola
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Scuola;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Studente> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Studente> studenteList = new List<Studente>();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from Agente";

                    SqlDataReader reader = command.ExecuteReader();

                    List<Studente> studenti = new List<Studente>();

                    while (reader.Read())
                    {
                        var idStudente = (int)reader["CodiceStudente"];
                        var nome = (string)reader["Nome"];
                        var cognome = (string)reader["Cognome"];


                        Studente s = new Studente(idStudente, nome, cognome);
                        studenti.Add(s);
                    }
                    return studenti;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Problemi di connessione al Database. Dettagli: {ex.Message}");
                    return studenteList;
                }
                finally
                {
                    connection.Close();

                }

            }
        }
    }
}

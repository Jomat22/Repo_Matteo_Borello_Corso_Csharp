using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connString = "server=localhost;database=rubrica_db;user=root;password=mysql123";

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Rubrica");
            Console.WriteLine("1. Inserisci un nuovo contatto");
            Console.WriteLine("2. Visualizza tutti i contatti");
            Console.WriteLine("3. Elimina un contatto per nome");
            Console.WriteLine("0. Esci");
            Console.Write("\nScegli un'opzione: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1": InserisciContatto(); break;
                case "2": VisualizzaContatti(); break;
                case "3": EliminaContatto(); break;
                case "0": return;
                default: Console.WriteLine("Opzione non valida!"); break;
            }
            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.ReadKey();
        }
    }

    static void InserisciContatto()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefono: ");
        string tel = Console.ReadLine();

        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO contatti (nome, telefono) VALUES (@nome, @tel)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@tel", tel);
                
                cmd.ExecuteNonQuery(); 
                Console.WriteLine("Contatto salvato con successo!");
            }
            catch (Exception ex) { Console.WriteLine("Errore: " + ex.Message); }
        }
    }

    static void VisualizzaContatti()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM contatti";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader()) 
                {
                    Console.WriteLine("\nLISTA CONTATTI:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"- ID: {reader["id"]} | Nome: {reader["nome"]} | Tel: {reader["telefono"]}");
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Errore: " + ex.Message); }
        }
    }

    static void EliminaContatto()
    {
        Console.Write("Inserisci il nome del contatto da eliminare: ");
        string nome = Console.ReadLine();

        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM contatti WHERE nome = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);

                int eli = cmd.ExecuteNonQuery();
                if (eli > 0) Console.WriteLine("Contatto eliminato!");
                else Console.WriteLine("Nessun contatto trovato con questo nome.");
            }
            catch (Exception ex) { Console.WriteLine("Errore: " + ex.Message); }
        }
    }
}
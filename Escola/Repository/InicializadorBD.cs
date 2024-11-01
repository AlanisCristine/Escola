using Dapper;
using System.Data.SQLite;

namespace Escola.Repository;

public class InicializadorBD
{
    private const string ConnectionString = "Data Source = Escola.db";

    public static void Inicializar()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Alunos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Idade INTEGER NOT NULL,
                 Peso REAL NOT NULL,
                 Altura REAL NOT NULL
                );";

            connection.Execute(commandoSQL);
        }
    }
}
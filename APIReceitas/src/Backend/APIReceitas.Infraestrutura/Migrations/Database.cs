using Dapper;
using MySqlConnector;

namespace APIReceitas.Infraestrutura.Migrations;

public static class Database
{
    public static void CriarDatabase(string conexaoBancoDeDados, string nomeDatabase )
    {
        using var minhaConexao = new MySqlConnection(conexaoBancoDeDados);

        var parametros = new DynamicParameters();

        parametros.Add("nome", nomeDatabase);

        var registro = minhaConexao.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @nome", parametros);

        if (!registro.Any())
        {
            minhaConexao.Execute($"CREATE DATABASE {nomeDatabase}");
        }
        


    }
}

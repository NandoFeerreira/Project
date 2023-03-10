using Microsoft.Extensions.Configuration;

namespace Domain.Extension;

public static  class RepositorioExtension
{
    public static string GetConextionString(this IConfiguration configurationManaeger)
    {
        var conexao = configurationManaeger.GetConnectionString("Conexao");

        return conexao;
    }

    public static string GetNomeDatabase(this IConfiguration configurationManaeger)
    {
        var conexao = configurationManaeger.GetConnectionString("NomeDatabase");

        return conexao;
    }

}

using Domain.Extension;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace APIReceitas.Infraestrutura
{
    public static class Bootstrapper
    {
        public static void AddRepositorio(this IServiceCollection services, IConfiguration configurationManager)
        {
            AddFluentMigratior(services, configurationManager);
        }
         
        private static void AddFluentMigratior(IServiceCollection services, IConfiguration configurationManager)
        {
            
            services.AddFluentMigratorCore().ConfigureRunner(c =>
            c.AddMySql5()
            .WithGlobalConnectionString(configurationManager.GetConexaoCompleta())
            .ScanIn(Assembly.Load("APIReceitas.Infraestrutura")).For.All());
        }


    }
}

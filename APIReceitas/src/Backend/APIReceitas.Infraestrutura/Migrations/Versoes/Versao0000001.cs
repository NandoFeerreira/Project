using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIReceitas.Infraestrutura.Migrations.Versoes
{
    [Migration((long)NumeroVersoes.CriarTabelaUsuario, "Criação de Tabela Usuário")]
    public class Versao0000001 : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            var tabela = VersaoBase.InserirColunasPadrao(Create.Table("Usuario"));

            tabela
                .WithColumn("Nome").AsString(100).NotNullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("senha").AsString(2000).NotNullable()
                .WithColumn("Telefone").AsString(14).NotNullable();
        }
    }
}


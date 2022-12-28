using FluentMigrator.Builders.Create.Table;

namespace APIReceitas.Infraestrutura.Migrations;

public static class VersaoBase 
{
    public static ICreateTableColumnOptionOrWithColumnSyntax InserirColunasPadrao(ICreateTableWithColumnOrSchemaOrDescriptionSyntax tabela)
    {
        return tabela
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("DataCriacao").AsDateTime().NotNullable()
                .WithColumn("Ativo").AsBoolean().NotNullable();
    }
}

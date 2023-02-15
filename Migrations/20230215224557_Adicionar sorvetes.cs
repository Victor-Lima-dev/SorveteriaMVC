using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sorveteriaMVC.Migrations
{
    /// <inheritdoc />
    public partial class Adicionarsorvetes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //adicionar sorvete na tabela
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Morango', 'Sorvete', 'Morango', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Chocolate', 'Sorvete', 'Chocolate', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Creme', 'Sorvete', 'Creme', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Abacaxi', 'Sorvete', 'Abacaxi', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Coco', 'Sorvete', 'Coco', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Maracujá', 'Sorvete', 'Maracujá', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Banana', 'Sorvete', 'Banana', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Laranja', 'Sorvete', 'Laranja', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Limão', 'Sorvete', 'Limão', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Açaí', 'Sorvete', 'Açaí', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Uva', 'Sorvete', 'Uva', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Pêssego', 'Sorvete', 'Pêssego', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Framboesa', 'Sorvete', 'Framboesa', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Kiwi', 'Sorvete', 'Kiwi', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Manga', 'Sorvete', 'Manga', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Tangerina', 'Sorvete', 'Tangerina', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Ameixa', 'Sorvete', 'Ameixa', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Cereja', 'Sorvete', 'Cereja', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Goiaba', 'Sorvete', 'Goiaba', 5.00, 10)");
            migrationBuilder.Sql("INSERT INTO Sorvetes (Nome, Tipo, Sabor, Preco, Quantidade) VALUES ('Sorvete de Maçã', 'Sorvete', 'Maçã', 5.00, 10)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //remover
            migrationBuilder.Sql("DELETE FROM Sorvetes WHERE Nome IN ('Sorvete de Morango', 'Sorvete de Chocolate', 'Sorvete de Creme', 'Sorvete de Abacaxi', 'Sorvete de Coco', 'Sorvete de Maracujá', 'Sorvete de Banana', 'Sorvete de Laranja', 'Sorvete de Limão', 'Sorvete de Açaí', 'Sorvete de Uva', 'Sorvete de Pêssego', 'Sorvete de Framboesa', 'Sorvete de Kiwi', 'Sorvete de Manga', 'Sorvete de Tangerina', 'Sorvete de Ameixa', 'Sorvete de Cereja', 'Sorvete de Goiaba', 'Sorvete de Maçã')");
        }
    }
}

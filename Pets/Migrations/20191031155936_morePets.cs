using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class morePets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[] { 18, 8, "Mancoon, taby mix", "Snuggly pur-box", "Catnip, food and cuddles", "Male", "Other pets that steal the love he should be getting", "Meeko", "Hailey", "wwwroot/uploads/meeko-hailey.jpg", "Cat" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[] { 19, 7, " Golden Retriever", "Such a love, very demanding with being loved on", "She loves to bring you gifts when you get home like my socks", "Female", "Other dogs..", "Ladybird", "Hailey", "wwwroot/uploads/ladybird-hailey.jpg", "Dog" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[] { 20, 1, "Great Pyrenees", "Huge white fully baby", "Loves the snow and to be outside with other animals", "Female", "Water", "Ebba Beryl", "Hailey", "wwwroot/uploads/ebba-beryl-hailey.jpg", "Dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 20);
        }
    }
}

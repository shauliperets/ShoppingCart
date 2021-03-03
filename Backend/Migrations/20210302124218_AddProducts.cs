using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (1, 'Nikon', 470, '/Images/1.png')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

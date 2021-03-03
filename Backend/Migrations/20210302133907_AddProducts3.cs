using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddProducts3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (2, 'Lenovo Thinkpad w510', 3470, '/Images/2.png')");
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (3, 'Lenovo Thinkpad X1', 5470, '/Images/3.png')");
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (4, 'Lenovo Thinkpad T470', 3210, '/Images/4.png')");
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (5, 'Lenovo Thinkpad T320', 2470, '/Images/5.png')");
            migrationBuilder.Sql("INSERT INTO Products (ID, Name, Price, Image) VALUES (6, 'Lenovo Thinkpad P1', 9470, '/Images/6.png')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

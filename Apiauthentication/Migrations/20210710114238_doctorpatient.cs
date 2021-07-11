using Microsoft.EntityFrameworkCore.Migrations;

namespace Apiauthentication.Migrations
{
    public partial class doctorpatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DUUId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMDCRegNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PUUId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyNumber = table.Column<int>(type: "int", nullable: false),
                    LocationCoordinates = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}

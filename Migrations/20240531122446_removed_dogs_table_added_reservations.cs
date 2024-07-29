using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dogoapi.Migrations
{
    /// <inheritdoc />
    public partial class removeddogstableaddedreservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnersLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogBreed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogBreed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnersLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });
        }
    }
}

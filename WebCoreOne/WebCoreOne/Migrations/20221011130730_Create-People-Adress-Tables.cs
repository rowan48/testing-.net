using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebCoreOne.Migrations
{
    public partial class CreatePeopleAdressTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "peoples",
                columns: table => new
                {
                    PeopleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_peoples", x => x.PeopleId);
                });

            migrationBuilder.CreateTable(
                name: "PeopleAdressss",
                columns: table => new
                {
                    PersonAdresssId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    PeopleId = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleAdressss", x => x.PersonAdresssId);
                    table.ForeignKey(
                        name: "FK_PeopleAdressss_peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "peoples",
                        principalColumn: "PeopleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleAdressss_PeopleId",
                table: "PeopleAdressss",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleAdressss");

            migrationBuilder.DropTable(
                name: "peoples");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace CourseFantastic.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DoB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Identity = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Person");
        }
    }
}

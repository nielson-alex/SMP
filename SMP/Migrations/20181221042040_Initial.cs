using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMP.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BishopricMember",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Calling = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BishopricMember", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnID);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bishopric = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    OpeningSong = table.Column<string>(nullable: true),
                    SacramentSong = table.Column<string>(nullable: true),
                    Speaker1 = table.Column<string>(nullable: true),
                    Subject1 = table.Column<string>(nullable: true),
                    Speaker2 = table.Column<string>(nullable: true),
                    Subject2 = table.Column<string>(nullable: true),
                    IntermediateSong = table.Column<string>(nullable: true),
                    Speaker3 = table.Column<string>(nullable: true),
                    Subject3 = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WardMember",
                columns: table => new
                {
                    WardMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Calling = table.Column<string>(nullable: true),
                    IsBishopricMember = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WardMember", x => x.WardMemberID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BishopricMember");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "WardMember");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Football_Players_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Founded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfTitles = table.Column<int>(type: "int", nullable: false),
                    SquadSize = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfAdd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Founded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfTitles = table.Column<int>(type: "int", nullable: false),
                    SquadSize = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfAdd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pictrue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    NationalTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfAdd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_NationalTeams_NationalTeamId",
                        column: x => x.NationalTeamId,
                        principalTable: "NationalTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubPlayers",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClubId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfContractEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubPlayers", x => new { x.ClubId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_ClubPlayers_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Country", "DateOfAdd", "DateOfUpdate", "Founded", "IsDeleted", "Logo", "Name", "NumberOfTitles", "SquadSize", "Stadium" },
                values: new object[] { new Guid("00000000-0000-0000-abcd-000000000000"), "Egypt", new DateTimeOffset(new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTime(1907, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Al_Ahly_SC_logo.png/130px-Al_Ahly_SC_logo.png", "Al Ahly Sporting Club", 107, 30, "El-Ahly Stadium" });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Country", "DateOfAdd", "DateOfUpdate", "Founded", "IsDeleted", "Logo", "Name", "NumberOfTitles", "SquadSize", "Stadium" },
                values: new object[] { new Guid("00000000-0000-0000-abcd-000000000001"), "England", new DateTimeOffset(new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTime(1886, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Arsenal_FC.svg/160px-Arsenal_FC.svg.png", "The Arsenal Football Club", 55, 30, "Emirates Stadium" });

            migrationBuilder.InsertData(
                table: "NationalTeams",
                columns: new[] { "Id", "DateOfAdd", "DateOfUpdate", "Founded", "IsDeleted", "Logo", "Name", "NumberOfTitles", "SquadSize", "Stadium" },
                values: new object[] { new Guid("00000000-0000-0000-abcd-000000000002"), new DateTimeOffset(new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTime(1900, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Arsenal_FC.svg/160px-Arsenal_FC.svg.png", "Egyption national team", 9, 30, "Cairo Stadium" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Assists", "Citizenship", "DateOfAdd", "DateOfBirth", "DateOfUpdate", "FirstName", "Goals", "Height", "IsDeleted", "LastName", "NationalTeamId", "Number", "Pictrue", "Position" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), 120, "Egyption", new DateTimeOffset(new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(1977, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Muhammad", 140, "185 cm", null, "Abou trika", new Guid("00000000-0000-0000-abcd-000000000002"), "22", "https://3.bp.blogspot.com/-ktPnakamJXA/WIAHa0EvRaI/AAAAAAAAjmM/06w8jIgFP4UcmJQMfSOvYD10bHVNMUdoACLcB/s1600/Abou%2BTrika.jpg", "AMF" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Assists", "Citizenship", "DateOfAdd", "DateOfBirth", "DateOfUpdate", "FirstName", "Goals", "Height", "IsDeleted", "LastName", "NationalTeamId", "Number", "Pictrue", "Position" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), 100, "Egyption", new DateTimeOffset(new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(1976, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Muhammad", 80, "175 cm", null, "barakat", new Guid("00000000-0000-0000-abcd-000000000002"), "11", "https://cdn.arageek.com/magazine/2017/09/Mohamed-Barakat-1.jpg", "RW" });

            migrationBuilder.CreateIndex(
                name: "IX_ClubPlayers_PlayerId",
                table: "ClubPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_NationalTeamId",
                table: "Players",
                column: "NationalTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubPlayers");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "NationalTeams");
        }
    }
}

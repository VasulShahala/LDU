using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppLvivDebateUnion.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClubGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rolles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rolles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubBornDate = table.Column<DateTime>(nullable: false),
                    ClubGroupId = table.Column<int>(nullable: true),
                    Information = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_ClubGroups_ClubGroupId",
                        column: x => x.ClubGroupId,
                        principalTable: "ClubGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Debaters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blocked = table.Column<bool>(nullable: false),
                    BornDate = table.Column<DateTime>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    ClubId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FbLink = table.Column<string>(nullable: true),
                    Inform = table.Column<string>(nullable: true),
                    NameIP = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    RolleId = table.Column<int>(nullable: false),
                    VkLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debaters_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debaters_Rolles_RolleId",
                        column: x => x.RolleId,
                        principalTable: "Rolles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionDebaters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DebaterId = table.Column<int>(nullable: false),
                    GameCount = table.Column<int>(nullable: false),
                    RiatStars = table.Column<double>(nullable: false),
                    TotalStars = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionDebaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionDebaters_Debaters_DebaterId",
                        column: x => x.DebaterId,
                        principalTable: "Debaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Judes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DebaterId = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Judes_Debaters_DebaterId",
                        column: x => x.DebaterId,
                        principalTable: "Debaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolleGames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DebaterId = table.Column<int>(nullable: false),
                    GameRolle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolleGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolleGames_Debaters_DebaterId",
                        column: x => x.DebaterId,
                        principalTable: "Debaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raunds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubId = table.Column<int>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    GameDate = table.Column<DateTime>(nullable: false),
                    JugeId = table.Column<int>(nullable: false),
                    RaundNumb = table.Column<string>(nullable: true),
                    Resolution = table.Column<string>(nullable: true),
                    StatLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raunds_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Raunds_Judes_JugeId",
                        column: x => x.JugeId,
                        principalTable: "Judes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebaterGameRaunds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DebaterId = table.Column<int>(nullable: false),
                    RaundId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebaterGameRaunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebaterGameRaunds_Debaters_DebaterId",
                        column: x => x.DebaterId,
                        principalTable: "Debaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebaterGameRaunds_Raunds_RaundId",
                        column: x => x.RaundId,
                        principalTable: "Raunds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionDebaters_DebaterId",
                table: "ActionDebaters",
                column: "DebaterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_ClubGroupId",
                table: "Clubs",
                column: "ClubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Debaters_ClubId",
                table: "Debaters",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Debaters_RolleId",
                table: "Debaters",
                column: "RolleId");

            migrationBuilder.CreateIndex(
                name: "IX_DebaterGameRaunds_DebaterId",
                table: "DebaterGameRaunds",
                column: "DebaterId");

            migrationBuilder.CreateIndex(
                name: "IX_DebaterGameRaunds_RaundId",
                table: "DebaterGameRaunds",
                column: "RaundId");

            migrationBuilder.CreateIndex(
                name: "IX_Judes_DebaterId",
                table: "Judes",
                column: "DebaterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raunds_ClubId",
                table: "Raunds",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Raunds_JugeId",
                table: "Raunds",
                column: "JugeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolleGames_DebaterId",
                table: "RolleGames",
                column: "DebaterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionDebaters");

            migrationBuilder.DropTable(
                name: "DebaterGameRaunds");

            migrationBuilder.DropTable(
                name: "RolleGames");

            migrationBuilder.DropTable(
                name: "Raunds");

            migrationBuilder.DropTable(
                name: "Judes");

            migrationBuilder.DropTable(
                name: "Debaters");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Rolles");

            migrationBuilder.DropTable(
                name: "ClubGroups");
        }
    }
}

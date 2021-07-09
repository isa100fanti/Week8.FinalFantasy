using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalFantasy.RepositoryEF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Giocatori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giocatori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LifePoints = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoint = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponID = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    TypeM = table.Column<int>(type: "int", nullable: false),
                    TypeH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Heroes_Giocatori_UserId",
                        column: x => x.UserId,
                        principalTable: "Giocatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Most",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LifePoints = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponID = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    TypeM = table.Column<int>(type: "int", nullable: false),
                    TypeH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Most", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Most_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Most",
                columns: new[] { "ID", "Level", "LifePoints", "Name", "TypeH", "TypeM", "WeaponID" },
                values: new object[] { 1, 1, 0, "Lucifer XX", 0, 1, 0 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "ID", "Class", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, "Hero", 8, "Ascia" },
                    { 2, "Hero", 5, "Spada" },
                    { 3, "Hero", 10, "Mazza" },
                    { 4, "Monster", 7, "Arco" },
                    { 5, "Monster", 5, "Clava" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_WeaponID",
                table: "Heroes",
                column: "WeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_Most_WeaponID",
                table: "Most",
                column: "WeaponID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Most");

            migrationBuilder.DropTable(
                name: "Giocatori");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}

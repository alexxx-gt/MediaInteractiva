using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IsMIEmployee = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IsMIEmployee", "LastName" },
                values: new object[,]
                {
                    { 1, "Aaron", true, "Hamilton" },
                    { 28, "Lola", true, "Moran" },
                    { 27, "Ariel", true, "Ramos" },
                    { 26, "Kensley", true, "Cobb" },
                    { 25, "Lacey", true, "Cooke" },
                    { 24, "Libby", true, "Rogers" },
                    { 23, "Charlotte", true, "Gordon" },
                    { 22, "Abbie", true, "Hudson" },
                    { 21, "Jodie", true, "Evans" },
                    { 20, "Maddox", true, "Chen" },
                    { 19, "Emery", true, "Gillespie" },
                    { 18, "Kendall", true, "Lindsay" },
                    { 17, "Sincere", true, "Terrell" },
                    { 16, "Zechariah", true, "Rosario" },
                    { 15, "Stanley", true, "Jackson" },
                    { 14, "Lewis", true, "Davies" },
                    { 13, "Sean", true, "Harris" },
                    { 12, "Kayden", true, "Kennedy" },
                    { 11, "Stanley", true, "Wright" },
                    { 10, "Korbin", true, "Harding" },
                    { 9, "Riley", true, "Daugherty" },
                    { 8, "Austin", true, "Atkinson" },
                    { 7, "Alexis", true, "Larsen" },
                    { 6, "Kenneth", true, "Morton" },
                    { 5, "Theo", true, "Lawson" },
                    { 4, "Theo", true, "Davidson" },
                    { 3, "Edward", true, "Reid" },
                    { 2, "Jayden", true, "Anderson" },
                    { 29, "Carissa", true, "Contreras" },
                    { 30, "Phoenix", true, "Valenzuela" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Name", "OwnerId", "Type" },
                values: new object[,]
                {
                    { 1, "ABBEY", 1, 1 },
                    { 49, "KEESHA", 20, 7 },
                    { 19, "CHARISMA", 20, 5 },
                    { 48, "KC", 19, 6 },
                    { 18, "CHAOS", 19, 4 },
                    { 47, "KAYLA", 18, 5 },
                    { 17, "CHANEL", 18, 3 },
                    { 20, "FLAKE", 21, 6 },
                    { 46, "KATZ", 17, 4 },
                    { 45, "KATO", 16, 3 },
                    { 15, "CHAMP", 16, 1 },
                    { 44, "KATIE", 15, 2 },
                    { 14, "CHAMBERLAIN", 15, 7 },
                    { 43, "KASEY", 14, 1 },
                    { 13, "CHAD", 14, 6 },
                    { 16, "CHANCE", 17, 2 },
                    { 72, "RILEY", 13, 2 },
                    { 50, "KELLIE", 21, 1 },
                    { 51, "KELLY", 22, 2 },
                    { 58, "RANGER", 29, 2 },
                    { 28, "GORDON", 29, 7 },
                    { 57, "RAMBO", 28, 1 },
                    { 27, "GOOSE", 28, 6 },
                    { 56, "RAMBLER", 27, 7 },
                    { 26, "FLOYD", 27, 5 },
                    { 21, "FLAKEY", 22, 7 },
                    { 55, "RALPHIE", 26, 6 },
                    { 54, "KERRY", 25, 5 },
                    { 24, "FLOPSY", 25, 3 },
                    { 53, "KENYA", 24, 4 },
                    { 23, "FLINT", 24, 2 },
                    { 52, "KELSEY", 23, 3 },
                    { 22, "FLASH", 23, 1 },
                    { 25, "FLOWER", 26, 4 },
                    { 42, "KARMA", 13, 7 },
                    { 12, "CHA CHA", 13, 5 },
                    { 71, "RIGGS", 12, 1 },
                    { 5, "BEANIE", 6, 5 },
                    { 64, "REILLY", 5, 1 },
                    { 34, "JUDY", 5, 6 },
                    { 4, "BEAMER", 5, 4 },
                    { 63, "REGGIE", 4, 7 },
                    { 33, "GRETA", 4, 5 },
                    { 35, "JULIUS", 6, 7 },
                    { 62, "RED", 3, 6 },
                    { 3, "ABEL", 3, 3 },
                    { 61, "REBEL", 2, 5 },
                    { 31, "GRADY", 2, 3 },
                    { 2, "ABBY", 2, 2 },
                    { 60, "RAVEN", 1, 4 },
                    { 30, "GRACIE", 1, 2 },
                    { 32, "GREENIE", 3, 4 },
                    { 65, "REMY", 6, 2 },
                    { 6, "BEANS", 7, 6 },
                    { 36, "JUNE", 7, 1 },
                    { 41, "KANE", 12, 6 },
                    { 11, "CASSIS", 12, 4 },
                    { 70, "RICO", 11, 7 },
                    { 40, "KALLIE", 11, 5 },
                    { 10, "BEAUX", 11, 3 },
                    { 69, "RICKY", 10, 6 },
                    { 39, "KALI", 10, 4 },
                    { 9, "BEAUTY", 10, 2 },
                    { 68, "RHETT", 9, 5 },
                    { 38, "JUSTICE", 9, 3 },
                    { 8, "BEAU", 9, 1 },
                    { 67, "REXY", 8, 4 },
                    { 37, "JUNIOR", 8, 2 },
                    { 7, "BEAR", 8, 7 },
                    { 66, "REX", 7, 3 },
                    { 29, "GRACE", 30, 1 },
                    { 59, "RASCAL", 30, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

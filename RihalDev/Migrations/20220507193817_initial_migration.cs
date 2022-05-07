using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalDev.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    count = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    birthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    class_id = table.Column<int>(type: "INTEGER", nullable: false),
                    country_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_class_id",
                        column: x => x.class_id,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Countries_country_id",
                        column: x => x.country_id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "93751-8039" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 9, "10741-3032" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 8, "94731-5056" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 7, "89904" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 6, "52795" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 10, "93792" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 4, "02105" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 3, "14087-5715" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 2, "92946-9740" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "name" },
                values: new object[] { 5, "18890-2730" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 9, 0, "West Gene" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 1, 0, "Bradleyhaven" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 2, 0, "Port Georgechester" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 3, 0, "Clevelandstad" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 4, 0, "North Sister" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 5, 0, "Dorrishaven" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 6, 0, "Colleenburgh" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 7, 0, "Destinfurt" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 8, 0, "South Clarabellechester" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "count", "name" },
                values: new object[] { 10, 0, "North Nickside" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 2, new DateTime(1917, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 5, 2, "Reggie Kovacek IV" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 20, new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), 6, 9, "Conor Bernier" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 11, new DateTime(1973, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), 8, 7, "Mrs. Bret Jacky Nitzsche" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 8, new DateTime(1936, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc), 4, 7, "Marguerite Kshlerin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 4, new DateTime(1905, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), 10, 7, "Lawrence Crona" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 9, new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), 6, 6, "Prof. Devonte Koch PhD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 1, new DateTime(1985, 4, 29, 0, 0, 0, 0, DateTimeKind.Utc), 2, 6, "Kay McGlynn DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 18, new DateTime(1906, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), 3, 5, "Ms. Sienna Jude Haag MD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 14, new DateTime(2013, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4, 5, "Kaelyn Raynor" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 5, new DateTime(1956, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc), 2, 5, "Carlos Pagac V" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 17, new DateTime(1959, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), 4, 4, "Mrs. Eulah Donnelly DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 16, new DateTime(1988, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1, 4, "Mrs. Bethel Lilly Douglas" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 6, new DateTime(1961, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), 1, 4, "Prof. Etha Gutkowski III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 13, new DateTime(1938, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc), 4, 3, "Miss Lowell O'Keefe V" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 12, new DateTime(1994, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), 4, 3, "Dr. Duane Hoppe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 7, new DateTime(1951, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc), 8, 3, "Dejah Hilll" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 3, new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 7, 3, "Sarai Ondricka" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 15, new DateTime(1900, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), 9, 2, "Raquel Von" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 10, new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), 5, 10, "Freddy O'Kon" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "birthDate", "class_id", "country_id", "name" },
                values: new object[] { 19, new DateTime(1954, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 7, 10, "Janie Auer" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_class_id",
                table: "Students",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_country_id",
                table: "Students",
                column: "country_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

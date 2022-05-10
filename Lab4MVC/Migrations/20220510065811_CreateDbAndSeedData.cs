using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4MVC.Migrations
{
    public partial class CreateDbAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "LinkTables",
                columns: table => new
                {
                    LinkTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Returned = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkTables", x => x.LinkTableId);
                    table.ForeignKey(
                        name: "FK_LinkTables_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkTables_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookName", "ISBN" },
                values: new object[,]
                {
                    { 1, "J.R.R.Tolkien", "Hobbit", "9789113084893" },
                    { 2, "J.R.R.Tolkien", "The Two Towers", "9780261102361" },
                    { 3, "J.R.R.Tolkien", "The Return of the King", "9780261102378" },
                    { 4, "J.R.R.Tolkien", "The Fall of Gondolin", "9780008302757" },
                    { 5, "J.K.Rowling", "Harry Potter and the Philosopher's Stone", "9781408855652" },
                    { 6, "J.K.Rowling", "Harry Potter and the Chamber of Secrets", "9781408855669" },
                    { 7, "J.K.Rowling", "Harry Potter and the Chamber of Secrets", "9781408855669" },
                    { 8, "J. K. Rowling", "Harry Potter and the Half-Blood Prince", "9781408855706" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Gender", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Male", "Tony Stark", "0701231233" },
                    { 2, "Female", "Natalia Romanoff", "0703332222" },
                    { 3, "Male", "Bruce Banner", "07044422233" },
                    { 4, "Female", "Wanda Maximoff", "0701113332" },
                    { 5, "Male", "Thor Odinson", "0701337133" }
                });

            migrationBuilder.InsertData(
                table: "LinkTables",
                columns: new[] { "LinkTableId", "BookId", "CustomerId", "EndDate", "Returned", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8, 1, new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, 2, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 6, 2, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 3, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, 3, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 4, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 5, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 5, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkTables_BookId",
                table: "LinkTables",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkTables_CustomerId",
                table: "LinkTables",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkTables");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

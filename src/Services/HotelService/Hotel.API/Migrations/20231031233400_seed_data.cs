using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.API.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorizedFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelUUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InfoType = table.Column<int>(type: "int", nullable: false),
                    InfoContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.UUID);
                    table.ForeignKey(
                        name: "FK_ContactInfos_Hotels_HotelUUID",
                        column: x => x.HotelUUID,
                        principalTable: "Hotels",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("db944df0-2aff-4b98-8a1f-f2c9f5266c05"), "Ali", "Demir", "Sun Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("e411a7cc-1974-4540-a06e-58dbbc7b0ab4"), "Ahmet", "Duman", "Royal Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("fdc54ea8-9bae-465b-9ab5-e48e55fd9567"), "Veli", "Öz", "Sun Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "UUID", "CreatedBy", "CreatedDate", "HotelUUID", "InfoContent", "InfoType", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("41a6ed10-888b-4a82-b5f4-60f6475b0a9c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fdc54ea8-9bae-465b-9ab5-e48e55fd9567"), "moonhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b5d54b7-f691-43d7-86f7-cf9cea2168c6"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db944df0-2aff-4b98-8a1f-f2c9f5266c05"), "Antalya", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaab279f-cc5b-4d65-9da2-a8af1318d72c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fdc54ea8-9bae-465b-9ab5-e48e55fd9567"), "0 533 5558899", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3d3a8f0-a1ae-4dae-8d9f-40d784bd3701"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db944df0-2aff-4b98-8a1f-f2c9f5266c05"), "0 555 4443322", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1aa7e25-3381-4bdd-bda7-c84e296b5483"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db944df0-2aff-4b98-8a1f-f2c9f5266c05"), "sunhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da9f948b-e7d3-410a-871c-177a05952335"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e411a7cc-1974-4540-a06e-58dbbc7b0ab4"), "royalhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_HotelUUID",
                table: "ContactInfos",
                column: "HotelUUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}

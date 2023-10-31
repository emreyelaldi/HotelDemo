using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.API.Migrations
{
    public partial class seed_data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("41a6ed10-888b-4a82-b5f4-60f6475b0a9c"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("4b5d54b7-f691-43d7-86f7-cf9cea2168c6"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("aaab279f-cc5b-4d65-9da2-a8af1318d72c"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("b3d3a8f0-a1ae-4dae-8d9f-40d784bd3701"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("c1aa7e25-3381-4bdd-bda7-c84e296b5483"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("da9f948b-e7d3-410a-871c-177a05952335"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("db944df0-2aff-4b98-8a1f-f2c9f5266c05"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("e411a7cc-1974-4540-a06e-58dbbc7b0ab4"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("fdc54ea8-9bae-465b-9ab5-e48e55fd9567"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"), "Ali", "Demir", "Sun Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("7b861151-195e-4311-86ed-a26063da8a1d"), "Veli", "Öz", "Moon Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("d13bd12b-2811-4275-b64f-b5057e2e8ec5"), "Ahmet", "Duman", "Royal Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "UUID", "CreatedBy", "CreatedDate", "HotelUUID", "InfoContent", "InfoType", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("23d2018f-c15d-4705-afe3-c6700f29ef74"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b861151-195e-4311-86ed-a26063da8a1d"), "0 533 5558899", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c3c98b0-6990-429c-8800-cd375360e41d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"), "sunhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44c1d8c0-784f-4794-bcb9-d51ee2682450"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b861151-195e-4311-86ed-a26063da8a1d"), "moonhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d1b0a32-f4fb-4d09-8085-94174cf89759"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"), "Antalya", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6ab6f21-32d7-4b09-8006-c6b984944f83"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"), "0 555 4443322", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8670bb2-daa2-47fa-89e6-f2a674c779c6"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d13bd12b-2811-4275-b64f-b5057e2e8ec5"), "royalhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("23d2018f-c15d-4705-afe3-c6700f29ef74"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("3c3c98b0-6990-429c-8800-cd375360e41d"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("44c1d8c0-784f-4794-bcb9-d51ee2682450"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("6d1b0a32-f4fb-4d09-8085-94174cf89759"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("d6ab6f21-32d7-4b09-8006-c6b984944f83"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("f8670bb2-daa2-47fa-89e6-f2a674c779c6"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("7b861151-195e-4311-86ed-a26063da8a1d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("d13bd12b-2811-4275-b64f-b5057e2e8ec5"));

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.API.Migrations
{
    public partial class seed_data3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"), "Ali", "Demir", "Sun Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("8523d2e4-4f63-4524-953e-df3bb596681b"), "Ahmet", "Duman", "Royal Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "UUID", "AuthorizedFirstName", "AuthorizedLastName", "CompanyTitle", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"), "Veli", "Öz", "Moon Hotel", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "UUID", "CreatedBy", "CreatedDate", "HotelUUID", "InfoContent", "InfoType", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("7daf6641-6296-48b9-9ed7-64f2201cd8dd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"), "Antalya", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8791bc29-3131-49fe-8402-def6f70d6073"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"), "moonhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94ac9ba1-95b3-4897-a916-8fe73f62338f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"), "0 555 4443322", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3d0cb13-7431-4d83-af33-29d47e2ecc9a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8523d2e4-4f63-4524-953e-df3bb596681b"), "royalhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6b00304-0f18-425f-954d-3b49b038d1a5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"), "0 533 5558899", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec68cf17-c934-4197-a0b5-4cc570f0dbbd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"), "sunhotel@mail.com", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("7daf6641-6296-48b9-9ed7-64f2201cd8dd"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("8791bc29-3131-49fe-8402-def6f70d6073"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("94ac9ba1-95b3-4897-a916-8fe73f62338f"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("b3d0cb13-7431-4d83-af33-29d47e2ecc9a"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("b6b00304-0f18-425f-954d-3b49b038d1a5"));

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "UUID",
                keyValue: new Guid("ec68cf17-c934-4197-a0b5-4cc570f0dbbd"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("8523d2e4-4f63-4524-953e-df3bb596681b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "UUID",
                keyValue: new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"));

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
    }
}

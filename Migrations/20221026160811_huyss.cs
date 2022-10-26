using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class huyss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "44a18c23-4068-4e0b-b13e-a0eaa6490c57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "b30a0bf3-4e9f-43cc-88c7-8abe6d12eb0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "5cad8bc6-91c2-42c0-84b2-cdb4ddb1428f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06514766-bb8a-4e46-8b11-4bd5df62a8d1", "AQAAAAEAACcQAAAAEEq68QQzRF5HEYI4JH5OPY4bYtIw04juGr/M2WvQEgEeXAVbeHtUZohDRHVEvNmSjQ==", "98ac64ba-2f43-42af-b40e-cd43866255c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1456999a-283b-4291-9158-63f02bd28c14", "AQAAAAEAACcQAAAAEAe5CDUZ51pcgDSi1lX54znG2MknyyAHmqQM8eSj02cQ+vSpvca5qmi6x5CnlS+PUQ==", "981700f8-9b59-4b76-8bf7-2b3c03c77f97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12326cce-aa00-4c2a-a612-f044e582b1d6", "AQAAAAEAACcQAAAAEE7PKe3ehOQtBjnD3Qzw7zmhGystyIjIbU6e5yu/Ssk0V0WOfmNTuSR5QADidvmJTQ==", "f59bbc04-8dab-45fd-9b50-f9eb42f1d79b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe54649-22bb-48e4-b0da-70f1a589f42b", "AQAAAAEAACcQAAAAEPQq3+2HOemRCxGw4n1RUhDJZH5L30Y6m9Pk1j33CdgPazQyRyMSMvs8yqN+tGAYkA==", "130c168b-8e0d-4a12-94f5-2ee234c7c9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "431f4d23-3343-4f1b-9904-ce40584b10da", "AQAAAAEAACcQAAAAEEEThw91+0v1AGGChp1yTJckOT54H38Ge6oDI1k5JmPSa4WqbDepSQw87N1qE1WaOg==", "1548746e-e71d-449a-b6d5-86655bf4606e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b38c413-d287-417e-b176-32228c42c710", "AQAAAAEAACcQAAAAELcfnh9JfcwbSvTfIYUgm9ghzKs14ep5ZH+Bp1CTAEnNaYSj3cM2eUXMactqSTCd+g==", "96345e13-5fd8-4d14-b187-34c69e3e1745" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "8a5f2b08-ae25-459f-b1fa-9d0545a5cbe5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "4efd18c7-d600-4def-a8ca-b1357ac3d589");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "10da1bc5-f4c7-431c-8724-60507af5ed38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f28457-8b1d-4632-9c16-f2f3a669ab36", "AQAAAAEAACcQAAAAEJdp10Oa6EYDEy44TB93qukSk1VBax53aDNNBfLYJP9F7FCc1S6ry0fRt6lwDlSXrA==", "384f759e-65fa-4b53-89e6-251b83a37de5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "774b492e-cc85-4dc0-99c9-fb44483d378d", "AQAAAAEAACcQAAAAEO3WQJfD5k6L/A5ZY16ggIaSK9GCz5BeuB55t0TKxnv1pYpUfhG8/UbAunuux4FdMw==", "69ddc1d3-03c0-40f8-b095-0e1afc741085" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a34db5b-13b3-4c53-9d03-8c7b8b0b2e73", "AQAAAAEAACcQAAAAEAR8OY4lYF32Fh3152RMOjoZYJvTn3PPw2BR+ff0tNQLTIvLu7fhkSV2kM5O/LFT1A==", "7137fd5f-a8f7-43bd-9431-734528eb0b44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e5ce43-ce0a-4a6e-87f8-7e28533d4b5d", "AQAAAAEAACcQAAAAEGngEoN1lErEmJ4i/CqpBClYhmUMEZ5UZVnKRmKAiGSKt14q7W/M/JDObiqQZOkqkw==", "b78b478e-a004-43f8-98ac-84cee8c65316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae22da0c-4a78-489f-a69b-a818068face7", "AQAAAAEAACcQAAAAEDtUyjz3novLDtkBDfzUv/fQhBqjy5cNHmKdUF+7jTkS9w+CGb2IPGuE+X6/4WlsLw==", "61ce0fdd-0f1c-4264-92b1-95d8071db16b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8de1de0-b644-4095-b14f-d65e606ae720", "AQAAAAEAACcQAAAAEB6YOJaZyCMXl304JvcsrY0Ome9QYDHB3uz1MD2iU/f/Px3B7EskYxMt6+bwxBEB7A==", "799fa4da-52bc-45e7-8d1c-13e02210ef2c" });
        }
    }
}

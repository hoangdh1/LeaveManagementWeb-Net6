using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "6ff0804d-cc13-4e55-8ecc-1cbdb7fc619e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "51154297-4b70-458d-a6b1-b7ce8dcbed47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7ca6f91-5f98-4c26-8ef1-48fdd6c965d1", "AQAAAAEAACcQAAAAENSS/4oWp1xuA3jCMnqs70kjfybguzNFcLnIxkpW288D07wq3UlYhwJ14ErCoxKfjA==", "4c36c532-9d80-4d16-9a40-d9e04f2162ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a5be42f-7e4f-4ce6-973b-4b5bf2a4b1fe", "AQAAAAEAACcQAAAAEGL6CCeDo3mSY6hEsbhb9E0oSWBrVvgFk/fluz9QPUBhOKLnxaQ/34NxRtXnauNJBg==", "ed120949-7d9c-4d82-9c60-4eeb8f39dcdd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "31f3b2aa-7610-4c51-88c8-6c69a007bed0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "d793b0e0-83e0-4c74-9e7b-2048d4a9979d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d74910-71ae-4391-a5e7-a912e82ed0c5", "AQAAAAEAACcQAAAAEBeS+C1XpKlW94KaRAIO6TQqruTjx8rutLmxYcXsliGtsfRj7FwG5VtmrhEYAz2DaA==", "437adb44-74e2-4239-ad32-7c97a8b5ef3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b52f98e-fae8-454d-b169-a55ec4c2e094", "AQAAAAEAACcQAAAAEI01oZYiI2P6ujvheEhorSXrJTVCeD7HJa2J3ySsTBqkH3E6eda9Xc5YParQN4LVVw==", "6f77c90b-9a10-4ff0-8f98-07e2f7aff8cd" });
        }
    }
}

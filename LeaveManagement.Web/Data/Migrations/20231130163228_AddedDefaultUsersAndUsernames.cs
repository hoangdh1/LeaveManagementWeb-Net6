using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "94d74910-71ae-4391-a5e7-a912e82ed0c5", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBeS+C1XpKlW94KaRAIO6TQqruTjx8rutLmxYcXsliGtsfRj7FwG5VtmrhEYAz2DaA==", "437adb44-74e2-4239-ad32-7c97a8b5ef3a", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1b52f98e-fae8-454d-b169-a55ec4c2e094", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEI01oZYiI2P6ujvheEhorSXrJTVCeD7HJa2J3ySsTBqkH3E6eda9Xc5YParQN4LVVw==", "6f77c90b-9a10-4ff0-8f98-07e2f7aff8cd", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "a981d42d-4eec-4cae-bdc9-f36f10d3de04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa7a15d-b065-41fe-94de-3d700a365586",
                column: "ConcurrencyStamp",
                value: "ed049bf1-a7aa-47c2-840a-7600f7320561");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a5846fe8-5636-4987-a886-65e938212929", null, "AQAAAAEAACcQAAAAEK/OXveWTFVVuc4UjQyJhLlvjveyKSaF+P7SHfe3TGpMsc/y/Iew9Q6x9LjLgYSbnQ==", "8e19223a-05fe-4f7d-ac46-3279c87c15a5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa7a15d-b065-41fe-94de-3d700a365586",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a8e95a70-e04d-49f4-98af-54000544e7c3", null, "AQAAAAEAACcQAAAAEMCFS3yXPnZmxuBxovyhCR55aDETmJExlrVpQZTCtZWWQ2Va46Qpbv1/7KKShnmV7w==", "315fe749-01e1-4128-9953-25212994bd50", null });
        }
    }
}

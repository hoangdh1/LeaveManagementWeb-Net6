using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6fa7a15d-b065-41fe-94de-3d700a365586", "a981d42d-4eec-4cae-bdc9-f36f10d3de04", "Administrator", "ADMINISTRATOR" },
                    { "7fa7a15d-b065-41fe-94de-3d700a365586", "ed049bf1-a7aa-47c2-840a-7600f7320561", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8fa7a15d-b065-41fe-94de-3d700a365586", 0, "a5846fe8-5636-4987-a886-65e938212929", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEK/OXveWTFVVuc4UjQyJhLlvjveyKSaF+P7SHfe3TGpMsc/y/Iew9Q6x9LjLgYSbnQ==", null, false, "8e19223a-05fe-4f7d-ac46-3279c87c15a5", null, false, null },
                    { "9fa7a15d-b065-41fe-94de-3d700a365586", 0, "a8e95a70-e04d-49f4-98af-54000544e7c3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMCFS3yXPnZmxuBxovyhCR55aDETmJExlrVpQZTCtZWWQ2Va46Qpbv1/7KKShnmV7w==", null, false, "315fe749-01e1-4128-9953-25212994bd50", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fa7a15d-b065-41fe-94de-3d700a365586", "8fa7a15d-b065-41fe-94de-3d700a365586" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7fa7a15d-b065-41fe-94de-3d700a365586", "9fa7a15d-b065-41fe-94de-3d700a365586" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fa7a15d-b065-41fe-94de-3d700a365586", "8fa7a15d-b065-41fe-94de-3d700a365586" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7fa7a15d-b065-41fe-94de-3d700a365586", "9fa7a15d-b065-41fe-94de-3d700a365586" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa7a15d-b065-41fe-94de-3d700a365586");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa7a15d-b065-41fe-94de-3d700a365586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa7a15d-b065-41fe-94de-3d700a365586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa7a15d-b065-41fe-94de-3d700a365586");
        }
    }
}

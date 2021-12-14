using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "1",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "10",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "2",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "3",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "4",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "5",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "6",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "7",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "8",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "9",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "1",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "10",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "2",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "3",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "4",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "5",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "6",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "7",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "8",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "9",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 512, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "1",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 507, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "2",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "3",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "4",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "5",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 48, 26, 511, DateTimeKind.Local).AddTicks(3177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "1",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "10",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "2",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "3",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "4",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "5",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "6",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "7",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "8",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Cat",
                keyColumn: "Id",
                keyValue: "9",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "1",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "10",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "2",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "3",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "4",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "5",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "6",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "7",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "8",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: "9",
                column: "DOB",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "1",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 690, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "2",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "3",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "4",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: "5",
                column: "Dob",
                value: new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5502));
        }
    }
}

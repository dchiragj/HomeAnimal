using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfPets = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfFeeding = table.Column<double>(type: "float", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CatchingMouses = table.Column<bool>(type: "bit", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Vaccination = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cat_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfFeeding = table.Column<double>(type: "float", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LevelOfTraining = table.Column<int>(type: "int", nullable: false),
                    SupposedHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Vaccination = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "Address", "Age", "Dob", "Gender", "Name", "NoOfPets", "Phone" },
                values: new object[,]
                {
                    { "1", "New York", 366, new DateTime(2021, 10, 15, 11, 39, 5, 690, DateTimeKind.Local).AddTicks(2419), "Male", "John", 4, "00000" },
                    { "2", "New York", 560, new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5222), "Male", "Ryan", 2, "00000" },
                    { "3", "New York", 560, new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5443), "Male", "Smith", 6, "00000" },
                    { "4", "New York", 560, new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5476), "Female", "Riya", 4, "00000" },
                    { "5", "New York", 560, new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5502), "Female", "Kriva", 4, "00000" }
                });

            migrationBuilder.InsertData(
                table: "Cat",
                columns: new[] { "Id", "Age", "Breed", "CatchingMouses", "Characteristics", "Colour", "DOB", "Gender", "MedicalCondition", "Name", "NoOfFeeding", "OwnerId", "Vaccination" },
                values: new object[,]
                {
                    { "1", 368, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(6802), "Male", "xyz", "Cat1", 1.0, "1", false },
                    { "2", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(506), "Male", "xyz", "Cat2", 1.0, "1", true },
                    { "10", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(839), "Male", "xyz", "Cat10", 1.0, "5", true },
                    { "9", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(808), "Male", "xyz", "Cat9", 1.0, "5", true },
                    { "3", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(654), "Male", "xyz", "Cat3", 1.0, "2", true },
                    { "4", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(685), "Male", "xyz", "Cat4", 1.0, "3", true },
                    { "5", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(709), "Male", "xyz", "Cat5", 1.0, "3", true },
                    { "6", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(736), "Male", "xyz", "Cat6", 1.0, "3", true },
                    { "8", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(785), "Male", "xyz", "Cat8", 1.0, "4", true },
                    { "7", 455, "2", true, "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(761), "Male", "xyz", "Cat7", 1.0, "4", true }
                });

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "Age", "Breed", "Characteristics", "Colour", "DOB", "Gender", "LevelOfTraining", "MedicalCondition", "Name", "NoOfFeeding", "OwnerId", "SupposedHeight", "Vaccination" },
                values: new object[,]
                {
                    { "8", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5534), "Male", 5, "xyz", "Dog8", 1.0, "4", "20cm", true },
                    { "7", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5453), "Male", 5, "xyz", "Dog7", 1.0, "4", "20cm", true },
                    { "4", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5376), "Male", 5, "xyz", "Dog4", 1.0, "3", "20cm", true },
                    { "5", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5400), "Male", 5, "xyz", "Dog5", 1.0, "3", "20cm", true },
                    { "9", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5563), "Male", 5, "xyz", "Dog9", 1.0, "5", "20cm", true },
                    { "3", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5345), "Male", 5, "xyz", "Dog3", 1.0, "2", "20cm", true },
                    { "2", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5193), "Male", 5, "xyz", "Dog2", 1.0, "1", "20cm", true },
                    { "1", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(1817), "Male", 5, "xyz", "Dog1", 1.0, "1", "20cm", true },
                    { "6", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5428), "Male", 5, "xyz", "Dog6", 1.0, "3", "20cm", true },
                    { "10", 422, "xyz", "brown-big", "black", new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5591), "Male", 5, "xyz", "Dog10", 1.0, "5", "20cm", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cat_OwnerId",
                table: "Cat",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dog_OwnerId",
                table: "Dog",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat");

            migrationBuilder.DropTable(
                name: "Dog");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}

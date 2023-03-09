using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWithAspNet.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admited_Student_Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First_Name", type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "nvarchar(max)", nullable: false),
                    FatherNID = table.Column<string>(name: "Father_NID", type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(name: "Father_Name", type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(name: "Mother_Name", type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(name: "Mobile_Number", type: "nvarchar(max)", nullable: false),
                    ClassMaintainId = table.Column<int>(name: "Class_Maintain_Id", type: "int", nullable: false),
                    ClassRoll = table.Column<int>(name: "Class_Roll", type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admited_Student_Infos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Info", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admited_Student_Infos");

            migrationBuilder.DropTable(
                name: "User_Info");
        }
    }
}

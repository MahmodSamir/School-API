using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial_creation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Period = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudID);
                    table.ForeignKey(
                        name: "FK_Student_Department_DID",
                        column: x => x.DID,
                        principalTable: "Department",
                        principalColumn: "DID");
                });

            migrationBuilder.CreateTable(
                name: "DepartmentSubject",
                columns: table => new
                {
                    DeptSubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DID = table.Column<int>(type: "int", nullable: false),
                    SubID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentSubject", x => x.DeptSubID);
                    table.ForeignKey(
                        name: "FK_DepartmentSubject_Department_DID",
                        column: x => x.DID,
                        principalTable: "Department",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentSubject_Subject_SubID",
                        column: x => x.SubID,
                        principalTable: "Subject",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudSubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudID = table.Column<int>(type: "int", nullable: false),
                    SubID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => x.StudSubID);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudID",
                        column: x => x.StudID,
                        principalTable: "Student",
                        principalColumn: "StudID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubID",
                        column: x => x.SubID,
                        principalTable: "Subject",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubject_DID",
                table: "DepartmentSubject",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSubject_SubID",
                table: "DepartmentSubject",
                column: "SubID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DID",
                table: "Student",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_StudID",
                table: "StudentSubject",
                column: "StudID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubID",
                table: "StudentSubject",
                column: "SubID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentSubject");

            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}

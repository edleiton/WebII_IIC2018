﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Universidad.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    IDAlumno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Apellido1 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Apellido2 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.IDAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    IDMateria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Precio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.IDMateria);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    IDProfesor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Apellido1 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Apellido2 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.IDProfesor);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    IDMatricula = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDAlumno = table.Column<int>(nullable: false),
                    IDProfesor = table.Column<int>(nullable: false),
                    IDMateria = table.Column<int>(nullable: false),
                    Nota = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.IDMatricula);
                    table.ForeignKey(
                        name: "fk_matricula_alumno",
                        column: x => x.IDAlumno,
                        principalTable: "Alumno",
                        principalColumn: "IDAlumno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_matricula_materia",
                        column: x => x.IDMateria,
                        principalTable: "Materia",
                        principalColumn: "IDMateria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_matricula_profesor",
                        column: x => x.IDProfesor,
                        principalTable: "Profesor",
                        principalColumn: "IDProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_IDAlumno",
                table: "Matricula",
                column: "IDAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_IDMateria",
                table: "Matricula",
                column: "IDMateria");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_IDProfesor",
                table: "Matricula",
                column: "IDProfesor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}

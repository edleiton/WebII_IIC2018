﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Universidad.Models;

namespace Universidad.Migrations
{
    [DbContext(typeof(PARCIALDBContext))]
    [Migration("20180627060756_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Universidad.Models.Alumno", b =>
                {
                    b.Property<int>("Idalumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDAlumno")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Idalumno");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Universidad.Models.Materia", b =>
                {
                    b.Property<int>("Idmateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDMateria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Estado")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Precio");

                    b.HasKey("Idmateria");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("Universidad.Models.Matricula", b =>
                {
                    b.Property<int>("Idmatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDMatricula")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Idalumno")
                        .IsRequired()
                        .HasColumnName("IDAlumno");

                    b.Property<int?>("Idmateria")
                        .IsRequired()
                        .HasColumnName("IDMateria");

                    b.Property<int?>("Idprofesor")
                        .IsRequired()
                        .HasColumnName("IDProfesor");

                    b.Property<double?>("Nota");

                    b.HasKey("Idmatricula");

                    b.HasIndex("Idalumno");

                    b.HasIndex("Idmateria");

                    b.HasIndex("Idprofesor");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("Universidad.Models.Profesor", b =>
                {
                    b.Property<int>("Idprofesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDProfesor")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Estado");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Idprofesor");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Universidad.Models.Matricula", b =>
                {
                    b.HasOne("Universidad.Models.Alumno", "IdalumnoNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idalumno")
                        .HasConstraintName("fk_matricula_alumno")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Universidad.Models.Materia", "IdmateriaNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idmateria")
                        .HasConstraintName("fk_matricula_materia")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Universidad.Models.Profesor", "IdprofesorNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idprofesor")
                        .HasConstraintName("fk_matricula_profesor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

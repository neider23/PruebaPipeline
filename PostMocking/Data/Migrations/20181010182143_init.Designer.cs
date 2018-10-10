﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostMocking.Data;

namespace PostMocking.Data.Migrations
{
    [DbContext(typeof(PostDbContext))]
    [Migration("20181010182143_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PostMocking.Data.Alumnos", b =>
                {
                    b.Property<int>("IdAlumno")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdCurso");

                    b.Property<DateTime>("Nacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("IdAlumno");

                    b.HasIndex("IdCurso");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("PostMocking.Data.Cursos", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ciudad");

                    b.Property<int>("IdProfesor");

                    b.Property<string>("Nombre");

                    b.HasKey("IdCurso");

                    b.HasIndex("IdProfesor");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("PostMocking.Data.Profesores", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("PostMocking.Data.Alumnos", b =>
                {
                    b.HasOne("PostMocking.Data.Cursos", "Curso")
                        .WithMany("Alumnos")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PostMocking.Data.Cursos", b =>
                {
                    b.HasOne("PostMocking.Data.Profesores", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BeautyInternational.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeautyInternational.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsCita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("servicioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("servicioid");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsHistoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("citasid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("citasid");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsLogueo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Logueos");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsPersona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registroUnico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ClsPersona");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsServicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<string>("tipoServicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsAdministrador", b =>
                {
                    b.HasBaseType("BeautyInternational.App.Dominio.ClsPersona");

                    b.Property<string>("nivelEstudio")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ClsAdministrador");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsCliente", b =>
                {
                    b.HasBaseType("BeautyInternational.App.Dominio.ClsPersona");

                    b.Property<int?>("citaid")
                        .HasColumnType("int");

                    b.Property<int?>("historiaid")
                        .HasColumnType("int");

                    b.HasIndex("citaid");

                    b.HasIndex("historiaid");

                    b.HasDiscriminator().HasValue("ClsCliente");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsProfesional", b =>
                {
                    b.HasBaseType("BeautyInternational.App.Dominio.ClsPersona");

                    b.Property<int?>("citaid")
                        .HasColumnType("int")
                        .HasColumnName("ClsProfesional_citaid");

                    b.Property<string>("nivelEstudio")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClsProfesional_nivelEstudio");

                    b.HasIndex("citaid");

                    b.HasDiscriminator().HasValue("ClsProfesional");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsCita", b =>
                {
                    b.HasOne("BeautyInternational.App.Dominio.ClsServicio", "servicio")
                        .WithMany()
                        .HasForeignKey("servicioid");

                    b.Navigation("servicio");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsHistoria", b =>
                {
                    b.HasOne("BeautyInternational.App.Dominio.ClsCita", "citas")
                        .WithMany()
                        .HasForeignKey("citasid");

                    b.Navigation("citas");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsCliente", b =>
                {
                    b.HasOne("BeautyInternational.App.Dominio.ClsCita", "cita")
                        .WithMany()
                        .HasForeignKey("citaid");

                    b.HasOne("BeautyInternational.App.Dominio.ClsHistoria", "historia")
                        .WithMany()
                        .HasForeignKey("historiaid");

                    b.Navigation("cita");

                    b.Navigation("historia");
                });

            modelBuilder.Entity("BeautyInternational.App.Dominio.ClsProfesional", b =>
                {
                    b.HasOne("BeautyInternational.App.Dominio.ClsCita", "cita")
                        .WithMany()
                        .HasForeignKey("citaid");

                    b.Navigation("cita");
                });
#pragma warning restore 612, 618
        }
    }
}

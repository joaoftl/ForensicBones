﻿// <auto-generated />
using ForensicBones.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForensicBones.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231115193716_M01")]
    partial class M01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForensicBones.Models.InventarioCranio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartilagemTireoide")
                        .HasColumnType("int");

                    b.Property<int>("ConchaNasalDir")
                        .HasColumnType("int");

                    b.Property<int>("ConchaNasalEsq")
                        .HasColumnType("int");

                    b.Property<int>("Esfenoide")
                        .HasColumnType("int");

                    b.Property<int>("EtmoideDir")
                        .HasColumnType("int");

                    b.Property<int>("EtmoideEsq")
                        .HasColumnType("int");

                    b.Property<int>("Frontal")
                        .HasColumnType("int");

                    b.Property<int>("Hioide")
                        .HasColumnType("int");

                    b.Property<int>("IdInventarioEsqueleto")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("LacrimalDir")
                        .HasColumnType("int");

                    b.Property<int>("LacrimalEsq")
                        .HasColumnType("int");

                    b.Property<int>("Mandibula")
                        .HasColumnType("int");

                    b.Property<int>("Maxilar")
                        .HasColumnType("int");

                    b.Property<int>("NasalEsq")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocipital")
                        .HasColumnType("int");

                    b.Property<int>("ParietalDir")
                        .HasColumnType("int");

                    b.Property<int>("ParietalEsq")
                        .HasColumnType("int");

                    b.Property<int>("TemporalDir")
                        .HasColumnType("int");

                    b.Property<int>("TemporalEsq")
                        .HasColumnType("int");

                    b.Property<int>("Vomer")
                        .HasColumnType("int");

                    b.Property<int>("ZigomaticoDir")
                        .HasColumnType("int");

                    b.Property<int>("ZigomaticoEsq")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InventariosCranio");
                });

            modelBuilder.Entity("ForensicBones.Models.InventarioEsqueleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdRelatorio")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InventariosEsqueleto");
                });

            modelBuilder.Entity("ForensicBones.Models.MarcadoresCranio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AreaGlabela")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CristaNucal")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("EminenciaMentoniana")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("IdInventarioCranio")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessoMastoide")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("ResultadoSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("SupraOrbital")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("MarcadoresCranios");
                });

            modelBuilder.Entity("ForensicBones.Models.Relatorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("ForensicBones.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Hackaton.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hackaton.App.Persistencia.Migrations
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

            modelBuilder.Entity("Hackaton.App.Dominio.Entidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razon_social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webpage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("Hackaton.App.Dominio.Sector", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("no_gubernamental")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("privado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sin_animo_de_lucro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sectores");
                });

            modelBuilder.Entity("Hackaton.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("alojamiennto_permanente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alojamiento_temporal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comida_preparada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empleo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juridicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viveres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}

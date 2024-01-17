﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _01DiyetProjesi.DAL.Context.EF;

#nullable disable

namespace _01DiyetProjesi.DAL.Migrations
{
    [DbContext(typeof(EfDbContext))]
    [Migration("20240117193046_mig3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.DiyetTablosu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Birim")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modifided")
                        .HasColumnType("datetime2");

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<int>("PorsiyonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("YenilenGun")
                        .HasColumnType("datetime2");

                    b.Property<int>("YiyecekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("OgunId");

                    b.HasIndex("PorsiyonId");

                    b.HasIndex("YiyecekId");

                    b.ToTable("DiyetTablolari");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<float>("Kilo")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Modifided")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Yas")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modifided")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Porsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modifided")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Porsiyonlar");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Yiyecek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<float>("Kalori")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Modifided")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Resim")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Yiyecekler");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.DiyetTablosu", b =>
                {
                    b.HasOne("_01DiyetProjesi.DAL.Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("DiyetTablolari")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_01DiyetProjesi.DAL.Entities.Concrete.Ogun", "Ogun")
                        .WithMany("DiyetTablolari")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_01DiyetProjesi.DAL.Entities.Concrete.Porsiyon", "Porsiyon")
                        .WithMany("DiyetTablolari")
                        .HasForeignKey("PorsiyonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_01DiyetProjesi.DAL.Entities.Concrete.Yiyecek", "Yiyecek")
                        .WithMany("DiyetTablolari")
                        .HasForeignKey("YiyecekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Ogun");

                    b.Navigation("Porsiyon");

                    b.Navigation("Yiyecek");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Kullanici", b =>
                {
                    b.Navigation("DiyetTablolari");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Ogun", b =>
                {
                    b.Navigation("DiyetTablolari");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Porsiyon", b =>
                {
                    b.Navigation("DiyetTablolari");
                });

            modelBuilder.Entity("_01DiyetProjesi.DAL.Entities.Concrete.Yiyecek", b =>
                {
                    b.Navigation("DiyetTablolari");
                });
#pragma warning restore 612, 618
        }
    }
}

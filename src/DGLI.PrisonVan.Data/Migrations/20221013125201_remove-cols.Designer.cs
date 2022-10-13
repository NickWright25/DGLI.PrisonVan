﻿// <auto-generated />
using System;
using DGLI.PrisonVan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DGLI.PrisonVan.Data.Migrations
{
    [DbContext(typeof(UnitOfWork))]
    [Migration("20221013125201_remove-cols")]
    partial class removecols
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("DGLI.PrisonVan.Data.Soundcard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FriendlyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Soundcards");
                });

            modelBuilder.Entity("DGLI.PrisonVan.Data.SoundFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .HasColumnType("TEXT");

                    b.Property<long>("FileSize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sequence")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SoundcardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SoundcardId");

                    b.ToTable("SoundFiles");
                });

            modelBuilder.Entity("DGLI.PrisonVan.Data.SoundFile", b =>
                {
                    b.HasOne("DGLI.PrisonVan.Data.Soundcard", "Soundcard")
                        .WithMany("SoundFiles")
                        .HasForeignKey("SoundcardId");

                    b.Navigation("Soundcard");
                });

            modelBuilder.Entity("DGLI.PrisonVan.Data.Soundcard", b =>
                {
                    b.Navigation("SoundFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
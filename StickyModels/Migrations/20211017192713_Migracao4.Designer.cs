﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StickyNotes.CORE.DAL;

namespace StickyModels.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20211017192713_Migracao4")]
    partial class Migracao4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("StickyNotes.CORE.Models.CardModel", b =>
                {
                    b.Property<int>("cod_card")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("card_position_x")
                        .HasColumnType("INTEGER");

                    b.Property<int>("card_position_y")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cod_color")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cod_place")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cod_tag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("dt_reminder")
                        .HasColumnType("TEXT");

                    b.Property<bool>("open")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("reminder_confirm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("cod_card");

                    b.HasIndex("cod_color");

                    b.HasIndex("cod_place");

                    b.HasIndex("cod_tag");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.ColorModel", b =>
                {
                    b.Property<int>("cod_color")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("font_color")
                        .HasColumnType("TEXT");

                    b.Property<string>("hex_text")
                        .HasColumnType("TEXT");

                    b.HasKey("cod_color");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.ImageModel", b =>
                {
                    b.Property<int>("cod_image")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cod_card")
                        .HasColumnType("INTEGER");

                    b.Property<string>("path")
                        .HasColumnType("TEXT");

                    b.HasKey("cod_image");

                    b.HasIndex("cod_card");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.PlaceModel", b =>
                {
                    b.Property<int>("cod_place")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("place_position_x")
                        .HasColumnType("INTEGER");

                    b.Property<int>("place_position_y")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.HasKey("cod_place");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.TagModel", b =>
                {
                    b.Property<int>("cod_tag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("cod_tag");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.CardModel", b =>
                {
                    b.HasOne("StickyNotes.CORE.Models.ColorModel", "FK_Color")
                        .WithMany()
                        .HasForeignKey("cod_color");

                    b.HasOne("StickyNotes.CORE.Models.PlaceModel", "FK_Place")
                        .WithMany("ICards")
                        .HasForeignKey("cod_place");

                    b.HasOne("StickyNotes.CORE.Models.TagModel", "FK_Tag")
                        .WithMany()
                        .HasForeignKey("cod_tag");

                    b.Navigation("FK_Color");

                    b.Navigation("FK_Place");

                    b.Navigation("FK_Tag");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.ImageModel", b =>
                {
                    b.HasOne("StickyNotes.CORE.Models.CardModel", "FK_Card")
                        .WithMany("IImages")
                        .HasForeignKey("cod_card")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_Card");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.CardModel", b =>
                {
                    b.Navigation("IImages");
                });

            modelBuilder.Entity("StickyNotes.CORE.Models.PlaceModel", b =>
                {
                    b.Navigation("ICards");
                });
#pragma warning restore 612, 618
        }
    }
}

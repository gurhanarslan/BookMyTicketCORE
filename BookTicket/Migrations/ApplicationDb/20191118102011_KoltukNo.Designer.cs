﻿// <auto-generated />
using System;
using BookTicket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTicket.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191118102011_KoltukNo")]
    partial class KoltukNo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTicket.Models.BiletHole", b =>
                {
                    b.Property<int>("BiletHoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BiletStatus");

                    b.HasKey("BiletHoleId");

                    b.ToTable("biletHoles");
                });

            modelBuilder.Entity("BookTicket.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookTicket.Models.Movies", b =>
                {
                    b.Property<int>("MoviesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<string>("FilmDate");

                    b.Property<string>("Image");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsSliderHome");

                    b.Property<bool>("IsSliderLogin1");

                    b.Property<bool>("IsSliderLogin2");

                    b.Property<string>("MoviesDescription");

                    b.Property<string>("MoviesDirector");

                    b.Property<string>("MoviesName");

                    b.Property<string>("MoviesSeans");

                    b.Property<int?>("TicketBiletNumberId");

                    b.HasKey("MoviesId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TicketBiletNumberId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BookTicket.Models.Ticket", b =>
                {
                    b.Property<int>("BiletNumberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("FullorEmpty");

                    b.Property<bool>("KoltukNo1");

                    b.Property<bool>("KoltukNo10");

                    b.Property<bool>("KoltukNo11");

                    b.Property<bool>("KoltukNo12");

                    b.Property<bool>("KoltukNo13");

                    b.Property<bool>("KoltukNo14");

                    b.Property<bool>("KoltukNo15");

                    b.Property<bool>("KoltukNo16");

                    b.Property<bool>("KoltukNo17");

                    b.Property<bool>("KoltukNo18");

                    b.Property<bool>("KoltukNo19");

                    b.Property<bool>("KoltukNo2");

                    b.Property<bool>("KoltukNo20");

                    b.Property<bool>("KoltukNo21");

                    b.Property<bool>("KoltukNo22");

                    b.Property<bool>("KoltukNo23");

                    b.Property<bool>("KoltukNo24");

                    b.Property<bool>("KoltukNo25");

                    b.Property<bool>("KoltukNo26");

                    b.Property<bool>("KoltukNo27");

                    b.Property<bool>("KoltukNo28");

                    b.Property<bool>("KoltukNo29");

                    b.Property<bool>("KoltukNo3");

                    b.Property<bool>("KoltukNo30");

                    b.Property<bool>("KoltukNo4");

                    b.Property<bool>("KoltukNo5");

                    b.Property<bool>("KoltukNo6");

                    b.Property<bool>("KoltukNo7");

                    b.Property<bool>("KoltukNo8");

                    b.Property<bool>("KoltukNo9");

                    b.HasKey("BiletNumberId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BookTicket.Models.Movies", b =>
                {
                    b.HasOne("BookTicket.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookTicket.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketBiletNumberId");
                });
#pragma warning restore 612, 618
        }
    }
}
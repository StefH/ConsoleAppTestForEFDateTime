﻿// <auto-generated />
using System;
using ConsoleAppTestForEFDateTime.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleAppTestForEFDateTime.Migrations
{
    [DbContext(typeof(MyHotelDbContext))]
    [Migration("20190810174332_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int?>("NullableInt");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckinDate");

                    b.Property<DateTime>("CheckoutDate");

                    b.Property<int>("GuestId");

                    b.Property<int>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowedSmoking");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<int>("Number");

                    b.Property<int?>("RoomDetailId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("RoomDetailId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.RoomDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Beds");

                    b.Property<int>("Windows");

                    b.HasKey("Id");

                    b.ToTable("RoomDetails");
                });

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Reservation", b =>
                {
                    b.HasOne("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.Room", b =>
                {
                    b.HasOne("ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities.RoomDetail", "RoomDetail")
                        .WithMany()
                        .HasForeignKey("RoomDetailId");
                });
#pragma warning restore 612, 618
        }
    }
}

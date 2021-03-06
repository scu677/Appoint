﻿// <auto-generated />
using Appoint.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Appoint.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180618003309_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Appoint.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EndTime");

                    b.Property<int>("PartnerFK");

                    b.Property<int>("ServiceFK");

                    b.Property<int>("StartTime");

                    b.Property<int>("TimeBook");

                    b.Property<int>("UserFK");

                    b.HasKey("BookingID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Appoint.Models.Partner_Client", b =>
                {
                    b.Property<int>("Partner_ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BizDescription")
                        .IsRequired();

                    b.Property<string>("BizName")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<byte[]>("File");

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<string>("OpeningHours")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Postcode")
                        .IsRequired();

                    b.Property<string>("Province")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("Partner_ClientID");

                    b.ToTable("Partner_Clients");
                });

            modelBuilder.Entity("Appoint.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EndTime");

                    b.Property<int>("PartnerFK");

                    b.Property<int>("ScheduleDuration");

                    b.Property<string>("ServiceName");

                    b.Property<int>("StartTime");

                    b.Property<bool>("Status");

                    b.HasKey("ScheduleID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Appoint.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Duration");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PartnerFK");

                    b.Property<string>("Price")
                        .IsRequired();

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Appoint.Models.User_Client", b =>
                {
                    b.Property<int>("User_ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Postcode");

                    b.Property<string>("Street");

                    b.HasKey("User_ClientID");

                    b.ToTable("User_Clients");
                });
#pragma warning restore 612, 618
        }
    }
}

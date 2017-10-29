﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Solutiuons.Budgeting.Web.Data;
using System;

namespace Solutiuons.Budgeting.Web.Migrations
{
    [DbContext(typeof(BillContext))]
    partial class BillContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Solutiuons.Budgeting.Web.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllDay");

                    b.Property<double>("MinimumPayment");

                    b.Property<string>("Name");

                    b.Property<string>("Schedule");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
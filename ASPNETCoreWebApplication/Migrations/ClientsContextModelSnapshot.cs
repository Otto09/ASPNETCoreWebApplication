﻿// <auto-generated />
using System;
using ASPNETCoreWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCoreWebApplication.Migrations
{
    [DbContext(typeof(ClientsContext))]
    partial class ClientsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNETCoreWebApplication.Models.Clients", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("SellDate");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}

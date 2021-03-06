﻿// <auto-generated />
using System;
using APS_6.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APS_6.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(APSContext))]
    partial class APSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APS_6.Domain.Entities.Pesticide", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Legal")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ToxicLevel")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.ToTable("Pesticide");
                });

            modelBuilder.Entity("APS_6.Domain.Entities.PesticideRuralProperty", b =>
                {
                    b.Property<Guid>("PesticideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RuralPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PesticideId", "RuralPropertyId");

                    b.HasIndex("RuralPropertyId");

                    b.ToTable("PesticideRuralProperties");
                });

            modelBuilder.Entity("APS_6.Domain.Entities.RuralProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("RuralProperty");
                });

            modelBuilder.Entity("APS_6.Domain.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadlineDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<Guid>("RuralPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("RuralPropertyId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("APS_6.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("APS_6.Domain.Entities.PesticideRuralProperty", b =>
                {
                    b.HasOne("APS_6.Domain.Entities.Pesticide", "Pesticide")
                        .WithMany("PesticideRuralProperties")
                        .HasForeignKey("PesticideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APS_6.Domain.Entities.RuralProperty", "RuralProperty")
                        .WithMany("PesticideRuralProperties")
                        .HasForeignKey("RuralPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APS_6.Domain.Entities.Ticket", b =>
                {
                    b.HasOne("APS_6.Domain.Entities.RuralProperty", "RuralProperty")
                        .WithMany("Tickets")
                        .HasForeignKey("RuralPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BirdingLog.Models;

namespace BirdingLog.Migrations
{
    [DbContext(typeof(BirdingLogContext))]
    partial class BirdingLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BirdingLog.Models.Bird", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Family");

                    b.Property<string>("Species");

                    b.HasKey("Id");

                    b.ToTable("Birds");
                });

            modelBuilder.Entity("BirdingLog.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BirdId");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Taken");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("BirdId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("BirdingLog.Models.Photo", b =>
                {
                    b.HasOne("BirdingLog.Models.Bird")
                        .WithMany()
                        .HasForeignKey("BirdId");
                });
        }
    }
}

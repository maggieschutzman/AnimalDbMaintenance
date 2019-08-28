﻿// <auto-generated />
using Animals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animals.Migrations
{
    [DbContext(typeof(AnimalDB))]
    partial class AnimalDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Animals.Models.Animal", b =>
                {
                    b.Property<int>("AniamlId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Food")
                        .HasMaxLength(30);

                    b.Property<string>("Habitat")
                        .HasMaxLength(30);

                    b.Property<int>("Legs");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("AniamlId");

                    b.ToTable("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}

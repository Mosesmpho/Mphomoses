﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mphomoses.Data;

#nullable disable

namespace Mphomoses.Migrations
{
    [DbContext(typeof(MphomosesContext))]
    partial class MphomosesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mphomoses.Models.Learners", b =>
                {
                    b.Property<long>("LearnersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LearnersId"));

                    b.Property<string>("LearnersIdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnersSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LearnersId");

                    b.ToTable("Learners");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TungSon.Migrations
{
    [DbContext(typeof(NTSContext))]
    partial class NTSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TungSon.NTS", b =>
                {
                    b.Property<string>("NTSID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NTSname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("NTSID");

                    b.ToTable("NTS");
                });

            modelBuilder.Entity("TungSon.Sinhvien", b =>
                {
                    b.Property<string>("SVId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("SVgender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SVname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("SVId");

                    b.ToTable("Sinhvien");
                });
#pragma warning restore 612, 618
        }
    }
}

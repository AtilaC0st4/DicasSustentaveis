﻿// <auto-generated />
using DicasSustentaveisGS1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace DicasSustentaveisGS1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241121012114_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DicasSustentaveisGS1.Models.Frase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.HasKey("Id");

                    b.ToTable("Frases");
                });

            modelBuilder.Entity("DicasSustentaveisGS1.Models.FrasePreferida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FraseId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("FraseId");

                    b.ToTable("FrasesPreferidas");
                });

            modelBuilder.Entity("DicasSustentaveisGS1.Models.FrasePreferida", b =>
                {
                    b.HasOne("DicasSustentaveisGS1.Models.Frase", "Frase")
                        .WithMany()
                        .HasForeignKey("FraseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Frase");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoUnimed.Context;

#nullable disable

namespace ProjetoUnimed.Migrations
{
    [DbContext(typeof(UnimedContext))]
    [Migration("20220515012659_CPFMigration")]
    partial class CPFMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("ProjetoUnimed.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Procedimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDaMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PlanoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Plano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeDoPlano")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroCarterinha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Exame", b =>
                {
                    b.HasOne("ProjetoUnimed.Models.Pessoa", null)
                        .WithMany("Exames")
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Pessoa", b =>
                {
                    b.HasOne("ProjetoUnimed.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoUnimed.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("ProjetoUnimed.Models.Pessoa", b =>
                {
                    b.Navigation("Exames");
                });
#pragma warning restore 612, 618
        }
    }
}

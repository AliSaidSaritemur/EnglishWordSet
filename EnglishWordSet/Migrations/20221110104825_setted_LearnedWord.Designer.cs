﻿// <auto-generated />
using EnglishWordSet.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnglishWordSet.Migrations
{
    [DbContext(typeof(WordContext))]
    [Migration("20221110104825_setted_LearnedWord")]
    partial class setted_LearnedWord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EnglishWordSet.Data.Entities.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EnglishWordSet.Data.Entities.LearnedWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("meaningWordSentence")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("learnedWord_meanigSentence");

                    b.Property<string>("wordEnglish")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("learnedWord_word");

                    b.Property<string>("wordSentence")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("learnedWord_sentence");

                    b.Property<string>("wordTurkish")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("learnedWord_meanig");

                    b.HasKey("Id");

                    b.HasIndex("wordEnglish")
                        .IsUnique()
                        .HasFilter("[learnedWord_word] IS NOT NULL");

                    b.ToTable("LearnedWords");
                });

            modelBuilder.Entity("EnglishWordSet.Data.Entities.NWords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("English")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turkish")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}

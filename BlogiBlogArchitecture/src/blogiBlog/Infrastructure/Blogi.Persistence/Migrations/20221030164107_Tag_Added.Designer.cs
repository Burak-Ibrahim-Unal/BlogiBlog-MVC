﻿// <auto-generated />
using Blogi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blogi.Persistence.Migrations
{
    [DbContext(typeof(BlogiBlogDbContext))]
    [Migration("20221030164107_Tag_Added")]
    partial class Tag_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blogi.Domain.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Languages", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Culture = "tr-TR",
                            Name = "Türkçe"
                        },
                        new
                        {
                            Id = 2,
                            Culture = "en-ENG",
                            Name = "English (United States)"
                        });
                });

            modelBuilder.Entity("Blogi.Domain.Entities.MailSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<bool>("SslEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("UseDefaultCredentials")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MailConfigs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "blogi_blog@gmail.com",
                            FullName = "BlogiBlog",
                            Host = "smtp.gmail.com",
                            Password = "edH3YTav2q/sjbIGo8yirB8H1+FPjzdjqW+6hW+ZWUjWTDPjzlco8GDOreEJp6K9",
                            Port = 587,
                            SslEnabled = false,
                            UseDefaultCredentials = false
                        });
                });

            modelBuilder.Entity("Blogi.Domain.Entities.StringResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("StringResources", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "page_language_button_create",
                            LanguageId = 1,
                            Value = "Yeni Dil Oluştur"
                        },
                        new
                        {
                            Id = 2,
                            Key = "page_language_button_create",
                            LanguageId = 2,
                            Value = "Create New Language"
                        },
                        new
                        {
                            Id = 3,
                            Key = "page_language_button_delete",
                            LanguageId = 1,
                            Value = "Sil"
                        },
                        new
                        {
                            Id = 4,
                            Key = "page_language_button_delete",
                            LanguageId = 2,
                            Value = "Delete"
                        },
                        new
                        {
                            Id = 5,
                            Key = "page_language_button_update",
                            LanguageId = 1,
                            Value = "Güncelle"
                        },
                        new
                        {
                            Id = 6,
                            Key = "page_language_button_update",
                            LanguageId = 2,
                            Value = "Update"
                        },
                        new
                        {
                            Id = 7,
                            Key = "page_language_label_list",
                            LanguageId = 1,
                            Value = "Dil listesi..."
                        },
                        new
                        {
                            Id = 8,
                            Key = "page_language_label_list",
                            LanguageId = 2,
                            Value = "Language list..."
                        });
                });

            modelBuilder.Entity("Blogi.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.HasKey("Id");

                    b.ToTable("Tags", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Csharp"
                        },
                        new
                        {
                            Id = 3,
                            Name = "SQL"
                        },
                        new
                        {
                            Id = 4,
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Html"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Css"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Vue"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 9,
                            Name = "React"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Design Pattern"
                        });
                });

            modelBuilder.Entity("Blogi.Domain.Entities.StringResource", b =>
                {
                    b.HasOne("Blogi.Domain.Entities.Language", "Languages")
                        .WithMany("StringResources")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Languages");
                });

            modelBuilder.Entity("Blogi.Domain.Entities.Language", b =>
                {
                    b.Navigation("StringResources");
                });
#pragma warning restore 612, 618
        }
    }
}

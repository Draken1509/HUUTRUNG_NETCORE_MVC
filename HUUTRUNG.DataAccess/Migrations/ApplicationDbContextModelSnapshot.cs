﻿// <auto-generated />
using System;
using HUUTRUNG.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HUUTRUNG.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HUUTRUNG.Models.Alignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alignment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BIRDS OF PREY "
                        },
                        new
                        {
                            Id = 2,
                            Name = "BATGIRL "
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Graphic Novel"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Comic Book"
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaseOfOperations")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstAppearance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Power")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Wonder woman",
                            BaseOfOperations = "Chiu",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.",
                            FirstAppearance = "abc",
                            Name = "Action Novel",
                            Occupation = "abc",
                            Power = "super metal",
                            Thumbnail = "hehe.jpg",
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Wonder woman",
                            BaseOfOperations = "Chiu",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.",
                            FirstAppearance = "abc",
                            Name = "Action Novel",
                            Occupation = "abc",
                            Power = "super metal",
                            Thumbnail = "hehe.jpg",
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Wonder woman",
                            BaseOfOperations = "Chiu",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.",
                            FirstAppearance = "abc",
                            Name = "Action Novel",
                            Occupation = "abc",
                            Power = "super metal",
                            Thumbnail = "hehe.jpg",
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            Alias = "Wonder woman",
                            BaseOfOperations = "Chiu",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.",
                            FirstAppearance = "abc",
                            Name = "Action Novel",
                            Occupation = "abc",
                            Power = "super metal",
                            Thumbnail = "hehe.jpg",
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            Alias = "Wonder woman",
                            BaseOfOperations = "Chiu",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.",
                            FirstAppearance = "abc",
                            Name = "Action Novel",
                            Occupation = "abc",
                            Power = "super metal",
                            Thumbnail = "hehe.jpg",
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArtBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colorist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("OnSaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PageCount")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("Price100")
                        .HasColumnType("float");

                    b.Property<double?>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Rated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeriesId")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeComicId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.HasIndex("TypeComicId");

                    b.ToTable("Comics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtBy = "Nick Dragotta",
                            Colorist = "Frank Martin",
                            Cover = "Frank Martin, Nick Dragotta",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
                            IsFree = true,
                            IsNew = false,
                            Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
                            OnSaleDate = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PageCount = 36,
                            Price = 3.5,
                            Rated = "Teen",
                            SeriesId = 1,
                            Thumbnail = "hehe.jpg",
                            TypeComicId = 1,
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Writer = "Scott Snyder"
                        },
                        new
                        {
                            Id = 2,
                            ArtBy = "Nick Dragotta",
                            Colorist = "Frank Martin",
                            Cover = "Frank Martin, Nick Dragotta",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
                            IsFree = false,
                            IsNew = false,
                            Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
                            OnSaleDate = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PageCount = 36,
                            Price = 3.5,
                            Rated = "Teen",
                            SeriesId = 2,
                            Thumbnail = "hehe.jpg",
                            TypeComicId = 2,
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Writer = "Scott Snyder"
                        },
                        new
                        {
                            Id = 3,
                            ArtBy = "Nick Dragotta",
                            Colorist = "Frank Martin",
                            Cover = "Frank Martin, Nick Dragotta",
                            Created_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
                            IsFree = true,
                            IsNew = false,
                            Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
                            OnSaleDate = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PageCount = 36,
                            Price = 3.5,
                            Rated = "Teen",
                            SeriesId = 1,
                            Thumbnail = "hehe.jpg",
                            TypeComicId = 2,
                            Updated_at = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Writer = "Scott Snyder"
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "heheh",
                            Name = "BATMAN & ROBIN: YEAR ONE NOIR EDITION "
                        },
                        new
                        {
                            Id = 2,
                            Description = "heheh",
                            Name = "BATGIRL "
                        },
                        new
                        {
                            Id = 3,
                            Description = "heheh",
                            Name = "DC VS VAMPRIES: WORLD WAR "
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.TypeComic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TypeComics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "heheh",
                            DisplayOrder = 1,
                            Name = "Graphic Novel"
                        },
                        new
                        {
                            Id = 2,
                            Description = "heheh",
                            DisplayOrder = 2,
                            Name = "Comic Book"
                        });
                });

            modelBuilder.Entity("HUUTRUNG.Models.Comic", b =>
                {
                    b.HasOne("HUUTRUNG.Models.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId");

                    b.HasOne("HUUTRUNG.Models.TypeComic", "TypeComic")
                        .WithMany()
                        .HasForeignKey("TypeComicId");

                    b.Navigation("Series");

                    b.Navigation("TypeComic");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240227103805_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("Data.Entities.AlbumEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Popularity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrackList")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Band = "The Beatles",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "47:23",
                            Name = "Abbey Road",
                            Popularity = 3,
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty."
                        },
                        new
                        {
                            Id = 2,
                            Band = "Pink Floyd",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:49",
                            Name = "The Dark Side of the Moon",
                            Popularity = 4,
                            ReleaseDate = new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse."
                        },
                        new
                        {
                            Id = 3,
                            Band = "Papa Dance",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "57:03",
                            Name = "Nasza Ziemia Eden",
                            Popularity = 2,
                            ReleaseDate = new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End"
                        },
                        new
                        {
                            Id = 4,
                            Band = "Lady Pank",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "41:27",
                            Name = "Zawsze Tam, Gdzie Ty",
                            Popularity = 3,
                            ReleaseDate = new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga"
                        },
                        new
                        {
                            Id = 5,
                            Band = "The Police",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "44:18",
                            Name = "Synchronicity",
                            Popularity = 4,
                            ReleaseDate = new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara"
                        },
                        new
                        {
                            Id = 6,
                            Band = "Michael Jackson",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:19",
                            Name = "Thriller",
                            Popularity = 4,
                            ReleaseDate = new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life"
                        },
                        new
                        {
                            Id = 7,
                            Band = "AC/DC",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:11",
                            Name = "Back in Black",
                            Popularity = 4,
                            ReleaseDate = new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Hells Bells, Shoot to Thrill, What Do You Do for Money Honey, Givin the Dog a Bone, Let Me Put My Love Into You, Back in Black, You Shook Me All Night Long, Have a Drink on Me, Shake a Leg, Rock and Roll Ain't Noise Pollution"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

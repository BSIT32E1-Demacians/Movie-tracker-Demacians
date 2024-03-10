﻿// <auto-generated />
using movie_tracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroupActivity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240308074526_SabiKo!")]
    partial class SabiKo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GroupActivity.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(63)
                        .HasColumnType("nvarchar(63)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Genre = "Sci-fi",
                            ReleaseYear = 2009,
                            Title = "Avatar"
                        },
                        new
                        {
                            MovieId = 2,
                            Genre = "Action",
                            ReleaseYear = 2019,
                            Title = "Avengers: Endgame"
                        },
                        new
                        {
                            MovieId = 3,
                            Genre = "Sci-fi",
                            ReleaseYear = 2022,
                            Title = "Avatar: The Way of Water"
                        },
                        new
                        {
                            MovieId = 4,
                            Genre = "Romance",
                            ReleaseYear = 1997,
                            Title = "Titanic"
                        },
                        new
                        {
                            MovieId = 5,
                            Genre = "Sci-fi",
                            ReleaseYear = 2015,
                            Title = "Star Wars: The Force Awakens"
                        },
                        new
                        {
                            MovieId = 6,
                            Genre = "Action",
                            ReleaseYear = 2018,
                            Title = "Avengers: Infinity War"
                        },
                        new
                        {
                            MovieId = 7,
                            Genre = "Action",
                            ReleaseYear = 2021,
                            Title = "Spider-Man: No Way Home"
                        },
                        new
                        {
                            MovieId = 8,
                            Genre = "Action",
                            ReleaseYear = 2015,
                            Title = "Jurassic World"
                        },
                        new
                        {
                            MovieId = 9,
                            Genre = "Animation",
                            ReleaseYear = 1994,
                            Title = "The Lion King"
                        },
                        new
                        {
                            MovieId = 10,
                            Genre = "Action",
                            ReleaseYear = 2012,
                            Title = "The Avengers"
                        },
                        new
                        {
                            MovieId = 11,
                            Genre = "Comedy",
                            ReleaseYear = 2020,
                            Title = "Sabi KO Sabi Ni Gelo"
                        });
                });

            modelBuilder.Entity("GroupActivity.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuoteId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuoteText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            Author = "Mahatma Gandhi",
                            QuoteText = "You must be the change you wish to see in the world."
                        },
                        new
                        {
                            QuoteId = 2,
                            Author = "Mother Teresa",
                            QuoteText = "Spread love everywhere you go. Let no one ever come to you without leaving happier."
                        },
                        new
                        {
                            QuoteId = 3,
                            Author = "Franklin D. Roosevelt",
                            QuoteText = "The only thing we have to fear is fear itself."
                        },
                        new
                        {
                            QuoteId = 4,
                            Author = "Martin Luther King Jr.",
                            QuoteText = "Darkness cannot drive out darkness: only light can do that. Hate cannot drive out hate: only love can do that."
                        },
                        new
                        {
                            QuoteId = 5,
                            Author = "Eleanor Roosevelt",
                            QuoteText = "Do one thing every day that scares you."
                        },
                        new
                        {
                            QuoteId = 6,
                            Author = "Benjamin Franklin",
                            QuoteText = "Well done is better than well said."
                        },
                        new
                        {
                            QuoteId = 7,
                            Author = "Helen Keller",
                            QuoteText = "The best and most beautiful things in the world cannot be seen or even touched - they must be felt with the heart."
                        },
                        new
                        {
                            QuoteId = 8,
                            Author = "Aristotle",
                            QuoteText = "It is during our darkest moments that we must focus to see the light."
                        },
                        new
                        {
                            QuoteId = 9,
                            Author = "Ralph Waldo Emerson",
                            QuoteText = "Do not go where the path may lead, go instead where there is no path and leave a trail."
                        },
                        new
                        {
                            QuoteId = 10,
                            Author = "Oscar Wilde",
                            QuoteText = "Be yourself; everyone else is already taken."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

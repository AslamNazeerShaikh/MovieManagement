﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManagement.DataAccess.Context;

#nullable disable

namespace MovieManagement.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GenreId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Aslam",
                            LastName = "Shaikh"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Tayyab",
                            LastName = "Shaikh"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Maksud",
                            LastName = "Shaikh"
                        });
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Biography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActorId")
                        .IsUnique();

                    b.ToTable("Biographies");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            Description = "Very Awesome",
                            Name = "Wakanda Forever"
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            Description = "Too Awesome",
                            Name = "SpiderMan Forever"
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 3,
                            Description = "Nice Awesome",
                            Name = "BatMan Forever"
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieManagement.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Biography", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entities.Actor", "Actor")
                        .WithOne("Biography")
                        .HasForeignKey("MovieManagement.Domain.Entities.Biography", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Movie", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Biography");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}

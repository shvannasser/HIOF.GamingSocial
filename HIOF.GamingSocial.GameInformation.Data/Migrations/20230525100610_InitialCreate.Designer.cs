﻿// <auto-generated />
using System;
using HIOF.GamingSocial.GameInformation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HIOF.GamingSocial.GameInformation.Data.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20230525100610_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HIOF.GamingSocial.GameInformation.Data.ProfileGameCollection", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("GameRating")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("ProfileId", "GameId");

                    b.ToTable("ProfileGameCollection");

                    b.HasData(
                        new
                        {
                            ProfileId = new Guid("5b98dd2e-33e9-49d0-8e6a-3c5a286a761c"),
                            GameId = 23
                        },
                        new
                        {
                            ProfileId = new Guid("58ed69d7-031d-4c8d-a636-3459afa19b46"),
                            GameId = 23
                        },
                        new
                        {
                            ProfileId = new Guid("5b98dd2e-33e9-49d0-8e6a-3c5a286a761c"),
                            GameId = 26
                        },
                        new
                        {
                            ProfileId = new Guid("cdd891fc-5bcc-491e-9aab-0c3d40bee349"),
                            GameId = 26
                        },
                        new
                        {
                            ProfileId = new Guid("d455ce99-45a4-4ee2-932f-5696a5c3b169"),
                            GameId = 135
                        },
                        new
                        {
                            ProfileId = new Guid("58ed69d7-031d-4c8d-a636-3459afa19b46"),
                            GameId = 135
                        },
                        new
                        {
                            ProfileId = new Guid("5f3a7799-5550-4151-a478-d45fbea29a8a"),
                            GameId = 26
                        },
                        new
                        {
                            ProfileId = new Guid("5f3a7799-5550-4151-a478-d45fbea29a8a"),
                            GameId = 135
                        });
                });

            modelBuilder.Entity("HIOF.GamingSocial.GameInformation.Data.VideoGameInformation", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("GameDescription")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GiantbombGuid")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("SteamAppId")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.ToTable("VideoGameInformation");
                });
#pragma warning restore 612, 618
        }
    }
}

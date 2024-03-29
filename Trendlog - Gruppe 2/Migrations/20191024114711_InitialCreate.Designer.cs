﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trendlog___Gruppe_2.Data;

namespace Trendlog___Gruppe_2.Migrations
{
    [DbContext(typeof(TrendlogContext))]
    [Migration("20191024114711_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trendlog___Gruppe_2.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Desc");

                    b.Property<int>("Elevation");

                    b.Property<string>("Email");

                    b.Property<int>("Lifetime");

                    b.Property<int>("Longitume");

                    b.Property<int>("MaxSize");

                    b.Property<string>("Name");

                    b.Property<int>("PCount");

                    b.Property<string>("Timezone");

                    b.Property<DateTime>("Updated");

                    b.HasKey("ChannelId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("Trendlog___Gruppe_2.Models.Feed", b =>
                {
                    b.Property<int>("FeedId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Alarm");

                    b.Property<string>("AlarmSettings");

                    b.Property<int?>("ChannelId");

                    b.Property<bool>("EnableAlarm");

                    b.Property<string>("Label");

                    b.Property<string>("Name");

                    b.Property<int>("Scale");

                    b.HasKey("FeedId");

                    b.HasIndex("ChannelId");

                    b.ToTable("Feeds");
                });

            modelBuilder.Entity("Trendlog___Gruppe_2.Models.Point", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FeedId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("Value");

                    b.HasKey("PointId");

                    b.HasIndex("FeedId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Trendlog___Gruppe_2.Models.Feed", b =>
                {
                    b.HasOne("Trendlog___Gruppe_2.Models.Channel")
                        .WithMany("FeedList")
                        .HasForeignKey("ChannelId");
                });

            modelBuilder.Entity("Trendlog___Gruppe_2.Models.Point", b =>
                {
                    b.HasOne("Trendlog___Gruppe_2.Models.Feed")
                        .WithMany("Points")
                        .HasForeignKey("FeedId");
                });
#pragma warning restore 612, 618
        }
    }
}

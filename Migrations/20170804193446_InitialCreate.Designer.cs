using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using weatherStationServer.Model;

namespace weatherStationServer.Migrations
{
    [DbContext(typeof(WSSContext))]
    [Migration("20170804193446_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("weatherStationServer.Model.WeatherData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Humidity");

                    b.Property<ushort>("StationId");

                    b.Property<double>("Temperature");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("weatherData");
                });
        }
    }
}

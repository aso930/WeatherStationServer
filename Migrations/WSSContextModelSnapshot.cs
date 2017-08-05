using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using weatherStationServer.Model;

namespace weatherStationServer.Migrations
{
    [DbContext(typeof(WSSContext))]
    partial class WSSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

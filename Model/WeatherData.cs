using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weatherStationServer.Model
{
    public class WeatherData
    {
        [Key]
        public Int64 Id { get; set; }
        public UInt16 StationId { get; set; }
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public WeatherData()
        {

        }

        public WeatherData(UInt16 sId, double temp, double hum)
        {
            this.StationId = sId;
            this.Timestamp = DateTime.UtcNow;
            this.Id = ((DateTimeOffset)Timestamp).ToUnixTimeSeconds() * 1000 + this.StationId;
            this.Temperature = temp;
            this.Humidity = hum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherStationServer.Model
{
    public class WeatherDataDTO
    {
        public UInt16 StationId { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}

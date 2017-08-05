using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherStationServer.Model
{
    interface IWeatherDataRepository : IDisposable
    {
        IEnumerable<WeatherData> GetAllById(UInt16 id);
        WeatherData GetMostRecentByStationId(UInt16 id);
        void InsertData(WeatherData wd);
        void DeleteDataById(UInt64 id);
        void UpdateData(WeatherData wd);
        void Save();
    }
}

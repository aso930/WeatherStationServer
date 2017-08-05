using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace weatherStationServer.Model
{
    public class WeatherDataRepository : IWeatherDataRepository, IDisposable
    {
        private WSSContext context;
        public WeatherDataRepository(WSSContext context)
        {
            this.context = context;
        }

        public void DeleteDataById(ulong id)
        {
            throw new NotImplementedException();
        }
        private bool disposed = false;

        public IEnumerable<WeatherData> GetAllById(UInt16 id)
        {
            throw new NotImplementedException();
        }

        public WeatherData GetMostRecentByStationId(UInt16 id)
        {
            return context.weatherData.Where(x => x.StationId == id).OrderByDescending(x => x.Timestamp).FirstOrDefault();
        }
        public void InsertData(WeatherData wd)
        {
            context.weatherData.Add(wd);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateData(WeatherData wd)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

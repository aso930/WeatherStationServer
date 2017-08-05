using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using weatherStationServer.Model;

namespace weatherStationServer.Controllers
{
    [Produces("application/json")]
    [Route("api/stations")]
    public class StationsController : Controller
    {
        private WeatherDataRepository repo;
        public StationsController()
        {
            this.repo = new WeatherDataRepository(new WSSContext());
        }
        // GET api/stations/5
        [HttpGet("{id}")]
        public IActionResult Get(UInt16 id)
        {
            WeatherData response;
            try
            {
                response = repo.GetMostRecentByStationId(id);
                return new ObjectResult(response);
            }
            catch(Exception e)
            {
                return new ObjectResult("Error: A problem occured.\nException info: " + e.Message );
            }           
        }
        // POST api/stations
        [HttpPost]
        public IActionResult Post([FromBody]WeatherDataDTO wd)
        {
            try
            {
                repo.InsertData(new WeatherData(wd.StationId, wd.Temperature, wd.Humidity));
                repo.Save();
                return Ok();
            }
            catch(Exception e)
            {
                return new ObjectResult("Error: A problem occured.\nException info: " + e.Message);
            }
            
        }
    }
}
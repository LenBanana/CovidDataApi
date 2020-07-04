using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_Data_API.Calculations;
using Corona_Data_API.DataManager;
using Corona_Data_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Corona_Data_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CovidDataSetController : ControllerBase
    {
        /// <summary>
        /// Returns complete set of all data available by countries ISO code
        /// </summary>
        /// <param name="iso_code">Countries ISO code</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DataSetByISO(string iso_code)
        {
            return Ok(CovidDataManager.covidCountries.Where(x => x.iso_code.ToLower() == iso_code.ToLower()));
        }

        /// <summary>
        /// Returns complete set of all data available by countries name
        /// </summary>
        /// <param name="location">Countries name</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DataSetByLocation(string location)
        {
            return Ok(CovidDataManager.covidCountries.Where(x => x.location.ToLower() == location.ToLower()));
        }


    }
}

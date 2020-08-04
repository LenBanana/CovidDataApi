using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Corona_Data_API.Calculations;
using Corona_Data_API.DataManager;
using Corona_Data_API.Models;
using Corona_Data_API.Extensions;
using Newtonsoft.Json;

namespace Corona_Data_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CovidDataPointsController : ControllerBase
    {

        /// <summary>
        /// Returns full configuration (without added sources) for each country available
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<DataConfig>), 200)]
        public IActionResult GetCountryConfigs()
        {
            try
            {
                return Ok(CovidDataManager.dataConfigs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(DataConfig), 200)]
        public IActionResult GetCountryConfig(string iso_code, string location)
        {
            try
            {
                iso_code += "|";
                location += "|";
                return Ok(new DataConfig() { iso_code = iso_code, location = location });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetCSVModel(string url)
        {
            try
            {
                List<object> obj = CovidCSVExtension.FromCSV<object>(url, CovidDataManager.csvConfig);
                if (obj == null || obj.Count == 0)
                    throw new Exception();
                var source = new AddedSource() { source = url, value = obj };
                return Ok(source);
            }
            catch (Exception)
            {
                try
                {
                    List<object> obj = CovidJSONExtension.FromJSON<object>(url);
                    if (obj == null || obj.Count == 0)
                        throw new Exception();
                    var source = new AddedSource() { source = url, value = obj };
                    return Ok(source);
                }
                catch (Exception ex)
                {
                    return StatusCode(400, "Error attempting to build object from CSV " + ex.Message);
                }
            }
        }

        [HttpPost]
        public IActionResult SaveCSV(string url, string iso_code, string location)
        {
            try
            {
                List<object> obj = CovidCSVExtension.FromCSV<object>(url, CovidDataManager.csvConfig);
                AddedExternalSource externalSource = new AddedExternalSource();
                externalSource.iso_code = iso_code.ToUpper();
                externalSource.location = location;
                externalSource.url = url;
                string path = System.IO.Directory.GetCurrentDirectory() + "\\sources.json";
                if (System.IO.File.Exists(path))
                {
                    string json = System.IO.File.ReadAllText(path);
                    CovidDataManager.externalSources.AddRange(new List<AddedExternalSource>().FromJson(json));
                }
                CovidDataManager.externalSources.Add(externalSource);
                System.IO.File.WriteAllText(path, CovidDataManager.externalSources.ToJson());
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, "Error attempting to save config to file " + ex.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult Cases(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.total_cases.HasValue, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.total_cases.Value;
                return chartValue;
            }).data);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult Deaths(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.total_deaths.HasValue, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.total_deaths.Value;
                return chartValue;
            }).data);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult NewTests(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.new_tests_smoothed.HasValue && x.new_tests_smoothed.Value > 0, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.new_tests_smoothed.Value;
                return chartValue;
            }).data);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult NewDeaths(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.new_deaths.HasValue, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.new_deaths.Value;
                return chartValue;
            }).data);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult NewCases(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.new_cases.HasValue, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.new_cases.Value;
                return chartValue;
            }).data);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CalcBasicPlot), 200)]
        public IActionResult NewCasesPerMillion(string iso_code, string location = null)
        {
            return Ok(new CalcBasicPlot(new DataConfig() { iso_code = iso_code, location = location }, x => x.new_cases_per_million.HasValue, y =>
            {
                DataPoint chartValue = new DataPoint();
                chartValue.caption = y.date.ToString("o");
                chartValue.value = y.new_cases_per_million.Value;
                return chartValue;
            }).data);
        }


        [HttpGet]
        [ProducesResponseType(typeof(BasicPlotData), 200)]
        public IActionResult CasePercentagePerCountry()
        {
            string day = DateTime.Now.ToString("yyyyMMdd");
            double? totalWorldCases = CovidDataManager.covidCountries.Where(x => x.total_cases.HasValue && x.date.ToString("yyyyMMdd") == day && x.location == "World").Select(x => x.total_cases.Value).FirstOrDefault();
            if (totalWorldCases.HasValue)
            {
                BasicPlotData data = new CalcBasicPlot(new DataConfig() { }, x => x.total_cases.HasValue && x.date.ToString("yyyyMMdd") == day && x.location != "World", y =>
                {
                    DataPoint chartValue = new DataPoint();
                    chartValue.caption = y.location + " - " + y.date.ToString("o");
                    chartValue.value = (y.total_cases.Value / totalWorldCases.Value) * 100.0;
                    return chartValue;
                }).data;
                data.info = new DataInfo("OWID_WRL");
                return Ok(data);
            }
            else
            {
                return StatusCode(204);
            }
        }
    }
}
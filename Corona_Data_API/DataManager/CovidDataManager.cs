using Corona_Data_API.CSVModels;
using Corona_Data_API.Extensions;
using Corona_Data_API.Models;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.DataManager
{
    public class CovidDataManager
    {
        public CovidDataManager()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\sources.json";
            externalSources = new List<AddedExternalSource>();
            if (System.IO.File.Exists(path))
            {
                string json = System.IO.File.ReadAllText(path);
                externalSources.AddRange(new List<AddedExternalSource>().FromJson(json));
            }

            CsvConfiguration config = new CsvConfiguration(new CultureInfo("en-US", false));
            config.HasHeaderRecord = true;
            config.IgnoreQuotes = false;
            config.IgnoreBlankLines = true;
            config.HeaderValidated = null;
            config.MissingFieldFound = null;
            config.RegisterClassMap<HopkinsDataClassMap>();
            config.RegisterClassMap<CovidGermanyStateClassMap>();
            config.RegisterClassMap<WhoClassMap>();
            config.AutoMap<CovidBrazilStates>();
            config.AutoMap<CovidUSStates>();
            config.AutoMap<RKIGeneral>();
            config.AutoMap<RKILandkreis>();
            csvConfig = config;
            UpdateData();

            hopkinsData = new List<HopkinsData>();
            UpdateHopkinsAndWHO();
        }

        public static List<CovidCountry> covidCountries { get; set; }
        public static CsvConfiguration csvConfig { get; set; }
        public static List<DataConfig> dataConfigs { get; set; }
        public static List<HopkinsData> hopkinsData { get; set; }
        public static List<WHOcountrys> whoData { get; set; }
        public static List<AddedExternalSource> externalSources { get; set; }

        public static string hopkinSource = "https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_daily_reports/";

        public static string whoSource = "https://covid19.who.int/WHO-COVID-19-global-data.csv";

        public async static void UpdateData()
        {
            try
            {
                string source = "https://covid.ourworldindata.org/data/owid-covid-data.csv";
                IEnumerable<CovidCountry> countries = CovidCSVExtension.FromCSV<CovidCountry>(source, csvConfig);
                if (countries != null)
                {
                    covidCountries = countries.ToList();
                    dataConfigs = covidCountries
                        .GroupBy(p => p.iso_code)
                        .Select(g => g.First())
                        .Select(x => new DataConfig { iso_code = x.iso_code, location = x.location, continent = x.continent }).ToList();
                }
            }
            catch { }
            await Task.Delay(TimeSpan.FromHours(1));
            UpdateData();
        }

        public async static void UpdateHopkinsAndWHO()
        {
            try
            {
                var date = DateTime.Now;
                string hopkinEnd = date.ToString("MM-dd-yyyy") + ".csv";
                string HopkinSource = "";
                while (!(new Uri(hopkinSource + hopkinEnd).Reachable()))
                {
                    date = date.AddDays(-1);
                    hopkinEnd = date.ToString("MM-dd-yyyy") + ".csv";
                    HopkinSource = hopkinSource + hopkinEnd;
                }
                DateTime maxDate = date.AddDays(-31);
                List<HopkinsData> newData = new List<HopkinsData>();
                while (new Uri(HopkinSource).Reachable() && date > maxDate)
                {
                    IEnumerable<HopkinsData> hopkinData = CovidCSVExtension.FromCSV<HopkinsData>(HopkinSource, csvConfig);
                    if (hopkinData != null)
                    {
                        newData.AddRange(hopkinData.ToList());
                    }
                    date = date.AddDays(-1);
                    hopkinEnd = date.ToString("MM-dd-yyyy") + ".csv";
                    HopkinSource = hopkinSource + hopkinEnd;
                }
                hopkinsData = newData;

                IEnumerable<WHOcountrys> whodata = CovidCSVExtension.FromCSV<WHOcountrys>(whoSource, csvConfig);
                if (whodata != null)
                    whoData = whodata.ToList();
            }
            catch (Exception ex) 
            {
                await Task.Delay(TimeSpan.FromMinutes(5));
                UpdateHopkinsAndWHO();
                return;
            }
            await Task.Delay(TimeSpan.FromHours(6));
            UpdateHopkinsAndWHO();
        }
    }
}

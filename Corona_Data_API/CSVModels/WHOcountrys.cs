using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.CSVModels
{
    public class WHOcountrys
    {
        public DateTime Date_reported { get; set; }
        public string Country_code { get; set; }
        public string Country { get; set; }
        public string WHO_region { get; set; }
        public int? New_cases { get; set; }
        public int? Cumulative_cases { get; set; }
        public int? New_deaths { get; set; }
        public int? Cumulative_deaths { get; set; }
    }

    public class WhoClassMap : ClassMap<WHOcountrys>
    {
        public WhoClassMap()
        {
            Map(m => m.Date_reported).Name("Date_reported");
            Map(m => m.Country_code).Name(" Country_code");
            Map(m => m.Country).Name(" Country");
            Map(m => m.WHO_region).Name(" WHO_region");
            Map(m => m.New_cases).Name(" New_cases");
            Map(m => m.Cumulative_cases).Name(" Cumulative_cases");
            Map(m => m.New_deaths).Name(" New_deaths");
            Map(m => m.Cumulative_deaths).Name(" Cumulative_deaths");
        }
    }
}

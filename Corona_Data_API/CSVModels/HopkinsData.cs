﻿using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.CSVModels
{
    public class HopkinsData
    {
        public int? FIPS { get; set; }
        public string Admin2 { get; set; }
        public string Province_State { get; set; }
        public string Country_Region { get; set; }
        public DateTime Last_Update { get; set; }
        public string Lat { get; set; }
        public string Long_ { get; set; }
        public int? Confirmed { get; set; }
        public int? Deaths { get; set; }
        public int? Recovered { get; set; }
        public int? Active { get; set; }
        public string Combined_Key { get; set; }
        public string Incidence_Rate { get; set; }
        public string Case_Fatality_Ratio { get; set; }
    }

    public class HopkinsDataClassMap : ClassMap<HopkinsData>
    {
        public HopkinsDataClassMap()
        {
            Map(m => m.FIPS).Name("FIPS");
            Map(m => m.Admin2).Name("Admin2");
            Map(m => m.Province_State).Name("Province_State");
            Map(m => m.Country_Region).Name("Country_Region");
            Map(m => m.Last_Update).Name("Last_Update");
            Map(m => m.Lat).Name("Lat");
            Map(m => m.Long_).Name("Long_");
            Map(m => m.Confirmed).Name("Confirmed");
            Map(m => m.Deaths).Name("Deaths");
            Map(m => m.Recovered).Name("Recovered");
            Map(m => m.Active).Name("Active");
            Map(m => m.Combined_Key).Name("Combined_Key");
            Map(m => m.Incidence_Rate).Name("Incidence_Rate");
            Map(m => m.Case_Fatality_Ratio).Name("Case-Fatality_Ratio");
        }
    }


}

using Corona_Data_API.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class CovidGermanyStates
    {
        public DateTime time_iso8601 { get; set; }
        public string source { get; set; }
        public int? DE_Baden_Württemberg_cases { get; set; }
        public int? DE_Baden_Württemberg_deaths { get; set; }
        public int? DE_Bayern_cases { get; set; }
        public int? DE_Bayern_deaths { get; set; }
        public int? DE_Berlin_cases { get; set; }
        public int? DE_Berlin_deaths { get; set; }
        public int? DE_Brandenburg_cases { get; set; }
        public int? DE_Brandenburg_deaths { get; set; }
        public int? DE_Bremen_cases { get; set; }
        public int? DE_Bremen_deaths { get; set; }
        public int? DE_Hamburg_cases { get; set; }
        public int? DE_Hamburg_deaths { get; set; }
        public int? DE_Hessen_cases { get; set; }
        public int? DE_Hessen_deaths { get; set; }
        public int? DE_Mecklenburg_Vorpommern_cases { get; set; }
        public int? DE_Mecklenburg_Vorpommern_deaths { get; set; }
        public int? DE_Niedersachsen_cases { get; set; }
        public int? DE_Niedersachsen_deaths { get; set; }
        public int? DE_Nordrhein_Westfalen_cases { get; set; }
        public int? DE_Nordrhein_Westfalen_deaths { get; set; }
        public int? DE_Rheinland_Pfalz_cases { get; set; }
        public int? DE_Rheinland_Pfalz_deaths { get; set; }
        public int? DE_Saarland_cases { get; set; }
        public int? DE_Saarland_deaths { get; set; }
        public int? DE_Sachsen_cases { get; set; }
        public int? DE_Sachsen_deaths { get; set; }
        public int? DE_Schleswig_Holstein_cases { get; set; }
        public int? DE_Schleswig_Holstein_deaths { get; set; }
        public int? DE_Sachsen_Anhalt_cases { get; set; }
        public int? DE_Sachsen_Anhalt_deaths { get; set; }
        public int? DE_Thueringen_cases { get; set; }
        public int? DE_Thueringen_deaths { get; set; }
        public int? sum_cases { get; set; }
        public int? sum_deaths { get; set; }
    }
}

public class CovidGermanyStateClassMap : ClassMap<CovidGermanyStates>
{
    public CovidGermanyStateClassMap()
    {
        Map(m => m.time_iso8601).Name("time_iso8601");
        Map(m => m.source).Name("source");
        Map(m => m.DE_Baden_Württemberg_cases).Name("DE-BW_cases");
        Map(m => m.DE_Baden_Württemberg_deaths).Name("DE-BW_deaths");
        Map(m => m.DE_Bayern_cases).Name("DE-BY_cases");
        Map(m => m.DE_Bayern_deaths).Name("DE-BY_deaths");
        Map(m => m.DE_Berlin_cases).Name("DE-BE_cases");
        Map(m => m.DE_Berlin_deaths).Name("DE-BE_deaths");
        Map(m => m.DE_Brandenburg_cases).Name("DE-BB_cases");
        Map(m => m.DE_Brandenburg_cases).Name("DE-BB_deaths");
        Map(m => m.DE_Bremen_cases).Name("DE-HB_cases");
        Map(m => m.DE_Bremen_deaths).Name("DE-HB_deaths");
        Map(m => m.DE_Hamburg_cases).Name("DE-HH_cases");
        Map(m => m.DE_Hamburg_deaths).Name("DE-HH_deaths");
        Map(m => m.DE_Hessen_cases).Name("DE-HE_cases");
        Map(m => m.DE_Hessen_deaths).Name("DE-HE_deaths");
        Map(m => m.DE_Mecklenburg_Vorpommern_cases).Name("DE-MV_cases");
        Map(m => m.DE_Mecklenburg_Vorpommern_deaths).Name("DE-MV_deaths");
        Map(m => m.DE_Niedersachsen_cases).Name("DE-NI_cases");
        Map(m => m.DE_Niedersachsen_deaths).Name("DE-NI_deaths");
        Map(m => m.DE_Nordrhein_Westfalen_cases).Name("DE-NW_cases");
        Map(m => m.DE_Nordrhein_Westfalen_deaths).Name("DE-NW_deaths");
        Map(m => m.DE_Rheinland_Pfalz_cases).Name("DE-RP_cases");
        Map(m => m.DE_Rheinland_Pfalz_deaths).Name("DE-RP_deaths");
        Map(m => m.DE_Saarland_cases).Name("DE-SL_cases");
        Map(m => m.DE_Saarland_deaths).Name("DE-SL_deaths");
        Map(m => m.DE_Sachsen_cases).Name("DE-SN_cases");
        Map(m => m.DE_Sachsen_deaths).Name("DE-SN_deaths");
        Map(m => m.DE_Schleswig_Holstein_cases).Name("DE-SH_cases");
        Map(m => m.DE_Schleswig_Holstein_deaths).Name("DE-SH_deaths");
        Map(m => m.DE_Sachsen_Anhalt_cases).Name("DE-ST_cases");
        Map(m => m.DE_Sachsen_Anhalt_deaths).Name("DE-ST_deaths");
        Map(m => m.DE_Thueringen_cases).Name("DE-TH_cases");
        Map(m => m.DE_Thueringen_deaths).Name("DE-TH_deaths");
        Map(m => m.sum_cases).Name("sum_cases");
        Map(m => m.sum_deaths).Name("sum_deaths");
    }
}


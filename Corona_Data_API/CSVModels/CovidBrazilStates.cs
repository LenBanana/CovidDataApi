using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace Corona_Data_API.Models
{
    public class CovidBrazilStates
    {
        public DateTime date { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int? newDeaths { get; set; }
        public int? deaths { get; set; }
        public int? newCases { get; set; }
        public int? totalCases { get; set; }
        public int? deathsMS { get; set; }
        public int? totalCasesMS { get; set; }
        public double? deaths_per_100k_inhabitants { get; set; }
        public double? totalCases_per_100k_inhabitants { get; set; }
        public double? deaths_by_totalCases { get; set; }
        public int? recovered { get; set; }
        public int? suspects { get; set; }
        public int? tests { get; set; }
        public double? tests_per_100k_inhabitants { get; set; }
    }
}

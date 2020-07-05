using CsvHelper.Configuration;
using System;

namespace Corona_Data_API.Models
{
    public class CovidUSStates
    {
        public DateTime date { get; set; }
        public string state { get; set; }
        public int? fips { get; set; }
        public int? cases { get; set; }
        public int? deaths { get; set; }
        public int? confirmed_cases { get; set; }
        public int? confirmed_deaths { get; set; }
        public int? probable_cases { get; set; }
        public int? probable_deaths { get; set; }
    }
}

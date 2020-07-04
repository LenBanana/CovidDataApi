using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class CovidCountry
    {
        public string iso_code { get; set; }
        public string continent { get; set; }
        public string location { get; set; }
        public DateTime date { get; set; }
        public double? total_cases { get; set; }
        public double? new_cases { get; set; }
        public double? total_deaths { get; set; }
        public double? new_deaths { get; set; }
        public double? total_cases_per_million { get; set; }
        public double? new_cases_per_million { get; set; }
        public double? total_deaths_per_million { get; set; }
        public double? new_deaths_per_million { get; set; }
        public double? total_tests { get; set; }
        public double? new_tests { get; set; }
        public double? total_tests_per_thousand { get; set; }
        public double? new_tests_per_thousand { get; set; }
        public double? new_tests_smoothed { get; set; }
        public double? new_tests_smoothed_per_thousand { get; set; }
        public string tests_units { get; set; }
        public string stringency_index { get; set; }
        public double? population { get; set; }
        public double? population_density { get; set; }
        public double? median_age { get; set; }
        public double? aged_65_older { get; set; }
        public double? aged_70_older { get; set; }
        public double? gdp_per_capita { get; set; }
        public double? extreme_poverty { get; set; }
        public double? cvd_death_rate { get; set; }
        public double? diabetes_prevalence { get; set; }
        public double? female_smokers { get; set; }
        public double? male_smokers { get; set; }
        public double? handwashing_facilities { get; set; }
        public double? hospital_beds_per_thousand { get; set; }
        public double? life_expectancy { get; set; }
    }

    public class CovidCountryClassMap : ClassMap<CovidCountry>
    {
        public CovidCountryClassMap()
        {
            Map(m => m.iso_code).Name("iso_code");
            Map(m => m.continent).Name("continent");
            Map(m => m.location).Name("location");
            Map(m => m.date).Name("date");
            Map(m => m.total_cases).Name("total_cases");
            Map(m => m.new_cases).Name("new_cases");
            Map(m => m.total_deaths).Name("total_deaths");
            Map(m => m.new_deaths).Name("new_deaths");
            Map(m => m.total_cases_per_million).Name("total_cases_per_million");
            Map(m => m.new_cases_per_million).Name("new_cases_per_million");
            Map(m => m.total_deaths_per_million).Name("total_deaths_per_million");
            Map(m => m.new_deaths_per_million).Name("new_deaths_per_million");
            Map(m => m.total_tests).Name("total_tests");
            Map(m => m.new_tests).Name("new_tests");
            Map(m => m.total_tests_per_thousand).Name("total_tests_per_thousand");
            Map(m => m.new_tests_per_thousand).Name("new_tests_per_thousand");
            Map(m => m.new_tests_smoothed).Name("new_tests_smoothed");
            Map(m => m.new_tests_smoothed_per_thousand).Name("new_tests_smoothed_per_thousand");
            Map(m => m.tests_units).Name("tests_units");
            Map(m => m.stringency_index).Name("stringency_index");
            Map(m => m.population).Name("population");
            Map(m => m.population_density).Name("population_density");
            Map(m => m.median_age).Name("median_age");
            Map(m => m.aged_65_older).Name("aged_65_older");
            Map(m => m.aged_70_older).Name("aged_70_older");
            Map(m => m.gdp_per_capita).Name("gdp_per_capita");
            Map(m => m.extreme_poverty).Name("extreme_poverty");
            Map(m => m.cvd_death_rate).Name("cvd_death_rate");
            Map(m => m.diabetes_prevalence).Name("diabetes_prevalence");
            Map(m => m.female_smokers).Name("female_smokers");
            Map(m => m.male_smokers).Name("male_smokers");
            Map(m => m.handwashing_facilities).Name("handwashing_facilities");
            Map(m => m.hospital_beds_per_thousand).Name("hospital_beds_per_thousand");
            Map(m => m.life_expectancy).Name("life_expectancy");
        }
    }
}

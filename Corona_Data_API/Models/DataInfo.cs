using Corona_Data_API.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class DataInfo
    {
        public DataInfo(string iso_code)
        {
            List<CovidCountry> values = CovidDataManager.covidCountries.Where(x => x.iso_code.ToLower() == iso_code.ToLower()).ToList();
            values.OrderBy(x => x.date);
            cases = values.Select(x => x.total_cases).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            deaths = values.Select(x => x.total_deaths).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            casesPerMillion = values.Select(x => x.total_cases_per_million).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            deathsPerMillion = values.Select(x => x.total_deaths_per_million).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            tests = values.Select(x => x.total_tests).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            testsPerThousand = values.Select(x => x.total_tests_per_thousand).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            population = values.Select(x => x.population).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            populationDensity = values.Select(x => x.population_density).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            medianAge = values.Select(x => x.median_age).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            agedOver65 = values.Select(x => x.aged_65_older).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            agedOver70 = values.Select(x => x.aged_70_older).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            gdpPerCapita = values.Select(x => x.gdp_per_capita).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            poverty = values.Select(x => x.extreme_poverty).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            deathrate = values.Select(x => x.cvd_death_rate).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            diabetesPrevalence = values.Select(x => x.diabetes_prevalence).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            femaleSmokers = values.Select(x => x.female_smokers).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            maleSmokers = values.Select(x => x.male_smokers).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            handwashingFacilities = values.Select(x => x.handwashing_facilities).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            hospitalBedsPerThousand = values.Select(x => x.hospital_beds_per_thousand).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
            lifeExpectancy = values.Select(x => x.life_expectancy).Where(x => x.HasValue && x.Value > 0).LastOrDefault();
        }

        public double? cases { get; set; }
        public double? deaths { get; set; }
        public double? casesPerMillion { get; set; }
        public double? deathsPerMillion { get; set; }
        public double? tests { get; set; }
        public double? testsPerThousand { get; set; }
        public double? population { get; set; }
        public double? populationDensity { get; set; }
        public double? medianAge { get; set; }
        public double? agedOver65 { get; set; }
        public double? agedOver70 { get; set; }
        public double? gdpPerCapita { get; set; }
        public double? poverty { get; set; }
        public double? deathrate { get; set; }
        public double? diabetesPrevalence { get; set; }
        public double? femaleSmokers { get; set; }
        public double? maleSmokers { get; set; }
        public double? handwashingFacilities { get; set; }
        public double? hospitalBedsPerThousand { get; set; }
        public double? lifeExpectancy { get; set; }
    }
}

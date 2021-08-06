using Corona_Data_API.DataManager;
using Corona_Data_API.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_Data_API.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Corona_Data_API.CSVModels;

namespace Corona_Data_API.Models
{
    public class DataConfig
    {
        public DataConfig()
        {
            datasource = "https://covid.ourworldindata.org/data/owid-covid-data.csv";
            addedSources = new List<AddedSource>();
            locationTranslationsHopkins.Add("United States", "US");
            locationTranslationsWHO.Add("United States", "United States of America");
            locationTranslationsWHO.Add("United Kingdom", "The United Kingdom");
        }

        string[] alternativeSource = { "DEU", "USA", "BRA" };
        string _iso_code { get; set; }

        public string iso_code
        {
            get { return _iso_code; }
            set
            {
                if (value != null)
                {
                    if (value.EndsWith("|"))
                    {
                        _iso_code = value.Remove(value.Length - 1).ToUpper();
                        if (alternativeSource.Contains(_iso_code))
                            GenerateData();

                        int idx = CovidDataManager.externalSources.FindIndex(x => x.iso_code == _iso_code);
                        if (idx != -1)
                        {
                            List<object> obj = CovidSerializerExtension.FromCSVURL<object>(CovidDataManager.externalSources[idx].url, CovidDataManager.csvConfig);
                            addedSources.Add(new AddedSource() { source = CovidDataManager.externalSources[idx].url + " - Data added by external person", value = obj });
                        }
                    }
                    else
                    {
                        _iso_code = value.ToUpper();
                    }
                }
            }
        }

        Dictionary<string, string> locationTranslationsHopkins = new Dictionary<string, string>();
        Dictionary<string, string> locationTranslationsWHO = new Dictionary<string, string>();
        string _location { get; set; }

        public string location
        {
            get { return _location; }
            set
            {
                if (value != null)
                {
                    if (value.EndsWith("|"))
                    {
                        _location = value.Remove(value.Length - 1);
                        addHopkinsAndWho(_location);
                    }
                    else
                    {
                        _location = value;
                    }
                }
            }
        }
        public string continent { get; set; }
        public string datasource { get; private set; }
        public List<AddedSource> addedSources { get; private set; }

        void addHopkinsAndWho(string loc)
        {
            string hopLoc = loc;
            if (locationTranslationsHopkins.Keys.Contains(loc))
                hopLoc = locationTranslationsHopkins[loc];

            var data = CovidDataManager.hopkinsData.Where(x => x.Country_Region.ToLower() == hopLoc.ToLower());
            if (data != null && data.Count() > 0)
            {
                addedSources.Add(new AddedSource() { source = CovidDataManager.hopkinSource + " - Data by the CSSE at Johns Hopkins University", value = data });
            }

            string whoLoc = loc;
            if (locationTranslationsWHO.Keys.Contains(loc))
                whoLoc = locationTranslationsWHO[loc];

            //var dataWHO = CovidDataManager.whoData.Where(x => x.Country.ToLower() == whoLoc.ToLower());
            //if (dataWHO != null && dataWHO.Count() > 0)
            //{
            //    addedSources.Add(new AddedSource() { source = CovidDataManager.whoSource + " - Data by the World Health Organization", value = dataWHO });
            //}
        }

        void GenerateData()
        {
            if (iso_code == "DEU")
            {
                string source = "https://raw.githubusercontent.com/jgehrcke/covid-19-germany-gae/master/data.csv";
                List<CovidGermanyStates> obj = CovidSerializerExtension.FromCSVURL<CovidGermanyStates>(source, CovidDataManager.csvConfig);
                addedSources.Add(new AddedSource() { source = source + " - RKI & Spiegel Online Datensatz von JGehrecke @GitHub", value = obj });

                string sourceRKI = "https://opendata.arcgis.com/datasets/917fc37a709542548cc3be077a786c17_0.csv";
                List<RKILandkreis> objRKI = CovidSerializerExtension.FromCSVURL<RKILandkreis>(sourceRKI, CovidDataManager.csvConfig);
                addedSources.Add(new AddedSource() { source = sourceRKI + " - Datensatz zu Landkreisen direkt vom Robert Koch Institut", value = objRKI });

                //string sourceRKIGeneral = "https://opendata.arcgis.com/datasets/dd4580c810204019a7b8eb3e0b329dd6_0.csv";
                //List<RKIGeneral> objRKIGeneral = CovidCSVExtension.FromCSV<RKIGeneral>(sourceRKIGeneral, CovidDataManager.csvConfig);
                //addedSources.Add(new AddedSource() { source = sourceRKIGeneral + " - Datensatz zu allgemeinen Daten direkt vom Robert Koch Institut", value = objRKIGeneral });
            }
            if (iso_code == "USA")
            {
                string source = "https://raw.githubusercontent.com/nytimes/covid-19-data/master/live/us-states.csv";
                List<CovidUSStates> obj = CovidSerializerExtension.FromCSVURL<CovidUSStates>(source, CovidDataManager.csvConfig);
                addedSources.Add(new AddedSource() { source = source + " - Dataset by New York Times", value = obj });
            }
            if (iso_code == "BRA")
            {
                string source = "https://raw.githubusercontent.com/wcota/covid19br/master/cases-brazil-states.csv";
                List<CovidBrazilStates> obj = CovidSerializerExtension.FromCSVURL<CovidBrazilStates>(source, CovidDataManager.csvConfig);
                addedSources.Add(new AddedSource() { source = source + " - Casos e óbitos confirmados por dia, utilizando informação oficial pelo Ministério da Saúde", value = obj });
            }
        }
    }
}

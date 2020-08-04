using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using CsvHelper;
using Corona_Data_API.Models;
using CsvHelper.Configuration;

namespace Corona_Data_API.Extensions
{
    public static class CovidJSONExtension
    {
        public static List<T> FromJSONURL<T>(string url) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36");
                using (Stream stream = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<T> countries = new List<T>();
                        string json = reader.ReadToEnd();
                        if (!json.StartsWith("["))
                        {
                            T country = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                            countries.Add(country);
                            return countries;
                        }
                        countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
                        return countries;
                    }
                }
            }
        }

        public static List<T> FromJSON<T>(string jsonContent) where T : new()
        {
            List<T> countries = new List<T>();
            string json = jsonContent;
            if (!json.StartsWith("["))
            {
                T country = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                countries.Add(country);
                return countries;
            }
            countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            return countries;
        }
    }
}

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
        public static List<T> FromJSON<T>(string url) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                using (Stream stream = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<T> countries = new List<T>();
                        string json = reader.ReadToEnd();
                        countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
                        return countries;
                    }
                }
            }
        }
    }
}

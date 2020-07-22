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
    public static class CovidCSVExtension
    {
        public static List<T> FromCSV<T>(string url, CsvConfiguration config) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                using (Stream stream = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<T> countries = new List<T>();
                        if (url.EndsWith("csv"))
                        {
                            using (var csv = new CsvReader(reader, config))
                            {
                                countries = csv.GetRecords<T>().ToList();
                                return countries;
                            }
                        }
                        else if (url.EndsWith("json"))
                        {
                            string json = reader.ReadToEnd();
                            countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
                        }
                        return countries;
                    }
                }
            }
        }
    }
}

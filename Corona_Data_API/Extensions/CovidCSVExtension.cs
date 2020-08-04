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
        public static List<T> FromCSVURL<T>(string url, CsvConfiguration config) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36");
                using (Stream stream = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<T> countries = new List<T>();
                        using (var csv = new CsvReader(reader, config))
                        {
                            countries = csv.GetRecords<T>().ToList();
                            return countries;
                        }
                    }
                }
            }
        }

        public static List<T> FromCSV<T>(string csvContent, CsvConfiguration config) where T : new()
        {
            using (StringReader reader = new StringReader(csvContent))
            {
                List<T> countries = new List<T>();
                using (var csv = new CsvReader(reader, config))
                {
                    try
                    {
                        countries = csv.GetRecords<T>().ToList();
                        return countries;
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }
                }
            }
        }
    }
}

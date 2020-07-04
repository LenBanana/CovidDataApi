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
                        using (var csv = new CsvReader(reader, config))
                        {
                            List<T> countries = csv.GetRecords<T>().ToList();
                            return countries;
                        }
                    }
                }
            }
        }
    }
}

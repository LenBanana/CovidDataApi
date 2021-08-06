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
using System.Xml.Serialization;

namespace Corona_Data_API.Extensions
{
    public static class CovidSerializerExtension
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
                        string json = reader.ReadToEnd();
                        return FromJSON<T>(json);
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

        public static List<T> FromXMLURL<T>(string url) where T : new()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36");
                using (Stream stream = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string json = reader.ReadToEnd();
                        return FromXML<T>(json);
                    }
                }
            }
        }

        public static List<T> FromXML<T>(string jsonContent) where T : new()
        {
            List<T> countries = new List<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(object));
            using (TextReader reader = new StringReader(jsonContent))
            {
                var test = (object)serializer.Deserialize(reader);
            }
            return countries;
        }
    }
}

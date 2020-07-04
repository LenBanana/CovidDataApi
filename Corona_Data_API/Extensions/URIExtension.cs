using ChoETL;
using Corona_Data_API.Helper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Corona_Data_API.Extensions
{
    public static class URIExtension
    {
        public static string DownloadString(this Uri url)
        {
            using(WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }

        public static JsonResult CSVAsJson(this Uri url)
        {
            string csv = url.DownloadString();
            StringBuilder json = new StringBuilder();
            using (var r = ChoCSVReader.LoadText(csv)
                .WithFirstLineHeader()
                //.QuoteAllFields()
                .Configure(c => c.Delimiter = ",")
                )
            {
                using (var w = new ChoJSONWriter(json))
                    w.Write(r);
            }       
            return new JsonResult((object)JsonConvert.SerializeObject(JsonConvert.DeserializeObject<object>(json.ToString()))) { ContentType = "application/json" };;//;
        }

        public static bool Reachable(this Uri url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 15000;
            request.Method = "HEAD"; // As per Lasse's comment
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}

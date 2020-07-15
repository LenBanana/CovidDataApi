using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class AddedExternalSource
    {
        public string iso_code { get; set; }
        public string location { get; set; }
        public string url { get; set; }
    }

    public static class AddedExternalSourceExtension
    {
        public static string ToJson(this List<AddedExternalSource> source) => Newtonsoft.Json.JsonConvert.SerializeObject(source);
        public static List<AddedExternalSource> FromJson(this List<AddedExternalSource> source, string json) => Newtonsoft.Json.JsonConvert.DeserializeObject<List<AddedExternalSource>>(json);
    }
}

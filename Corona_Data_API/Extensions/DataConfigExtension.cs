using Corona_Data_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Helper
{
    public static class DataConfigExtension
    {
        public static void Set(this DataConfig config, List<CovidCountry> values)
        {
            if (config.continent == null || config.continent.Length == 0)
                config.continent = values.First(x => x.continent.Length > 0).continent;
            if (config.iso_code == null || config.iso_code.Length == 0)
                config.iso_code = values.First(x => x.iso_code.Length > 0).iso_code;
            if (config.location == null || config.location.Length == 0)
                config.location = values.First(x => x.location.Length > 0).location;
        }
    }
}

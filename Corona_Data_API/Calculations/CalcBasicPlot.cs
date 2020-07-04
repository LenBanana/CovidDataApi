using Corona_Data_API.DataManager;
using Corona_Data_API.Helper;
using Corona_Data_API.Interfaces;
using Corona_Data_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Calculations
{
    public class CalcBasicPlot : IDataCalculator
    {
        public CalcBasicPlot(DataConfig Config, Func<CovidCountry, bool> _filter, Func<CovidCountry, DataPoint> _function)
        {
            filter = _filter;
            function = _function;
            config = Config;
            if (config.iso_code != null && config.iso_code.Length > 0)
                _values = CovidDataManager.covidCountries.Where(x => x.iso_code.ToLower() == config.iso_code.ToLower()).ToList();
            else if (config.location != null && config.location.Length > 0)
                _values = CovidDataManager.covidCountries.Where(x => x.location.ToLower() == config.location.ToLower()).ToList();

            if (_values == null || _values.Count == 0)
                _values = CovidDataManager.covidCountries.ToList();
            else
                config.Set(_values);
        }
        Func<CovidCountry, bool> filter { get; set; }
        Func<CovidCountry, DataPoint> function { get; set; }
        List<CovidCountry> _values { get; }
        public DataConfig config { get; set; }
        public BasicPlotData data { get => CalculateData(); }

        BasicPlotData CalculateData()
        {
            List<DataPoint> models = _values.Where(filter).Select(function).ToList();
            BasicPlotData data = new BasicPlotData();
            data.config = config;
            data.dataPoints = models;
            return data;
        }
    }
}

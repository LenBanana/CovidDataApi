using Corona_Data_API.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class BasicPlotData
    {
        DataConfig _config { get; set; }
        public DataConfig config { get { return _config; } set { _config = value; if (info == null && _config.iso_code != null) { info = new DataInfo(_config.iso_code); } } }
        public DataInfo info { get; set; }
        public List<DataPoint> dataPoints { get; set; }
    }
}

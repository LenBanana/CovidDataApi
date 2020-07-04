using Corona_Data_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Interfaces
{
    interface IDataCalculator
    {
        BasicPlotData data { get; }
        DataConfig config { get; set; }
    }
}

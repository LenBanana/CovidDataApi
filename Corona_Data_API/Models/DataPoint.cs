using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class DataPoint
    {
        public string caption { get; set; }
        public double value { get; set; }
        public bool selected { get; set; } = true;
    }
}

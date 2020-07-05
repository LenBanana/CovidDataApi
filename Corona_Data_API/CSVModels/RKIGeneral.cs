using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.CSVModels
{
    public class RKIGeneral
    {
        public int? ObjectId { get; set; }
        public int? IdBundesland { get; set; }
        public string Bundesland { get; set; }
        public string Landkreis { get; set; }
        public string Altersgruppe { get; set; }
        public string Geschlecht { get; set; }
        public int? AnzahlFall { get; set; }
        public int? AnzahlTodesfall { get; set; }
        public DateTime Meldedatum { get; set; }
        public int? IdLandkreis { get; set; }
        public string Datenstand { get; set; }
        public int? NeuerFall { get; set; }
        public int? NeuerTodesfall { get; set; }
        public DateTime Refdatum { get; set; }
        public int? NeuGenesen { get; set; }
        public int? AnzahlGenesen { get; set; }
        public int? IstErkrankungsbeginn { get; set; }
        public string Altersgruppe2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.CSVModels
{
    public class RKILandkreis
    {
        public int OBJECTID { get; set; }
        public int? ADE { get; set; }
        public int? GF { get; set; }
        public int? BSG { get; set; }
        public int RS { get; set; }
        public int? AGS { get; set; }
        public string SDV_RS { get; set; }
        public string GEN { get; set; }
        public string BEZ { get; set; }
        public int? IBZ { get; set; }
        public string BEM { get; set; }
        public string NBD { get; set; }
        public int? SN_L { get; set; }
        public int? SN_R { get; set; }
        public int? SN_K { get; set; }
        public int? SN_V1 { get; set; }
        public int? SN_V2 { get; set; }
        public int? SN_G { get; set; }
        public string FK_S3 { get; set; }
        public string NUTS { get; set; }
        public string RS_0 { get; set; }
        public int? AGS_0 { get; set; }
        public string WSK { get; set; }
        public int EWZ { get; set; }
        public string KFL { get; set; }
        public string DEBKG_ID { get; set; }
        public double death_rate { get; set; }
        public int cases { get; set; }
        public int deaths { get; set; }
        public double cases_per_100k { get; set; }
        public double cases_per_population { get; set; }
        public string BL { get; set; }
        public int BL_ID { get; set; }
        public string county { get; set; }
        public string last_update { get; set; }
        public double cases7_per_100k { get; set; }
        public string recovered { get; set; }
        public double SHAPE_Length { get; set; }
        public double SHAPE_Area { get; set; }
    }
}

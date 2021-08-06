using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_Data_API.Models
{
    public class WeatherData
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.accuweather.com", IsNullable = false)]
        public partial class adc_database
        {

            private adc_databaseUnits unitsField;

            private adc_databaseLocal localField;

            private adc_databaseCurrentconditions currentconditionsField;

            private adc_databasePlanets planetsField;

            private adc_databasePhase[] moonField;

            private adc_databaseForecast forecastField;

            private string copyrightField;

            private string useField;

            private string productField;

            private string redistributionField;

            /// <remarks/>
            public adc_databaseUnits units
            {
                get
                {
                    return this.unitsField;
                }
                set
                {
                    this.unitsField = value;
                }
            }

            /// <remarks/>
            public adc_databaseLocal local
            {
                get
                {
                    return this.localField;
                }
                set
                {
                    this.localField = value;
                }
            }

            /// <remarks/>
            public adc_databaseCurrentconditions currentconditions
            {
                get
                {
                    return this.currentconditionsField;
                }
                set
                {
                    this.currentconditionsField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanets planets
            {
                get
                {
                    return this.planetsField;
                }
                set
                {
                    this.planetsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("phase", IsNullable = false)]
            public adc_databasePhase[] moon
            {
                get
                {
                    return this.moonField;
                }
                set
                {
                    this.moonField = value;
                }
            }

            /// <remarks/>
            public adc_databaseForecast forecast
            {
                get
                {
                    return this.forecastField;
                }
                set
                {
                    this.forecastField = value;
                }
            }

            /// <remarks/>
            public string copyright
            {
                get
                {
                    return this.copyrightField;
                }
                set
                {
                    this.copyrightField = value;
                }
            }

            /// <remarks/>
            public string use
            {
                get
                {
                    return this.useField;
                }
                set
                {
                    this.useField = value;
                }
            }

            /// <remarks/>
            public string product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            public string redistribution
            {
                get
                {
                    return this.redistributionField;
                }
                set
                {
                    this.redistributionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseUnits
        {

            private string tempField;

            private string distField;

            private string speedField;

            private string presField;

            private string precField;

            /// <remarks/>
            public string temp
            {
                get
                {
                    return this.tempField;
                }
                set
                {
                    this.tempField = value;
                }
            }

            /// <remarks/>
            public string dist
            {
                get
                {
                    return this.distField;
                }
                set
                {
                    this.distField = value;
                }
            }

            /// <remarks/>
            public string speed
            {
                get
                {
                    return this.speedField;
                }
                set
                {
                    this.speedField = value;
                }
            }

            /// <remarks/>
            public string pres
            {
                get
                {
                    return this.presField;
                }
                set
                {
                    this.presField = value;
                }
            }

            /// <remarks/>
            public string prec
            {
                get
                {
                    return this.precField;
                }
                set
                {
                    this.precField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseLocal
        {

            private string cityField;

            private adc_databaseLocalAdminArea adminAreaField;

            private adc_databaseLocalCountry countryField;

            private decimal latField;

            private decimal lonField;

            private string timeField;

            private byte timeZoneField;

            private byte obsDaylightField;

            private byte currentGmtOffsetField;

            private string timeZoneAbbreviationField;

            /// <remarks/>
            public string city
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public adc_databaseLocalAdminArea adminArea
            {
                get
                {
                    return this.adminAreaField;
                }
                set
                {
                    this.adminAreaField = value;
                }
            }

            /// <remarks/>
            public adc_databaseLocalCountry country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public decimal lat
            {
                get
                {
                    return this.latField;
                }
                set
                {
                    this.latField = value;
                }
            }

            /// <remarks/>
            public decimal lon
            {
                get
                {
                    return this.lonField;
                }
                set
                {
                    this.lonField = value;
                }
            }

            /// <remarks/>
            public string time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }

            /// <remarks/>
            public byte timeZone
            {
                get
                {
                    return this.timeZoneField;
                }
                set
                {
                    this.timeZoneField = value;
                }
            }

            /// <remarks/>
            public byte obsDaylight
            {
                get
                {
                    return this.obsDaylightField;
                }
                set
                {
                    this.obsDaylightField = value;
                }
            }

            /// <remarks/>
            public byte currentGmtOffset
            {
                get
                {
                    return this.currentGmtOffsetField;
                }
                set
                {
                    this.currentGmtOffsetField = value;
                }
            }

            /// <remarks/>
            public string timeZoneAbbreviation
            {
                get
                {
                    return this.timeZoneAbbreviationField;
                }
                set
                {
                    this.timeZoneAbbreviationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseLocalAdminArea
        {

            private string codeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseLocalCountry
        {

            private string codeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseCurrentconditions
        {

            private string urlField;

            private string observationtimeField;

            private adc_databaseCurrentconditionsPressure pressureField;

            private byte temperatureField;

            private sbyte realfeelField;

            private string humidityField;

            private string weathertextField;

            private byte weathericonField;

            private byte windgustsField;

            private byte windspeedField;

            private decimal winddirectionField;

            private byte visibilityField;

            private decimal precipField;

            private adc_databaseCurrentconditionsUvindex uvindexField;

            private byte dewpointField;

            private string cloudcoverField;

            private byte apparenttempField;

            private byte windchillField;

            private string daylightField;

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            public string observationtime
            {
                get
                {
                    return this.observationtimeField;
                }
                set
                {
                    this.observationtimeField = value;
                }
            }

            /// <remarks/>
            public adc_databaseCurrentconditionsPressure pressure
            {
                get
                {
                    return this.pressureField;
                }
                set
                {
                    this.pressureField = value;
                }
            }

            /// <remarks/>
            public byte temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            public sbyte realfeel
            {
                get
                {
                    return this.realfeelField;
                }
                set
                {
                    this.realfeelField = value;
                }
            }

            /// <remarks/>
            public string humidity
            {
                get
                {
                    return this.humidityField;
                }
                set
                {
                    this.humidityField = value;
                }
            }

            /// <remarks/>
            public string weathertext
            {
                get
                {
                    return this.weathertextField;
                }
                set
                {
                    this.weathertextField = value;
                }
            }

            /// <remarks/>
            public byte weathericon
            {
                get
                {
                    return this.weathericonField;
                }
                set
                {
                    this.weathericonField = value;
                }
            }

            /// <remarks/>
            public byte windgusts
            {
                get
                {
                    return this.windgustsField;
                }
                set
                {
                    this.windgustsField = value;
                }
            }

            /// <remarks/>
            public byte windspeed
            {
                get
                {
                    return this.windspeedField;
                }
                set
                {
                    this.windspeedField = value;
                }
            }

            /// <remarks/>
            public decimal winddirection
            {
                get
                {
                    return this.winddirectionField;
                }
                set
                {
                    this.winddirectionField = value;
                }
            }

            /// <remarks/>
            public byte visibility
            {
                get
                {
                    return this.visibilityField;
                }
                set
                {
                    this.visibilityField = value;
                }
            }

            /// <remarks/>
            public decimal precip
            {
                get
                {
                    return this.precipField;
                }
                set
                {
                    this.precipField = value;
                }
            }

            /// <remarks/>
            public adc_databaseCurrentconditionsUvindex uvindex
            {
                get
                {
                    return this.uvindexField;
                }
                set
                {
                    this.uvindexField = value;
                }
            }

            /// <remarks/>
            public byte dewpoint
            {
                get
                {
                    return this.dewpointField;
                }
                set
                {
                    this.dewpointField = value;
                }
            }

            /// <remarks/>
            public string cloudcover
            {
                get
                {
                    return this.cloudcoverField;
                }
                set
                {
                    this.cloudcoverField = value;
                }
            }

            /// <remarks/>
            public byte apparenttemp
            {
                get
                {
                    return this.apparenttempField;
                }
                set
                {
                    this.apparenttempField = value;
                }
            }

            /// <remarks/>
            public byte windchill
            {
                get
                {
                    return this.windchillField;
                }
                set
                {
                    this.windchillField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string daylight
            {
                get
                {
                    return this.daylightField;
                }
                set
                {
                    this.daylightField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseCurrentconditionsPressure
        {

            private string stateField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseCurrentconditionsUvindex
        {

            private byte indexField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanets
        {

            private adc_databasePlanetsSun sunField;

            private adc_databasePlanetsMoon moonField;

            private adc_databasePlanetsMercury mercuryField;

            private adc_databasePlanetsVenus venusField;

            private adc_databasePlanetsMars marsField;

            private adc_databasePlanetsJupiter jupiterField;

            private adc_databasePlanetsSaturn saturnField;

            private adc_databasePlanetsUranus uranusField;

            private adc_databasePlanetsNeptune neptuneField;

            private adc_databasePlanetsPluto plutoField;

            /// <remarks/>
            public adc_databasePlanetsSun sun
            {
                get
                {
                    return this.sunField;
                }
                set
                {
                    this.sunField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsMoon moon
            {
                get
                {
                    return this.moonField;
                }
                set
                {
                    this.moonField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsMercury mercury
            {
                get
                {
                    return this.mercuryField;
                }
                set
                {
                    this.mercuryField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsVenus venus
            {
                get
                {
                    return this.venusField;
                }
                set
                {
                    this.venusField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsMars mars
            {
                get
                {
                    return this.marsField;
                }
                set
                {
                    this.marsField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsJupiter jupiter
            {
                get
                {
                    return this.jupiterField;
                }
                set
                {
                    this.jupiterField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsSaturn saturn
            {
                get
                {
                    return this.saturnField;
                }
                set
                {
                    this.saturnField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsUranus uranus
            {
                get
                {
                    return this.uranusField;
                }
                set
                {
                    this.uranusField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsNeptune neptune
            {
                get
                {
                    return this.neptuneField;
                }
                set
                {
                    this.neptuneField = value;
                }
            }

            /// <remarks/>
            public adc_databasePlanetsPluto pluto
            {
                get
                {
                    return this.plutoField;
                }
                set
                {
                    this.plutoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsSun
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsMoon
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsMercury
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsVenus
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsMars
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsJupiter
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsSaturn
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsUranus
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsNeptune
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePlanetsPluto
        {

            private string riseField;

            private string setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rise
            {
                get
                {
                    return this.riseField;
                }
                set
                {
                    this.riseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databasePhase
        {

            private string dateField;

            private string textField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseForecast
        {

            private string urlField;

            private adc_databaseForecastDay[] dayField;

            private adc_databaseForecastHour[] hourlyField;

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("day")]
            public adc_databaseForecastDay[] day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("hour", IsNullable = false)]
            public adc_databaseForecastHour[] hourly
            {
                get
                {
                    return this.hourlyField;
                }
                set
                {
                    this.hourlyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseForecastDay
        {

            private string urlField;

            private string obsdateField;

            private string daycodeField;

            private string sunriseField;

            private string sunsetField;

            private adc_databaseForecastDayDaytime daytimeField;

            private adc_databaseForecastDayNighttime nighttimeField;

            private byte numberField;

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            public string obsdate
            {
                get
                {
                    return this.obsdateField;
                }
                set
                {
                    this.obsdateField = value;
                }
            }

            /// <remarks/>
            public string daycode
            {
                get
                {
                    return this.daycodeField;
                }
                set
                {
                    this.daycodeField = value;
                }
            }

            /// <remarks/>
            public string sunrise
            {
                get
                {
                    return this.sunriseField;
                }
                set
                {
                    this.sunriseField = value;
                }
            }

            /// <remarks/>
            public string sunset
            {
                get
                {
                    return this.sunsetField;
                }
                set
                {
                    this.sunsetField = value;
                }
            }

            /// <remarks/>
            public adc_databaseForecastDayDaytime daytime
            {
                get
                {
                    return this.daytimeField;
                }
                set
                {
                    this.daytimeField = value;
                }
            }

            /// <remarks/>
            public adc_databaseForecastDayNighttime nighttime
            {
                get
                {
                    return this.nighttimeField;
                }
                set
                {
                    this.nighttimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseForecastDayDaytime
        {

            private string txtshortField;

            private string txtlongField;

            private byte weathericonField;

            private byte hightemperatureField;

            private sbyte lowtemperatureField;

            private byte realfeelhighField;

            private sbyte realfeellowField;

            private byte windspeedField;

            private decimal winddirectionField;

            private byte windgustField;

            private byte maxuvField;

            private decimal rainamountField;

            private decimal snowamountField;

            private decimal iceamountField;

            private decimal precipamountField;

            private byte tstormprobField;

            /// <remarks/>
            public string txtshort
            {
                get
                {
                    return this.txtshortField;
                }
                set
                {
                    this.txtshortField = value;
                }
            }

            /// <remarks/>
            public string txtlong
            {
                get
                {
                    return this.txtlongField;
                }
                set
                {
                    this.txtlongField = value;
                }
            }

            /// <remarks/>
            public byte weathericon
            {
                get
                {
                    return this.weathericonField;
                }
                set
                {
                    this.weathericonField = value;
                }
            }

            /// <remarks/>
            public byte hightemperature
            {
                get
                {
                    return this.hightemperatureField;
                }
                set
                {
                    this.hightemperatureField = value;
                }
            }

            /// <remarks/>
            public sbyte lowtemperature
            {
                get
                {
                    return this.lowtemperatureField;
                }
                set
                {
                    this.lowtemperatureField = value;
                }
            }

            /// <remarks/>
            public byte realfeelhigh
            {
                get
                {
                    return this.realfeelhighField;
                }
                set
                {
                    this.realfeelhighField = value;
                }
            }

            /// <remarks/>
            public sbyte realfeellow
            {
                get
                {
                    return this.realfeellowField;
                }
                set
                {
                    this.realfeellowField = value;
                }
            }

            /// <remarks/>
            public byte windspeed
            {
                get
                {
                    return this.windspeedField;
                }
                set
                {
                    this.windspeedField = value;
                }
            }

            /// <remarks/>
            public decimal winddirection
            {
                get
                {
                    return this.winddirectionField;
                }
                set
                {
                    this.winddirectionField = value;
                }
            }

            /// <remarks/>
            public byte windgust
            {
                get
                {
                    return this.windgustField;
                }
                set
                {
                    this.windgustField = value;
                }
            }

            /// <remarks/>
            public byte maxuv
            {
                get
                {
                    return this.maxuvField;
                }
                set
                {
                    this.maxuvField = value;
                }
            }

            /// <remarks/>
            public decimal rainamount
            {
                get
                {
                    return this.rainamountField;
                }
                set
                {
                    this.rainamountField = value;
                }
            }

            /// <remarks/>
            public decimal snowamount
            {
                get
                {
                    return this.snowamountField;
                }
                set
                {
                    this.snowamountField = value;
                }
            }

            /// <remarks/>
            public decimal iceamount
            {
                get
                {
                    return this.iceamountField;
                }
                set
                {
                    this.iceamountField = value;
                }
            }

            /// <remarks/>
            public decimal precipamount
            {
                get
                {
                    return this.precipamountField;
                }
                set
                {
                    this.precipamountField = value;
                }
            }

            /// <remarks/>
            public byte tstormprob
            {
                get
                {
                    return this.tstormprobField;
                }
                set
                {
                    this.tstormprobField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseForecastDayNighttime
        {

            private string txtshortField;

            private string txtlongField;

            private byte weathericonField;

            private byte hightemperatureField;

            private sbyte lowtemperatureField;

            private byte realfeelhighField;

            private sbyte realfeellowField;

            private byte windspeedField;

            private decimal winddirectionField;

            private byte windgustField;

            private byte maxuvField;

            private decimal rainamountField;

            private decimal snowamountField;

            private decimal iceamountField;

            private decimal precipamountField;

            private byte tstormprobField;

            /// <remarks/>
            public string txtshort
            {
                get
                {
                    return this.txtshortField;
                }
                set
                {
                    this.txtshortField = value;
                }
            }

            /// <remarks/>
            public string txtlong
            {
                get
                {
                    return this.txtlongField;
                }
                set
                {
                    this.txtlongField = value;
                }
            }

            /// <remarks/>
            public byte weathericon
            {
                get
                {
                    return this.weathericonField;
                }
                set
                {
                    this.weathericonField = value;
                }
            }

            /// <remarks/>
            public byte hightemperature
            {
                get
                {
                    return this.hightemperatureField;
                }
                set
                {
                    this.hightemperatureField = value;
                }
            }

            /// <remarks/>
            public sbyte lowtemperature
            {
                get
                {
                    return this.lowtemperatureField;
                }
                set
                {
                    this.lowtemperatureField = value;
                }
            }

            /// <remarks/>
            public byte realfeelhigh
            {
                get
                {
                    return this.realfeelhighField;
                }
                set
                {
                    this.realfeelhighField = value;
                }
            }

            /// <remarks/>
            public sbyte realfeellow
            {
                get
                {
                    return this.realfeellowField;
                }
                set
                {
                    this.realfeellowField = value;
                }
            }

            /// <remarks/>
            public byte windspeed
            {
                get
                {
                    return this.windspeedField;
                }
                set
                {
                    this.windspeedField = value;
                }
            }

            /// <remarks/>
            public decimal winddirection
            {
                get
                {
                    return this.winddirectionField;
                }
                set
                {
                    this.winddirectionField = value;
                }
            }

            /// <remarks/>
            public byte windgust
            {
                get
                {
                    return this.windgustField;
                }
                set
                {
                    this.windgustField = value;
                }
            }

            /// <remarks/>
            public byte maxuv
            {
                get
                {
                    return this.maxuvField;
                }
                set
                {
                    this.maxuvField = value;
                }
            }

            /// <remarks/>
            public decimal rainamount
            {
                get
                {
                    return this.rainamountField;
                }
                set
                {
                    this.rainamountField = value;
                }
            }

            /// <remarks/>
            public decimal snowamount
            {
                get
                {
                    return this.snowamountField;
                }
                set
                {
                    this.snowamountField = value;
                }
            }

            /// <remarks/>
            public decimal iceamount
            {
                get
                {
                    return this.iceamountField;
                }
                set
                {
                    this.iceamountField = value;
                }
            }

            /// <remarks/>
            public decimal precipamount
            {
                get
                {
                    return this.precipamountField;
                }
                set
                {
                    this.precipamountField = value;
                }
            }

            /// <remarks/>
            public byte tstormprob
            {
                get
                {
                    return this.tstormprobField;
                }
                set
                {
                    this.tstormprobField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.accuweather.com")]
        public partial class adc_databaseForecastHour
        {

            private byte weathericonField;

            private byte temperatureField;

            private sbyte realfeelField;

            private decimal precipField;

            private byte windspeedField;

            private string winddirectionField;

            private string txtshortField;

            private string obsdateField;

            private string mobileLinkField;

            private string timeField;

            /// <remarks/>
            public byte weathericon
            {
                get
                {
                    return this.weathericonField;
                }
                set
                {
                    this.weathericonField = value;
                }
            }

            /// <remarks/>
            public byte temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            public sbyte realfeel
            {
                get
                {
                    return this.realfeelField;
                }
                set
                {
                    this.realfeelField = value;
                }
            }

            /// <remarks/>
            public decimal precip
            {
                get
                {
                    return this.precipField;
                }
                set
                {
                    this.precipField = value;
                }
            }

            /// <remarks/>
            public byte windspeed
            {
                get
                {
                    return this.windspeedField;
                }
                set
                {
                    this.windspeedField = value;
                }
            }

            /// <remarks/>
            public string winddirection
            {
                get
                {
                    return this.winddirectionField;
                }
                set
                {
                    this.winddirectionField = value;
                }
            }

            /// <remarks/>
            public string txtshort
            {
                get
                {
                    return this.txtshortField;
                }
                set
                {
                    this.txtshortField = value;
                }
            }

            /// <remarks/>
            public string obsdate
            {
                get
                {
                    return this.obsdateField;
                }
                set
                {
                    this.obsdateField = value;
                }
            }

            /// <remarks/>
            public string mobileLink
            {
                get
                {
                    return this.mobileLinkField;
                }
                set
                {
                    this.mobileLinkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }
        }


    }
}

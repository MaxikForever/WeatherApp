using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_2._0
{
    internal class WeatherInfo
    {
        public class Sys
        {
            public string country
            {
                get;
                set;
            }
            public long sunrise
            {
                get;
                set;
            }

            public long sunset
            {
                get;
                set;
            }

        }

        public class Wind
        {
            public double speed
            {
                get;
                set;
            }
        }

        public class Main
        {
            public double temp
            {
                get;
                set;
            }
            public double feels_like
            {
                get;
                set;
            }

            public double humidity
            {
                get;
                set;
            }

        }

        public class Weather
        {
            public string icon
            {
                get;
                set;
            }
            public string main
            {
                get;
                set;
            }
        }

        public class Root
        {
            public  List<Weather> weather
            {
                get;
                set;
            }

            public Main main
            {
                get;
                set;
            }

            public Wind wind
            {
                get;
                set;
            }

            public Sys sys
            {
                get;
                set;
            }
        }

    }

}
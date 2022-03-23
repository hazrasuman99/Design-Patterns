using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class Converter
    {
        public static double ToFahrenheit(double celsius)
        {
            return (celsius * 9/5) +32;
        }

        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

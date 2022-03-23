using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 37; 
            double fahrenheit = 98.6;
            Console.WriteLine("Value of {0} celsius to fahrenheit is {1}", celsius, Converter.ToFahrenheit(celsius));
            Console.WriteLine("Value of {0} fahrenheit to celsius is {1}", fahrenheit, Converter.ToCelsius(fahrenheit));

            Console.ReadLine();
        }
    }
}

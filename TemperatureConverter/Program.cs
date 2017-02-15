using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double degF = 0;
            double eqF = 0;
            double degC = 0;
            double eqC = 0;

            Console.WriteLine("Please enter your temperature in degrees Celsius: ");
            string tempC = Console.ReadLine();
            degC = double.Parse(tempC);
            eqF = (degC * 1.8) + 32;
            Console.WriteLine($"Your temperature in degrees Fahrenheit is {eqF}");

            Console.WriteLine("Please enter your temperature in degrees Fahrenheit: ");
            string tempF = Console.ReadLine();
            degF = double.Parse(tempF);
            eqC = (degF - 32) / 1.8;
            Console.WriteLine($"Your temperature in degrees Celsius is {eqC}");

            Console.ReadLine();
        }
    }
}

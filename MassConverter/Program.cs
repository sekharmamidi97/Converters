using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = 0;
            double eqG = 0;
            double eqO = 0;
            double kilo = 0;
            double eqK = 0;
            double eqP = 0;
            double ounces = 0;
            double grams = 0;

            Console.WriteLine("Please enter your mass in ounces: ");
            string massInOunces = Console.ReadLine();
            ounces = double.Parse(massInOunces);
            eqG = ounces * 28.35;
            Console.WriteLine($"Your mass in grams is {eqG}");
            Console.WriteLine("Please enter your mass in grams: ");
            string massInGrams = Console.ReadLine();
            grams = double.Parse(massInGrams);
            eqO = grams / 28.35;
            Console.WriteLine($"Your mass in ounces is {eqO}");

            Console.WriteLine("Please enter your mass in pounds: ");
            string massInPounds = Console.ReadLine();
            pounds = double.Parse(massInPounds);
            eqK = pounds * 0.4536;
            Console.WriteLine($"Your mass in kilograms is {eqK}");
            Console.WriteLine("Please enter your mass in kilograms: ");
            string massInKilo = Console.ReadLine();
            kilo = double.Parse(massInKilo);
            eqP = kilo / 0.4536;
            Console.WriteLine($"Your mass in pounds is {eqP}");


            Console.ReadLine();

        }
    }
}

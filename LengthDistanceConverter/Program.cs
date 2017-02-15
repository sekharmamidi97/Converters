using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthDistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 0;
            double miles = 0;
            double eqK = 0;
            double eqM = 0;

            Console.WriteLine("Please enter the number of miles: ");
            string numberOfMiles = Console.ReadLine();
            miles = double.Parse(numberOfMiles);
            eqK = 1.61 * miles;
            Console.WriteLine($"Your distance in kilometers is {eqK}");
            Console.WriteLine("Please enter the number of kilometers: ");
            string numberOfKm = Console.ReadLine();
            km = double.Parse(numberOfKm);
            eqM = km / 1.61;
            Console.WriteLine($"Your distance in miles is {eqM}");

            double inches = 0;
            double cm = 0;
            double eqI = 0;
            double eqC = 0;

            Console.WriteLine("Please enter the number of inches: ");
            string numberOfIn = Console.ReadLine();
            inches = double.Parse(numberOfIn);
            eqC = inches * 2.54;
            Console.WriteLine($"Your length in centimeters is {eqC}");
            Console.WriteLine("Please enter the number of centimeters: ");
            string numberOfCm = Console.ReadLine();
            cm = double.Parse(numberOfCm);
            eqI = cm / 2.54;
            Console.WriteLine($"Your length in inches is {eqI}");

            double feet = 0;
            double meters = 0;
            double eqF = 0;
            double eqMe = 0;

            Console.WriteLine("Please enter the number of feet: ");
            string numberOfFeet = Console.ReadLine();
            feet = double.Parse(numberOfFeet);
            eqMe = feet * 0.305;
            Console.WriteLine($"Your length in meters is {eqMe}");
            Console.WriteLine("Please enter the number of meters: ");
            string numberOfMeters = Console.ReadLine();
            meters = double.Parse(numberOfMeters);
            eqF = meters / 0.305;
            Console.WriteLine($"Your length in feet is {eqF}");

            Console.ReadLine();
        }
    }
}

using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What up, G? Welcome to my Temp Converter application.");
            Console.WriteLine("Gone head and enter a temp in Fahrenheit to convert dat shiz to Celsius, yo.");

            double f = double.Parse(Console.ReadLine());
            Console.WriteLine($"Word. So the temp in Celsius is : {TempConverter.FahrenheitToCelsius(f)}.");


            Console.WriteLine("Aight, dawg. Now gone and enter a temp in Celsius to convert to Fahrenheit and all dat. ");


            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Bet it up. The temp in Fahrenheit is : {TempConverter.CelsiusToFahrenheit(c)}.");
            

            Console.WriteLine($"Nice, my brotha. So we got {TempConverter.FahrenheitToCelsius(f)} for the first and {TempConverter.CelsiusToFahrenheit(c)} for the second.\n Rinse and repeat as necessary, yo.\n I'm out dis mf.");



        }
    }
}

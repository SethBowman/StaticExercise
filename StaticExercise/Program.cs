using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user. Welcome to my Temp Converter application.");
            Console.WriteLine("Please enter a temp in Fahrenheit to convert into Celsius.");

            double f = double.Parse(Console.ReadLine());
            Console.WriteLine($"You temp in Celsius is : {TempConverter.FahrenheitToCelsius(f)}.");


            Console.WriteLine("Now, please enter a temp in Celsius to convert into Fahrenheit. ");


            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your temp in Fahrenheit is : {TempConverter.CelsiusToFahrenheit(c)}.");
            

            Console.WriteLine($"We have your tmeps as {TempConverter.FahrenheitToCelsius(f)} for the first and {TempConverter.CelsiusToFahrenheit(c)} for the second.\n End program.");



        }
    }
}

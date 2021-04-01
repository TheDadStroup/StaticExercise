using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


          var celsius =  TempConverter.FahrenheitToCelsius(68);
          var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.WriteLine($"celcius {celsius}");


        }
    }
}

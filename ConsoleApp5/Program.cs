using System;

class CelsiusProgram
{
    static void Main()
    {
        Console.Write("Enter Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("Kelvin: " + kelvin);
        Console.WriteLine("Fahrenheit: " + fahrenheit);
    }
}
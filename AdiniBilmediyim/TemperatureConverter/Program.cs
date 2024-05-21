namespace TemperatureConverter
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derece daxil edin");
            double celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Derece daxil edin");
            double fahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{celsius} Celsius, {TemperatureConverter.CelsiusToFahrenheit(celsius)} Fahrenheit'e beraberdir.");
            Console.WriteLine($"{fahrenheit} Fahrenheit, {TemperatureConverter.FahrenheitToCelsius(fahrenheit)} Celsius'e beraberdir.");
        }
    }
}


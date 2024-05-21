namespace Traffic
{
    public enum Color
    {
        Red,
        Yellow,
        Green
    }
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            Console.WriteLine("Initial Traffic Light Color: " + trafficLight.CurrentColor);
            trafficLight.ChangeNextColor();
            Console.WriteLine("Next Traffic Light Color: " + trafficLight.CurrentColor);
            trafficLight.ChangeNextColor();
            Console.WriteLine("Next Traffic Light Color: " + trafficLight.CurrentColor);
            trafficLight.ChangeNextColor();
            Console.WriteLine("Next Traffic Light Color: " + trafficLight.CurrentColor);
        }
    }
}
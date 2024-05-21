namespace Vehicle;

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();
        Console.WriteLine(car.GetDetails());
        car.Stop();

        Bus bus = new Bus();
        bus.Start();
        Console.WriteLine(bus.GetDetails());
        bus.Stop();

        Motocycle motocycle = new Motocycle();
        motocycle.Start();
        Console.WriteLine(motocycle.GetDetails());
        motocycle.Stop();
    }
}




namespace Vehicle
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped"); 
        }
        public string GetDetails()
        {
            return "Car: Four passengers.";
        }

    }
}

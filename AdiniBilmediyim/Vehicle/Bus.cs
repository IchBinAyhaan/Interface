

namespace Vehicle
{
    internal class Bus : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bus started");
        }
        public void Stop()
        {
            Console.WriteLine("Bus stopped");
        }
        public string GetDetails()
        {
            return "Bus: 60 passengers.";
        }
    }
}


namespace Vehicle
{
    internal class Motocycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motocycle started");
        }
        public void Stop()
        {
            Console.WriteLine("Motocycle stopped");
        }
        public string GetDetails()
        {
            return "Motocycle: 2 passengers.";
        }
    }
}



namespace Traffic
{
    internal class TrafficLight
    {
        public Color CurrentColor { get; private set; }

        public TrafficLight()
        {
            CurrentColor = Color.Red;
        }

        public void ChangeNextColor()
        {
            switch (CurrentColor)
            {
                case Color.Red:
                    CurrentColor = Color.Green;
                    break;
                case Color.Yellow:
                    CurrentColor = Color.Red;
                    break;
                case Color.Green:
                    CurrentColor = Color.Yellow;
                    break;
                default:
                    Console.WriteLine("Invalid traffic light color.");
                    break;
            }
        }
    }
}

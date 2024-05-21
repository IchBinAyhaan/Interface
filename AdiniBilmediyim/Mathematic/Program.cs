namespace Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 17;
            bool isPrime = MathUtils.IsPrime(num);

            if (isPrime)
            {
                Console.WriteLine($"{num} is prime.");
            }
               
            else
            {
                Console.WriteLine($"{num} is not prime.");
            }
                
        }
    }
}
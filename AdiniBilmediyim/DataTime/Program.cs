namespace DataTime
{
    class Program
    {
        static void Main()
        {
            DateTime birthDate = new DateTime(1991, 5, 15);
            int age = birthDate.GetAge();

            Console.WriteLine($"Doğum tarihi: {birthDate.ToShortDateString()}, Yaş: {age}");
        }
    }
}


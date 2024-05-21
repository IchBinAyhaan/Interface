namespace User
{
    public enum RegistrationMonth
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ayhan", "Qasimli", RegistrationMonth.May, "3D83JX6");
            Console.WriteLine(user1.GetDetails());

            User user2 = new User("Lale", "Ibrahimova", RegistrationMonth.August, "aBC1234");
            Console.WriteLine(user2.GetDetails());


        }
    }
}

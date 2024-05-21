
public enum Months : int
{
    Yanvar=1,
    Fevral,
    Mart,
    Aprel,
    May,
    Iyun,
    Iyul,
    Avqust,
    Sentyabr,
    Oktyabr,
    Noyabr,
    Dekabr
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir eded daxil edin");
        int months = Convert.ToInt32(Console.ReadLine());
        switch (months)
        {
            case (int)Months.Yanvar:
                Console.WriteLine("Bu qis ayidir");
                break;
            case (int)Months.Fevral:
                Console.WriteLine("Bu qis ayidir");
                break;
            case (int)Months.Mart:
                Console.WriteLine("Bu yaz ayidir");
                break;
            case (int)Months.Aprel:
                Console.WriteLine("Bu yaz ayidir");
                break;
            case (int)Months.May:
                Console.WriteLine("Bu yaz ayidir");
                break;
            case (int)Months.Iyun:
                Console.WriteLine("Bu yay ayidir");
                break;
            case (int)Months.Iyul:
                Console.WriteLine("Bu yay ayidir");
                break;
            case (int)Months.Avqust:
                Console.WriteLine("Bu yay ayidir");
                break;
            case (int)Months.Sentyabr:
                Console.WriteLine("Bu payiz ayidir");
                break;
            case (int)Months.Oktyabr:
                Console.WriteLine("Bu payiz ayidir");
                break;
            case (int)Months.Noyabr:
                Console.WriteLine("Bu payiz ayidir");
                break;
            case (int)Months.Dekabr:
                Console.WriteLine("Bu qis ayidir");
                break;

        }
    }
}
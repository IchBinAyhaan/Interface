using AdiniBilmediyim;

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();

        Console.Write("first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("operation: (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = calculator.PerformOperation(num1, num2, operation);
        Console.WriteLine($"Result: {result}");
    }
}
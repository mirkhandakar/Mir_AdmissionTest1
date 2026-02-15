using Task1;

class Program
{
    static void Main(string[] args)
    {        
        int[] numbers = { 10, 20, 30, 40, 50 };
        
        double result = numbers.Calculate(x => (double)x);

        double toDoubleResult = result * 2;

        Console.WriteLine($"The double result is: {toDoubleResult}");
    }
}

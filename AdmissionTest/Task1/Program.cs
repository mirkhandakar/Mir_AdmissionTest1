using Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Original to Doubled");

        foreach (int num in numbers)
        {
            int[] tempArray = { num };

            double doubled = tempArray.Calculate(x => (double)x * 2);

            Console.WriteLine($"{num} → {doubled}");
        }
    }
}

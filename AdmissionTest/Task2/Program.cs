using Task2;

class Program
{
    // Move the event handlers HERE, inside the Program class
    static void OnHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Event: Bulb turned ON!");
    }

    static void OffHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Event: Bulb turned OFF!");
    }

    static void Main(string[] args)
    {
        {
            Bulb bulb = new Bulb();

            // Using named methods as delegates
            bulb.On += new EventHandler(OnHandler);
            bulb.Off += new EventHandler(OffHandler);

            bulb.TurnOn();
            bulb.TurnOff();
        }
    }
}
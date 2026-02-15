using Task2;

class Program
{
   
    static void Main(string[] args)
    {
        {            
            Bulb bulb = new Bulb();
                        
            bulb.On += (sender, e) => Console.WriteLine("Event: Bulb turned ON!");
            bulb.Off += (sender, e) => Console.WriteLine("Event: Bulb turned OFF!");
                        
            bulb.TurnOn();
            bulb.TurnOff();
        }

    }
}
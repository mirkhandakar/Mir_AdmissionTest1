using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public event EventHandler On;
        public event EventHandler Off;

        public void TurnOn()
        {
            Console.WriteLine("Bulb is on");
            On?.Invoke(this, EventArgs.Empty);
        }

        public void TurnOff()
        {
            Console.WriteLine("Bulb is off");
            Off?.Invoke(this, EventArgs.Empty);
        }
    }
}

using System;
using ClassLibrary;

namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // Create a Log object and tell it
            // to subscribe to the clock
            LogClock lc = new LogClock();
            lc.Subscribe(theClock);

            // Get the clock started
            theClock.Run();
        }
    }
}

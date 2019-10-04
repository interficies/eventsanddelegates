using System;
namespace ClassLibrary
{
    // An observer. DisplayClock subscribes to the
    // clock's events. The job of DisplayClock is
    // to display the current time

    public class DisplayClock
    {
        
        // Given a clock, subscribe to
        // its SecondChangeHandler event
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChange +=
                new Clock.SecondChangeHandler(TimeHasChanged);
        }

        // The method that implements the
        // delegated functionality
        public void TimeHasChanged(
            object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}",
                ti.hour.ToString(),
                ti.minute.ToString(),
                ti.second.ToString());
        }
        
    }
}

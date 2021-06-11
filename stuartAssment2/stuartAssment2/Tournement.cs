using System;
using System.Collections.Generic;
using System.Text;

namespace stuartAssment2
{
    class Tournement
    {
        string tournementName;
        List<Event> events =new List<Event>();

        public void addEvent(Event e)
        {
            if (events.Count >= 5)
            {
                Console.WriteLine("Team is Full"); }
            else
            {
                events.Add(e);
            }
        }
    }
}

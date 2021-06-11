using System;
using System.Collections.Generic;
using System.Text;

namespace stuartAssment2
{
    class Event
    {
        string eventName;
        List<string> types = new List<string>();
        string type;

        public Event()
        {
            types.Add("academic");
            types.Add("sporting");
        }

        public void setType(String s)
        {
            if (types.Contains(s))
            {
               type = s;
            } else
            {
                Console.WriteLine("This is not a valid type");
            }
        }
    }
}

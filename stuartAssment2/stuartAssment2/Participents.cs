using System;
using System.Collections.Generic;
using System.Text;

namespace stuartAssment2
{
    class Participents
    {
        string personname;

        public void setName(String s)
        {
            this.personname = s;
        }

        public string getName()
        {
            return personname;
        }

        public void printParticipent()
        {
            Console.WriteLine("A participent called " + personname);
        }
    }
}


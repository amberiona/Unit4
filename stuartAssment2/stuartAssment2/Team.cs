using System;
using System.Collections.Generic;
using System.Text;

namespace stuartAssment2
{
    class Team
    {
        string teamname;
        List<Participents> members = new List<Participents>();

        public void setName(String s)
        {
            this.teamname = s;
        }

        public string getName()
        {
            return teamname;
        }

        public void addParticipent(Participents p)
        {
            members.Add(p);
        }

        public void printTeam()
        {
            Console.WriteLine("A team called " + teamname);
            Console.WriteLine(" It has the following memebers: ");
            for (int i=0; i<members.Count; i++)
            {
                members[i].printParticipent();
            }
        }
    }
}

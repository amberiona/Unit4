using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class tournament
    {
        string tournamentname;
        List<Events> events =new List<Events>();
        List<Participant> participants = new List<Participant>();
        List<Team> teams = new List<Team>();
        string Participantname;

        public void addEvent(Events e)
        {
            if (events.Count >= 5)
            {
                Console.WriteLine("Too many teams");
            }
            else
            {
                events.Add(e);
            }
        }

        public void addParticipant(Participant p)
        {
            int numberOfParticipants = participants.Count;
            if (numberOfParticipants == 20)
            {
                Console.WriteLine("There is no space for a new participant");
            } else
            {
                Console.WriteLine("There are " + numberOfParticipants + " participants");
                participants.Add(p);
            }
        }

        public void addTeam(Team t)
        {
            int numberOfTeams = teams.Count;
            if (numberOfTeams == 4)
            {
                Console.WriteLine("There is no space for a new team");
            }
            else
            {
                Console.WriteLine("There are " + numberOfTeams + " teams");
                Teams.Add(t);
            }
        }

        public void setName(string s)
        {
            this.eventname = s;
        }

        public string getEvent()
        {
            return eventname;
        }

        public void printTournament()
        {
            for (int i = 0; i < events.Count; i++)
            {
               // events[i].printEvent();
            }
        }
    }

}

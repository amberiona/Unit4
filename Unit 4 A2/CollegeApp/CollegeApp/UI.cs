using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class UI
    {
        public void MainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Enter a new participant");
                Console.WriteLine("2 - Enter a new team");
                Console.WriteLine("3 - Enter a new event");
                Console.WriteLine("4 - Enter a new tournamnet");
                Console.WriteLine("------------------------------");
                Console.WriteLine("5 - Add participant to team");
                Console.WriteLine("6 - Add team to event");
                Console.WriteLine("7 - Add event to tournament");
                Console.WriteLine("or type quit");
                choice = Console.Readline();
                switch (choice)

                {
                    case "1":
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Participant p = new Participant();
                        p.setName(name);
                        p.printParticipant();
                        break;

                    case "2":
                        Console.WriteLine("Enter Team Name: ");
                        string teamName = Console.ReadLine();
                        Team t = new Team();
                        t.setName(teamName);
                        t.printTeam();
                        allTeams.Add(t);
                        break;

                    case "3":
                        Console.WriteLine("Event Name:  ");
                        string eventName = Console.ReadLine();
                        Console.WriteLine("Enter Type: ");
                        string eventType = Console.ReadLine();
                        Events e = new Events();
                        e.setName(eventName);
                        e.setType(eventType);
                        e.printEvent();
                        break;

                    case "4":
                        Console.WriteLine("Enter Tournament Name: ");
                        string tournamentName = Console.ReadLine();
                        tournamnet o = new tournament();
                        o.setName(tournamentName);
                        o.printTournamnetName();
                        o.printTournament();
                        break;

                    case "5":
                        teamName teamSelected = allTeams[selectTeam()];
                        Participant partSelected = allParticipants[selectParticipants()];
                        teamSelected.addParticipant(partSelected);
                        teamSelected.printTeam();
                        partSelected.printParticipant();
                        break;

                    case "6":
                        teamSelected = allTeam[selectTeam()];
                        Events eventSelected = allEvents[selectEvent()];
                        eventSelected.AddTeam(allTeams[selectTeam()]);
                        eventSelected.printEvent();
                        teamSelected.printTeam();
                        break;

                    case "7":
                        eventSelected = allEvents[selectEvent()];
                        tournament tournamnetSelected = allTournaments[selectTournament()];
                        tournamentSelected.addEvent(allEvents[selectEvent()]);
                        tournamnetSelected.printTournament();
                        eventSelected.printEvent();
                        break;

                }
            }

        }
    }
}
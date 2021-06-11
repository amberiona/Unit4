using System;

namespace stuartAssment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            t.setName("James' Team");
            t.printTeam();
            Participents p = new Participents();
            p.setName("Amber");
            p.printParticipent();


            p = new Participents();
            p.setName("James");
            p.printParticipent();

        }
    }
}

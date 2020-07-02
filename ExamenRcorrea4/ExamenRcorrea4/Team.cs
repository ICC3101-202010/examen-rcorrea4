using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    class Team
    {
        private string teamName;
        private Player[] players = new Player[15];
        private Player[] playing = new Player[11];
        private Coach coach;
        private Doctor doctor;
        private bool national;
        private string nation;
        //national==true--> national
        //naional==false-->liga

        public string TeamName { get => teamName; set => teamName = value; }
        public bool National { get => national; set => national = value; }
        internal Player[] Players { get => players; set => players = value; }
        internal Player[] Playing { get => playing; set => playing = value; }
        internal Coach Coach { get => coach; set => coach = value; }
        internal Doctor Doctor { get => doctor; set => doctor = value; }
        public string Nation { get => nation; set => nation = value; }

        public Team(string teamName,bool national, Player[] players, Player[] playingPlayers,Coach coach, Doctor doctor, string nation)
        {
            this.teamName = teamName;
            this.national = national;
            this.players = players;
            this.playing = playingPlayers;
            this.coach = coach;
            this.doctor = doctor;
            this.nation = nation;
        }

        
        public void info()
        {
            Console.WriteLine("Team name: "+ teamName);
            if (national == true)
            {
                Console.WriteLine("Type: National");
            }
            else
            {
                Console.WriteLine(" Type: Ligue");
            }
            Console.WriteLine("Players: ");
            foreach (Player p in players)
            {
                Console.WriteLine(p.completeName + p.Number);
            }
            Console.WriteLine("Coach: "+ coach.completeName);
            Console.WriteLine("Doctor: "+ doctor.completeName);
        }
        public bool verifyPlayerNations()//verifica si todos los jugadores son de la misma nacionalidad que el equipo
        {
            
            bool result = true;
            foreach (Player p in players)
            {
                
                if (p.Nationality != nation)
                {
                    result = false;
                }
                
            }
            return result;
        }
        
    }
}

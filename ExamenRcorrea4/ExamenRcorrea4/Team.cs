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
        //national==true--> national
        //naional==false-->liga

        public string TeamName { get => teamName; set => teamName = value; }
        public bool National { get => national; set => national = value; }
        internal Player[] Players { get => players; set => players = value; }
        internal Player[] Playing { get => playing; set => playing = value; }
        internal Coach Coach { get => coach; set => coach = value; }
        internal Doctor Doctor { get => doctor; set => doctor = value; }

        public Team(string teamName,bool national, Player[] players, Player[] playingPlayers,Coach coach, Doctor doctor)
        {
            this.teamName = teamName;
            this.national = national;
            this.players = players;
            this.playing = playingPlayers;
            this.coach = coach;
            this.doctor = doctor;
        }

        //nationalsPlayers() verifica si el equipo es nacional y luego si todos los jugadores son de la misma nacionalidad al primero
        //si no se cumple una de estas retorna false, si se cumplen ambas retorna true
        public bool nationalPlayers()
        {
            if (this.national == true)
            {
                string  nationality="";
                string fisrtPlayerNationality = "";
                int cont = 0;
                foreach (Player p in players)
                {
                    nationality = p.Nationality;
                    if (cont == 0)
                    {
                        fisrtPlayerNationality = p.Nationality;
                    }
                    if (nationality != fisrtPlayerNationality)
                    {
                        return false;
                    }
                    cont += 1;
                    
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

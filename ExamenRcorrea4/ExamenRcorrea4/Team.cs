using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    class Team
    {
        private string teamName;
        private Player[] players = new Player[15];
        private bool national;
        //national==true--> national
        //naional==false-->liga

        public string TeamName { get => teamName; set => teamName = value; }
        public bool National { get => national; set => national = value; }
        internal Player[] Players { get => players; set => players = value; }
        

        public Team(string teamName,bool national, Player[] players)
        {
            this.teamName = teamName;
            this.national = national;
            this.players = players;
        }
    }
}

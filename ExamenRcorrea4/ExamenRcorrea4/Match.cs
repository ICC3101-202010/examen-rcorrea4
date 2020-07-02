using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    class Match
    {
        private bool national;//national==true--> national    naitonal==false-->liga
        private Team localTeam;
        private Team visitorTeam;
        private int minutes;
        private string result;

        public bool National { get => national; set => national = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public string Result { get => result; set => result = value; }
        internal Team LocalTeam { get => localTeam; set => localTeam = value; }
        internal Team VisitorTeam { get => visitorTeam; set => visitorTeam = value; }

        public Match(bool national, int minutes, string result, Team localTeam, Team visitorTeam)
        {
            this.national = national;
            this.minutes = minutes;
            this.result = result;
            this.localTeam = localTeam;
            this.visitorTeam = visitorTeam;
        }
    }
}

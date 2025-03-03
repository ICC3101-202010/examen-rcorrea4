﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExamenRcorrea4
{
    class Coach:Person
    {
        private int tacticPoints;
        private Team currentTeam;


        public int TacticPoints { get => tacticPoints; set => tacticPoints = value; }
        internal Team CurrentTeam { get => currentTeam; set => currentTeam = value; }

        public Coach(string completeName, string id, int age, int tacticPoints) : base(completeName, id, age)
        {
            this.completeName = completeName;
            this.id = id;
            this.age = age;
            this.TacticPoints = tacticPoints;
            
        }

        public bool changePlayer(Player playing,Player change)
        {
            bool okPlaying=false;
            bool okChange = false;
            //Verifica que los jugadores sean parte del equipo y que el jugador de cambio no este jugando
            foreach (Player p in currentTeam.Players)
            {
                if (p == playing)
                {
                    okPlaying = true;
                }
                if (p == change)
                {
                    okChange = true;
                }
            }
            foreach (Player p in currentTeam.Playing)
            {
                if (p == change)
                {
                    okChange = false;
                }
            }
            if (okChange == true && okPlaying == true)
            {
                int cont = 0;
                int selected = 0;
                foreach (Player p in currentTeam.Playing)
                {
                    if (p == playing)
                    {
                        selected = cont;
                        currentTeam.Playing[selected] = change;
                        return true;
                    }
                    
                    cont += 1;
                }
            }
            return false;
        }

        
        public delegate void InjuredMessageEventHandler(object source, EventArgs eventArgs);
        public event InjuredMessageEventHandler InjuredMesagge;
        public virtual void OnInjuredMesagge()
        {
            if (InjuredMesagge != null)
            {
                InjuredMesagge(this, EventArgs.Empty);
            }
        }
        public static void OnInjured(object source, EventArgs e)
        {
            Console.WriteLine("A Player had been injured");
            
        }
        public void InjuredPLayer()
        {
            OnInjuredMesagge();
            Console.WriteLine("A PLayer had been injured");
            InjuredMesagge += Match.OnInjuredMessage;
        }
    }
}

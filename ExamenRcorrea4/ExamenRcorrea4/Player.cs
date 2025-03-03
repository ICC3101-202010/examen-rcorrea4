﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExamenRcorrea4
{
    class Player:Person
    {
        private int attackPoints;
        private int defensePoints;
        private int number;
        private bool goalkeeper;
        private int healthPoints;
        private string nationality;

        public Player(string completeName,string id,int age,int attackPoints, int defensePoints, int number, bool goalkeeper, int healthPoints, string nationality) : base(completeName, id, age)
        {
            this.completeName = completeName;
            this.id = id;
            this.age = age;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Number = number;
            this.Goalkeeper = goalkeeper;
            this.healthPoints = healthPoints;
            this.Nationality = nationality;

        }

        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public int Number { get => number; set => number = value; }
        public bool Goalkeeper { get => goalkeeper; set => goalkeeper = value; }
        public int HealthPoints { get => healthPoints; set => healthPoints = value; }
        public string Nationality { get => nationality; set => nationality = value; }

        public delegate void InjuredEventHandler(object source, EventArgs args);
        public event InjuredEventHandler Injured;
        public virtual void OnInjured()
        {
            if (Injured != null)
            {
                Injured(this, EventArgs.Empty);
            }
        }
        public void InjuredPlayer()
        {
            Console.WriteLine("The player "+completeName+" has injured");
            Thread.Sleep(2000);
            OnInjured();
            Injured += Coach.OnInjured;
            
        }
    }
}

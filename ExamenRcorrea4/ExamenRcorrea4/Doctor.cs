using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    class Doctor:Person
    {
        private int experiencePoints;

        public int ExperiencePoints1 { get => experiencePoints; set => experiencePoints = value; }

        public Doctor(string completeName, string id, int age, int experiencePoints) : base(completeName, id, age)
        {
            this.completeName = completeName;
            this.id = id;
            this.age = age;
            this.experiencePoints = experiencePoints;
        }
        public void Evaluate(Player player)
        {

        }
        public void Heal(Player player)
        {

        }
    }
}

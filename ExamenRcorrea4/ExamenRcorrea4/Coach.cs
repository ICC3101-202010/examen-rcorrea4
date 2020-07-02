using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenRcorrea4
{
    class Coach:Person
    {
        private int tacticPoints;


        public int TacticPoints { get => tacticPoints; set => tacticPoints = value; }

        public Coach(string completeName, string id, int age, int tacticPoints) : base(completeName, id, age)
        {
            this.completeName = completeName;
            this.id = id;
            this.age = age;
            this.TacticPoints = tacticPoints;
        }

        public void changePlayer()
        {

        }
    }
}

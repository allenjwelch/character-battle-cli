using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Thief:Character
    {
        public int Special()
        {
            return Speed * 2;
        }


        public Thief(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Class = "Thief";
            this.Age = age;
            this.Strength = 20;
            this.Magic = 10;
            this.Speed = 50;
            this.Defense = 60;
            this.HitPoints = 120;
        }
    }
}

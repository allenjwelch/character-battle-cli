using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Warrior:Character
    {

        public int Special()
        {
            return Strength * 2; 
        }
        

        public Warrior(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Class = "Warrior"; 
            this.Age = age;

            this.Strength = 40;
            this.Magic = 0;
            this.Speed = 1;
            this.Defense = 20;
            this.HitPoints = 80;
            this.Items.Add("herbs");

        }
    }
}

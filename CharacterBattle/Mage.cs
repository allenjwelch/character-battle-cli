using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Mage:Character
    {

        public int Special()
        {
            return Magic * 2;
        }


        public Mage(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Class = "Mage";
            this.Age = age;

            this.Strength = 5;
            this.Magic = 50;
            this.Speed = 30;
            this.Defense = 40;
            this.HitPoints = 100;
            this.Items.Add("potion"); 
            this.Items.Add("herbs");
        }

    }
}

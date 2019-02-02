using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class VillageIdiot:Character
    {
        public void Special()
        {
            Console.WriteLine("Fart...");
        }


        public VillageIdiot(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Class = "Village Idiot";
            this.Age = age;

            this.Strength = 5;
            this.Magic = 0;
            this.Speed = 1;
            this.Defense = 20;
            this.HitPoints = 200;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Speed { get; set; }
        public int Defense { get; set; }
        public int HitPoints { get; set; }
        //public string[] Items = new string[3];
        //public ArrayList Items = new ArrayList();
        public List<string> Items = new List<string>();

        public void PrintStats()
        {
            Console.WriteLine("============");
            Console.WriteLine("{0} ({1})", Name, Class);
            Console.WriteLine("Strength: {0}", Strength);
            Console.WriteLine("Magic: {0}", Magic);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Defense: {0}", Defense);
            Console.WriteLine("HitPoints: {0}", HitPoints);

            Console.Write("Items: ");
            for(int i = 0; i < Items.Count; i++)
            {
                Console.Write("{0} ", Items[i]);
            }
            Console.WriteLine();
            Console.WriteLine("============");
            Console.WriteLine(" ");
        }

        public int Attack(Character opponent)
        {
            Console.WriteLine("{0} attacks {1} for {2} points of damage!", Name, opponent.Name, Strength);
            return Strength; 
        }

        public int Spell(Character opponent)
        {
            Console.WriteLine("{0} casts a spell against {1} for {2} points of damage!", Name, opponent.Name, Magic);
            return Magic;
        }

        public int Steal(Character opponent)
        {
            Console.WriteLine("{0} steals all {1}'s shit and deals {2} points of damage!", Name, opponent.Name, Strength);
            return Strength;
        }


        public Character()
        {
            this.Strength = 1;
            this.Magic = 0;
            this.Speed = 1;
            this.Defense = 5;
            this.HitPoints = 10;
        }

        public Character(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
    }
}

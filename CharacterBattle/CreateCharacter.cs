using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class CreateCharacter
    {
        public static Character create()
        {
            Character player; 

            Console.Write("Choose your character class (mage, warrior, or thief): ");
            string charClass = Console.ReadLine();
            
            Console.Write("Character name: ");
            string charName = Console.ReadLine();

            Console.Write("Character gender: ");
            string charGender= Console.ReadLine();

            Console.Write("Charcter age: ");
            string charAge = Console.ReadLine();
                        
            switch(charClass)
            {
                case "mage":
                    Mage mage = new Mage(charName, charGender, Convert.ToInt32(charAge));
                    mage.PrintStats();
                    player = mage; 
                    break;
                case "warrior":
                    Warrior warrior = new Warrior(charName, charGender, Convert.ToInt32(charAge));
                    warrior.PrintStats();
                    player = warrior; 
                    break;
                case "thief":
                    Thief thief = new Thief(charName, charGender, Convert.ToInt32(charAge));
                    thief.PrintStats();
                    player = thief; 
                    break;
                default:
                    Console.WriteLine("You have not entered a proper class. You have been assigned the 'Village Idiot'.");
                    VillageIdiot villageIdiot = new VillageIdiot(charName, charGender, Convert.ToInt32(charAge));
                    villageIdiot.PrintStats();
                    player = villageIdiot;
                    break; 
            }
            return player;
        }
    }
}

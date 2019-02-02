using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Warrior warrior = new Warrior("Conan", "Male", 32);
            // warrior.PrintStats();

            // Mage mage = new Mage("Xavier", "Male", 67);
            // mage.PrintStats();

            // warrior.HitPoints = mage.Attack(warrior);

            // warrior.PrintStats(); 

            Console.WriteLine("Player 1, create your character!");
            Character player1 = CreateCharacter.create();

            Console.WriteLine("Player 2, create your character!");
            Character player2 = CreateCharacter.create();

            Battle(player1, player2);

            Console.ReadKey(); 
        }

        public static void Battle(Character player1, Character player2)
        {
            int round = 1;

            while (player1.HitPoints > 0 && player2.HitPoints > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Round {0}!", round);
                Console.WriteLine("{0}'s HP: {1}, {2}'s HP: {3}", player1.Name, player1.HitPoints, player2.Name, player2.HitPoints);
                if(round % 2 != 0) // player 1
                {
                    moveOptions(player1, player2);
                    if (!checkDeath(player2))
                    {
                        Console.WriteLine("{0} is DEAD! {1} is the Winner!", player2.Name, player1.Name);
                        return; 
                    }
                }
                else // player 2
                {
                    moveOptions(player2, player1);
                    if (!checkDeath(player1))
                    {
                        Console.WriteLine("{0} is DEAD! {1} is the Winner!", player1.Name, player2.Name);
                        return;
                    }
                }

                round++; 

            }

        }

        public static void moveOptions(Character player, Character opponent)
        {
            Console.Write("{0}({1}), choose your move (attack, magic, steal, or item): ", player.Name, player.Class);

            string move = Console.ReadLine();

            switch (move)
            {
                case "attack":
                    int attack = player.Attack(opponent);
                    opponent.HitPoints = opponent.HitPoints - attack;
                    Console.WriteLine("{0}'s HP is now: {1}", opponent.Name, opponent.HitPoints);
                    break;
                case "magic":
                    int spell = player.Spell(opponent);
                    opponent.HitPoints = opponent.HitPoints - spell;
                    Console.WriteLine("{0}'s HP is now: {1}", opponent.Name, opponent.HitPoints);
                    break;
                case "steal":

                    if(opponent.Items.Count > 0)
                    {
                        int steal = player.Steal(opponent);
                        opponent.HitPoints = opponent.HitPoints - steal;
                        Console.WriteLine("{0}'s HP is now: {1}", opponent.Name, opponent.HitPoints);
                        List<string> copy = opponent.Items.ToList();
                        player.Items = copy;

                        opponent.Items.Clear();
                        Console.WriteLine("{0}'s items: {1}", opponent.Name, opponent.Items.Count);
                        Console.Write("{0}'s new items: ", player.Name);
                        for (int i = 0; i < player.Items.Count; i++)
                        {
                            Console.Write("{0} ", player.Items[i]);
                        }
                        Console.WriteLine();
                        
                    }
                    else
                    {
                        Console.WriteLine("{0} has nothing left to steal!", opponent.Name);
                    }
                    break;
                case "item":
                    if(player.Items.Count > 0)
                    {
                        Console.WriteLine("Which items do you want to use?");
                        Console.Write("Items: ");
                        for (int i = 0; i < player.Items.Count; i++)
                        {
                            Console.Write("{0} ", player.Items[i]);
                        }
                        Console.Write("-->");
                        string input = Console.ReadLine(); 

                        switch (input)
                        {
                            case "potion":
                                player.HitPoints = player.HitPoints + 50;
                                Console.WriteLine("{0} gained 50 hitpoints!", player.Name);
                                player.Items.Remove("potion"); 
                                break;
                            case "herbs":
                                player.HitPoints = player.HitPoints + 20;
                                Console.WriteLine("{0} gained 20 hitpoints!", player.Name);
                                player.Items.Remove("herbs");
                                break;
                            default:
                                Console.WriteLine("You do not have that item.");
                                break; 
                        }

                    }
                    else
                    {
                        Console.WriteLine("You do not have any items...");
                    }
                    break;
                case "stats":
                    player.PrintStats();
                    opponent.PrintStats();
                    moveOptions(player, opponent); 
                    break; 
                default:
                    Console.WriteLine("That's not an acceptable move. You lose your turn");
                    break;

            }
        }
        
        public static bool checkDeath(Character opponent)
        {
            bool isAlive = true; 
            if(opponent.HitPoints <= 0)
            {
                isAlive = false; 
            }

            return isAlive; 
        }
    }
}

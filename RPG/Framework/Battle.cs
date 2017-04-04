using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Helper;

namespace RPG.Framework
{
    class Battle
    {
        private iCharacter[] characters;
        public Battle(iCharacter[] in_characters)
        {
            characters = in_characters;
            Loop();
        }

        private void Loop()
        {
            while (!Dead())
            {
                Step();
            }
        }

        private bool Dead()
        {
            bool dead = false;
            foreach (var character in characters)
            {
                if (character.hp <= 0)
                {
                    Console.WriteLine(character.name + " is dead.");
                    dead = true;
                }
            }
            return dead;
        }
        private void Step()
        {
            Console.Clear();
            Stats();
            Update();
            Console.WriteLine("Please choose a command: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Evade");
            string input = Console.ReadLine();
            bool x = false;
            if (input != null && input != "")
            {
                while (!x)
                {
                    switch (input)
                    {
                        case "1":
                            characters[0].Attack.Initiate(characters[0], characters[1]);
                            x = true;
                            break;
                        case "2":
                            characters[0].Block.Initiate(characters[0], characters[1]);
                            x = true;
                            break;
                        case "3":
                            characters[0].Evade.Initiate(characters[0], characters[1]);
                            x = true;
                            break;
                        default:
                            break;
                    }
                }
                
                switch (Helper.Helper.rnd.Next(1, 4))
                {
                    case 1:
                        characters[1].Attack.Initiate(characters[1], characters[0]);
                        break;
                    case 2:
                        characters[1].Block.Initiate(characters[1], characters[0]);
                        break;
                    case 3:
                        characters[1].Block.Initiate(characters[1], characters[0]);
                        break;
                }
                Console.Write("Enter to continue...");
                Console.ReadLine();
            }
        }

        private void Update()
        {
            foreach (var character in characters)
            {
                Console.Write(character.name + " has " + character.hp + " hp. ");
            }
            Console.WriteLine();
        }

        private void Stats()
        {
            Console.WriteLine("{0,-30} {1,0}", characters[0].name, characters[1].name);
            if (characters[0].title!="" || characters[1].title!="")
                Console.WriteLine("{0,-30} {1,0}","\""+ characters[0].title + "\"", "\"" + characters[1].title + "\"");
            Console.WriteLine();
            Console.WriteLine("{0,-30} {1,0}", characters[0].race, characters[1].race);
            Console.WriteLine("{0,-30} {1,0}", "HP: "+characters[0].hp, "HP: " + characters[1].hp);
            Console.WriteLine("{0,-30} {1,0}", "AC: " + characters[0].AC, "AC: " + characters[1].AC);
            Console.WriteLine("{0,-30} {1,0}", "Str: " + characters[0].Str, "Str: " + characters[1].Str);
            Console.WriteLine("{0,-30} {1,0}", "Dex: " + characters[0].Dex, "Dex: " + characters[1].Dex);
            Console.WriteLine("{0,-30} {1,0}", "Con: " + characters[0].Con, "Con: " + characters[1].Con);
            Console.WriteLine("{0,-30} {1,0}", "Int: " + characters[0].Int, "Int: " + characters[1].Int);
            Console.WriteLine("{0,-30} {1,0}", "Wis: " + characters[0].Wis, "Wis: " + characters[1].Wis);
            Console.WriteLine("{0,-30} {1,0}", "Cha: " + characters[0].Cha, "Cha: " + characters[1].Cha);
            Console.WriteLine("{0,-30} {1,0}", "Holding: " + characters[0].weapon.material + " " + characters[0].weapon.name, "Holding: " + characters[0].weapon.material + " " + characters[1].weapon.name);
            Console.WriteLine("{0,-30} {1,0}", "Wearing: " + characters[0].armor.name, "Wearing: " + characters[1].armor.name);
            Console.WriteLine();
        }
    }

}

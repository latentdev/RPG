using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Weapon;
using System.IO;
using RPG.Equipment;
using RPG.Dice;

namespace RPG.Helper
{
    class Helper
    {
        public static Random rnd = new Random();
        static public iCharacter Creator()
        {
            iCharacter character;
            Console.WriteLine("Please choose a race: Human, Elf or Orc");
            string race = Console.ReadLine();
            Console.WriteLine("Please enter character's name(type random for a random name): ");
            
            string name = Console.ReadLine();
            if (name != null)
            {

                switch (name)
                {
                    case "Random":
                        Console.WriteLine("Finding random name....");
                        name = Random_Name(rnd);
                        Console.WriteLine("Name found: " + name); 
                        break;
                    case "random":
                        Console.WriteLine("Finding random name....");
                        name = Random_Name(rnd);
                        Console.WriteLine("Name found: " + name);
                        break;
                    default:
                        break;
                }
            }
            int[] stats = new int[6];
            if (race != null)
            {
                switch (race)
                {
                    case "Human":

                        stats[0] = 15;
                        stats[1] = 14;
                        stats[2] = 10;
                        stats[3] = 8;
                        stats[4] = 13;
                        stats[5] = 12;
                        character = new Human(name, "", stats, new Dagger(), new Leather(), new Attack(), new Block(), new Evade());
                        break;
                    case "Elf":
                        stats[0] = 12;
                        stats[1] = 15;
                        stats[2] = 13;
                        stats[3] = 14;
                        stats[4] = 10;
                        stats[5] = 8;
                        character = new Elf(name, "", stats, new Dagger(), new Leather(), new Attack(), new Block(), new Evade());
                        break;
                    case "Orc":
                        stats[0] = 15;
                        stats[1] = 13;
                        stats[2] = 14;
                        stats[3] = 10;
                        stats[4] = 12;
                        stats[5] = 8;
                        character = new Orc(name, "", stats, new Dagger(), new Leather(), new Attack(), new Block(), new Evade());
                        break;
                    default:
                        Console.WriteLine("Race " + race + " is not valid");
                        Console.WriteLine("Creating random character...");
                        stats[0] = 15;
                        stats[1] = 14;
                        stats[2] = 10;
                        stats[3] = 8;
                        stats[4] = 13;
                        stats[5] = 12;
                        character = new Human(name, "", stats, new Dagger(), new Leather(), new Attack(), new Block(), new Evade());
                        break;
                }
            }
            else
            {
                stats[0] = 15;
                stats[1] = 14;
                stats[2] = 10;
                stats[3] = 8;
                stats[4] = 13;
                stats[5] = 12;
                character = new Human(name, "", stats, new Dagger(), new Leather(), new Attack(), new Block(), new Evade());
            }
            character.title = Title(rnd);
            Console.Write("Enter to continue...");
            Console.ReadLine();
            return character;
        }
        static public string Random_Name(Random rnd)
        {
            string name = null;
            
            var names = File.ReadAllLines("Names.txt");
            name = names[rnd.Next(0,names.Count())];
            return name;   
        }
        static public string Title(Random rnd)
        {
            string title = null;
            var adjectives = File.ReadAllLines("Adjectives.txt");
            var nouns = File.ReadAllLines("Nouns.txt");
            title = "The " + adjectives[rnd.Next(0, adjectives.Count())] + " " + nouns[rnd.Next(0, nouns.Count())];
            return title;
        }

        static public int Random_Number(int low, int high)
        {
            return rnd.Next(low, high);
        }
        static public int Mod(int score)
        {
            int mod = 0;
            switch (score)
            {
                case 1:
                    mod = -5;
                    break;
                case 2:
                    mod = -4;
                    break;
                case 3:
                    mod = -4;
                    break;
                case 4:
                    mod = -3;
                    break;
                case 5:
                    mod = -3;
                    break;
                case 6:
                    mod = -2;
                    break;
                case 7:
                    mod = -2;
                    break;
                case 8:
                    mod = -1;
                    break;
                case 9:
                    mod = -1;
                    break;
                case 10:
                    mod = 0;
                    break;
                case 11:
                    mod = 0;
                    break;
                case 12:
                    mod = 1;
                    break;
                case 13:
                    mod = 1;
                    break;
                case 14:
                    mod = 2;
                    break;
                case 15:
                    mod = 2;
                    break;
                case 16:
                    mod = 3;
                    break;
                case 17:
                    mod = 3;
                    break;
                case 18:
                    mod = 4;
                    break;
                case 19:
                    mod = 4;
                    break;
                case 20:
                    mod = 5;
                    break;
                case 21:
                    mod = 5;
                    break;
                case 22:
                    mod = 6;
                    break;
                case 23:
                    mod = 6;
                    break;
                case 24:
                    mod = 7;
                    break;
                case 25:
                    mod = 7;
                    break;
                case 26:
                    mod = 8;
                    break;
                case 27:
                    mod = 8;
                    break;
                case 28:
                    mod = 9;
                    break;
                case 29:
                    mod = 9;
                    break;
                case 30:
                    mod = 10;
                    break;
            }
            return mod;
        }
        static public int AC(iCharacter character)
        {
            int AC;
            switch (character.armor.material)
            {
                case "Leather":
                    AC = character.armor.AC + Mod(character.Dex);
                    break;
                case "Chain":
                    int mod = Mod(character.Dex);
                    if (mod > 2)
                        mod = 2;
                    AC = character.armor.AC + mod;
                    break;
                case "Plate":
                    AC = character.armor.AC;
                    break;
                default:
                    AC = 10;
                    break;
            }
            return AC;

        }
        static public bool Hit (iCharacter one, iCharacter two)
        {
            int mod;
            int hit;
            int roll = new D20().Roll();
            switch (one.weapon.type)
            {
                case "Str":
                    mod = Mod(one.Str);
                    hit = roll + mod;
                    Console.Write(one.name + " rolls a " + hit + "(" + roll + " + " + mod + " Str mod): ");
                    break;
                case "Dex":
                    mod = Mod(one.Dex);
                    hit = roll + mod;
                    Console.Write(one.name + " rolls a " + hit + "(" + roll + " + " + mod + " Dex mod): ");
                    break;
                default:
                    mod = Mod(one.Str);
                    hit = roll + mod;
                    Console.Write(one.name + " rolls a " + hit + "(" + roll + " + " + mod + " Str mod): ");
                    break;
            }
            if (hit >= two.AC)
            {
                Console.WriteLine("Hit");
                return true;
            }
            else
            {
                Console.WriteLine("Miss");
                return false;
            }
        }
    }
}

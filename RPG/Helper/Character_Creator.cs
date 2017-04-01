using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Weapon;
using RPG.Helper;
using System.IO;

namespace RPG.Helper
{
    class Character_Creator
    {
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
                        name = Random_Name();
                        Console.WriteLine("Name found: " + name); 
                        break;
                    case "random":
                        Console.WriteLine("Finding random name....");
                        name = Random_Name();
                        Console.WriteLine("Name found: " + name);
                        break;
                    default:
                        break;
                }
            }
            if (race != null)
                switch (race)
                {
                    case "Human":
                        character = new Human(name, "", 10, 10, 10, new Dagger());
                        break;
                    case "Elf":
                        character = new Elf(name, "", 10, 10, 10, new Dagger());
                        break;
                    case "Orc":
                        character = new Orc(name, "", 10, 10, 10, new Dagger());
                        break;
                    default:
                        Console.WriteLine("Race " + race + " is not valid");
                        Console.WriteLine("Creating random character...");
                        character = new Human(name, "", 10, 10, 10, new Dagger());
                        break;
                }
            else
                character = new Human(name, "", 10, 10, 10, new Dagger());
            //Console.Read();
            return character;
        }
        static public string Random_Name()
        {
            string name = null;
            Random rnd = new Random();
            var file = File.ReadAllText("C:\\Users\\Laten\\documents\\visual studio 2015\\Projects\\RPG\\RPG\\Data\\Names.txt");
            var names = file.Split(' ').ToArray();
            name = names[rnd.Next(0,names.Count())];
            return name;   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Weapon;
using RPG.Helper;
using RPG.Framework;
using RPG.Dice;
using RPG.Equipment;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            iDice d20 = new D20();
            Console.Write("Please enter number of D20 to roll:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Rolling {0} d20...", count);
            for (int i = 0; i < count; i++)
                Console.WriteLine(d20.Roll());*/
            
            iCharacter player = Helper.Helper.Creator();
            Random rnd = new Random();
            rnd.Next();
            int[] stats = new int[6];
            stats[0] = 15;
            stats[1] = 13;
            stats[2] = 14;
            stats[3] = 10;
            stats[4] = 12;
            stats[5] = 8;
            iCharacter enemy = new Orc(Helper.Helper.Random_Name(rnd), "", stats, new Axe(), new Chain(), new Attack(), new Block(), new Evade());
            enemy.title = Helper.Helper.Title(rnd);
            iCharacter[] characters = new iCharacter[2];
            characters[0] = player;
            characters[1] = enemy;
            Battle battle = new Battle(characters);
            Console.Write("Hit Enter to exit...");
            Console.ReadLine();
            
        }
    }
}

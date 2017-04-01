using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Weapon;
using RPG.Helper;
using RPG.Framework;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            iCharacter player = Character_Creator.Creator();
            iCharacter enemy = new Orc(Character_Creator.Random_Name(), "", 10, 10, 10, new Axe());
            iCharacter[] characters = new iCharacter[2];
            characters[0] = player;
            characters[1] = enemy;
            Battle battle = new Battle(characters);

            /*Console.WriteLine(player.attack());
            Console.WriteLine(player.block());
            Console.WriteLine(player.evade());*/
            
        }
    }
}

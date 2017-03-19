using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;
using RPG.Weapon;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            iCharacter player = new Human("Dwayne", "", 10, 10, 10, new Dagger());
            Console.WriteLine(player.attack());
            Console.WriteLine(player.block());
            Console.WriteLine(player.evade());
        }
    }
}

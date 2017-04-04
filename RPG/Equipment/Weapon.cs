using RPG.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapon
{
    interface iWeapon
    {
        string name { get; set; }
        iDice damage { get; set; }
        string material { get; set; }
        string type { get; set; }
        int attack(int mod);
        string block();
    }
    class Weapon : iWeapon
    { 
        public string name { get; set; }
        public iDice damage { get; set; }
        public string material { get; set; }
        public string type { get; set; }

        public Weapon()
        {
            damage = new D4();
        }

        public int attack(int mod)
        {
            int value = damage.Roll() + mod;
            Console.WriteLine("swings "+material + " " + name + " dealing " + value + " damage");
            return value;
        }

        public string block()
        {
            return "blocks with " + material + " " + name;
        }
    }
    class Axe : Weapon
    {
        public Axe()
        {
            name = "Axe";
            damage = new D6();
            material = "Bone";
            type = "Str";
        }
    }
    class Dagger : Weapon
    {
        public Dagger()
        {
            name = "Dagger";
            damage = new D4();
            material = "Iron";
            type = "Dex";
        }
    }

    class Fists : Weapon
    {
        public Fists()
        {
            name = "Fists";
            damage = new D4();
            material = "Bare";
            type = "Str";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapon
{
    interface iWeapon
    {
        string attack();
        string block();
    }
    class Weapon : iWeapon
    { 
        public string name;
        public int damage=0;
        public string material;

        public Weapon()
        {
            damage = 0;
        }

        public string attack()
        {
            return "swings "+material + " " + name + " dealing " + damage + " damage";
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
            damage = 3;
            material = "Bone";
        }
    }
    class Dagger : Weapon
    {
        public Dagger()
        {
            name = "Dagger";
            damage = 2;
            material = "Iron";
        }
    }

    class Fists : Weapon
    {
        public Fists()
        {
            name = "Fists";
            damage = 1;
            material = "Bare";
        }
    }
}

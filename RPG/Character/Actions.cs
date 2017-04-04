using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Character
{
    interface iAction
    {
        string type { get; set; }

        void Initiate(iCharacter one, iCharacter two);
    }

    class Attack:iAction
    {
        public string type { get; set; }
        public Attack()
        {
            type = "Attack";
        }
        public void Initiate(iCharacter one, iCharacter two)
        {
            if (Helper.Helper.Hit(one, two))
            {
                Console.Write(one.name + " \"" + one.title + "\" ");
                switch (one.weapon.type)
                {
                    case "Str":
                        two.hp -= one.weapon.attack(Helper.Helper.Mod(one.Str));
                        break;
                    case "Dex":
                        two.hp -= one.weapon.attack(Helper.Helper.Mod(one.Dex));
                        break;
                }
            }
        }
    }

    class Block : iAction
    {
        public string type { get; set; }
        public Block()
        {
            type = "Block";
        }
        public void Initiate(iCharacter one, iCharacter two)
        {
            Console.WriteLine(one.name + " \"" + one.title + "\" " + one.weapon.block());
        }
    }

    class Evade : iAction
    {
        public string type { get; set; }
        public Evade()
        {
            type = "Evade";
        }
        public void Initiate(iCharacter one, iCharacter two)
        {
            Console.WriteLine(one.name + " \"" + one.title + "\" evades");
        }
    }
}

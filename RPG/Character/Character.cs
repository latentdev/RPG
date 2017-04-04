using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Weapon;
using RPG.Equipment;

namespace RPG.Character
{

    interface iCharacter
    {
        string name { get; set; }
        string title { get; set; }
        string race { get; set; }
        int hp { get; set; }
        int AC { get; set; }
        int Str { get; set; }
        int Dex { get; set; }
        int Con { get; set; }
        int Int { get; set; }
        int Wis { get; set; }
        int Cha { get; set; }
        iWeapon weapon { get; set; }
        iArmor armor { get; set; }
        iAction Attack { get; set; }
        iAction Block { get; set; }
        iAction Evade { get; set; }
    }

    class Character:iCharacter
    {
        public string name { get; set; }
        public string title { get; set; }
        public string race { get; set; }
        public int hp { get; set; }
        public int AC { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public iWeapon weapon { get; set; }
        public iArmor armor { get; set; }
        public iAction Attack { get; set; }
        public iAction Block { get; set; }
        public iAction Evade { get; set; }



        public Character()
        {
            name = "Nameless";
            title = "";
            race = "";
            hp = 0;
            Str = 0;
            Dex = 0;
            Con = 0;
            Int = 0;
            Wis = 0;
            Cha = 0;
            weapon = new Dagger();
            armor = new Leather();
            AC = Helper.Helper.AC(this);
            Attack = new Attack();
            Block = new Block();
            Evade = new Evade();
        }
    }

    class Human:Character
    {

        public Human()
        {
            name = "Nobody";
            title = "";
            race = "Human";
            Str = 10+1;
            Dex = 10+1;
            Con = 10+1;
            Int = 10+1;
            Wis = 10+1;
            Cha = 10+1;
            hp = 10 + Helper.Helper.Mod(Con);
            weapon = new Fists();
            armor = new Unarmored();
            AC = Helper.Helper.AC(this);
            Attack = new Attack();
            Block = new Block();
            Evade = new Evade();
        }

        public Human(string in_name, string in_title, int [] stats, iWeapon in_wep, iArmor in_armor, iAction in_attack, iAction in_block, iAction in_evade)
        {
            name = in_name;
            title = in_title;
            race = "Human";
            Str = stats[0] + 1;
            Dex = stats[1] + 1;
            Con = stats[2] + 1;
            Int = stats[3] + 1;
            Wis = stats[4] + 1;
            Cha = stats[5] + 1;
            hp = 10 + Helper.Helper.Mod(Con);
            weapon = in_wep;
            armor = in_armor;
            AC = Helper.Helper.AC(this);
            Attack = in_attack;
            Block = in_block;
            Evade = in_evade;
        }
    }

    class Orc:Character
    {
        public Orc(string in_name, string in_title, int [] stats, iWeapon in_wep, iArmor in_armor, iAction in_attack, iAction in_block, iAction in_evade)
        {
            name = in_name;
            title = in_title;
            race = "Orc";
            Str = stats[0] + 2;
            Dex = stats[1];
            Con = stats[2] + 1;
            Int = stats[3];
            Wis = stats[4];
            Cha = stats[5];
            hp = 10 + Helper.Helper.Mod(Con);
            weapon = in_wep;
            armor = in_armor;
            AC = Helper.Helper.AC(this);
            Attack = in_attack;
            Block = in_block;
            Evade = in_evade;
        }
    }

    class Elf : Character
    {
        public Elf(string in_name, string in_title,int [] stats, iWeapon in_wep, iArmor in_armor, iAction in_attack, iAction in_block, iAction in_evade)
        {
            name = in_name;
            title = in_title;
            race = "Elf";
            Str = stats[0];
            Dex = stats[1] + 2;
            Con = stats[2];
            Int = stats[3];
            Wis = stats[4];
            Cha = stats[5];
            hp = 10 + Helper.Helper.Mod(Con);
            weapon = in_wep;
            armor = in_armor;
            AC = Helper.Helper.AC(this);
            Attack = in_attack;
            Block = in_block;
            Evade = in_evade;
        }
    }

}

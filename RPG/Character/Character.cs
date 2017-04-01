using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Weapon;
namespace RPG.Character
{
    public enum StandardStats
    {
        hp = 10,
        str = 10,
        dex = 10
    }

    interface iCharacter
    {
        string name { get; set; }
        string title { get; set; }
        int hp { get; set; }
        int strength { get; set; }
        int dex { get; set; }
        iWeapon weapon { get; set; }

        int attack();
        string block();
        string evade();
    }

    class Character:iCharacter
    {
        public string name { get; set; }
        public string title { get; set; }
        public int hp { get; set; }
        public int strength { get; set; }
        public int dex { get; set; }
        public iWeapon weapon { get; set; }

        public Character()
        {
            name = "Nameless";
            title = "";
            hp = 0;
            strength = 0;
            dex = 0;
            weapon = new Dagger();
        }
        public int attack()
        {
            Console.WriteLine(title + " " + name + " " + weapon.attack());
            return weapon.damage;
        }

        public string block()
        {
            return title + " " + name + " " + weapon.block();
        }

        public string evade()
        {
            return title + " " + name + " dodges the attack.";
        }
    }

    class Human:Character
    {

        public Human()
        {
            name = "Nobody";
            title = "";
            hp = (int)StandardStats.hp;
            strength = (int)StandardStats.str;
            dex = (int)StandardStats.dex;
            weapon = new Fists();
        }

        public Human(string in_name, string in_title, int in_hp, int in_strength, int in_dex, iWeapon in_wep)
        {
            name = in_name;
            title = in_title;
            hp = in_hp;
            strength = in_strength;
            dex = in_dex;
            weapon = in_wep;
        }
    }

    class Orc:Character
    {
        public Orc(string in_name, string in_title, int in_hp, int in_strength, int in_dex, iWeapon in_wep)
        {
            name = in_name;
            title = in_title;
            hp = in_hp * 2;
            strength = (in_strength/2)+in_strength;
            dex = in_dex / 2;
            weapon = in_wep;
        }
    }

    class Elf : Character
    {
        public Elf(string in_name, string in_title, int in_hp, int in_strength, int in_dex, iWeapon in_wep)
        {
            name = in_name;
            title = in_title;
            hp = in_hp * 2;
            strength = (in_strength / 2) + in_strength;
            dex = in_dex / 2;
            weapon = in_wep;
        }
    }

}

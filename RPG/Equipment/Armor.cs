using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipment
{
    interface iArmor
    {
        int AC { get; set; }
        string material { get; set; }
        string name { get; set; }
    }

    class Leather:iArmor
    {
        public int AC { get; set; }
        public string material { get; set; }
        public string name { get; set; }

        public Leather()
        {
            AC = 11;
            material = "Leather";
            name = "Leather Armor";
        }

        public Leather(string in_name,string in_material, int in_AC = 11)
        {
            AC = in_AC;
            material = in_material;
            name = in_name;
        }
    }

    class Chain : iArmor
    {
        public int AC { get; set; }
        public string material { get; set; }
        public string name { get; set; }

        public Chain()
        {
            AC = 13;
            material = "Chain";
            name = "Chain Shirt";
        }

        public Chain(string in_name, string in_material, int in_AC = 13)
        {
            AC = in_AC;
            material = in_material;
            name = in_name;
        }
    }

    class Plate : iArmor
    {
        public int AC { get; set; }
        public string material { get; set; }
        public string name { get; set; }

        public Plate()
        {
            AC = 18;
            material = "Plate";
            name = "Plate Mail";
        }

        public Plate(string in_name, string in_material, int in_AC = 18)
        {
            AC = in_AC;
            material = in_material;
            name = in_name;
        }
    }

    class Unarmored:iArmor
    {
        public int AC { get; set; }
        public string material { get; set; }
        public string name { get; set; }

        public Unarmored()
        {
            AC = 10;
            material = "";
            name = "";
        }

        public Unarmored(string in_name, string in_material, int in_AC = 10)
        {
            AC = in_AC;
            material = in_material;
            name = in_name;
        }
    }
}

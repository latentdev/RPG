using RPG.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dice
{
    interface iDice
    {
        int sides { get; set; }
        int Roll();
    }

    class Die:iDice
    {
        public int sides { get; set; }


        public int Roll()
        {
            return Helper.Helper.Random_Number(1, sides + 1);
        }
    }

    class D4:Die
    {
        public D4()
        {
            sides = 4;
        }
    }

    class D6:Die
    {
        public D6()
        {
            sides = 6;
        }
    }

    class D8:Die
    {
        public D8()
        {
            sides = 8;
        }
    }
    class D10 : Die
    {
        public D10()
        {
            sides = 10;
        }
    }
    class D12 : Die
    {
        public D12()
        {
            sides = 12;
        }
    }

    class D20 : Die
    {
        public D20()
        {
            sides = 20;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Character;

namespace RPG.Framework
{
    class Battle
    {
        private iCharacter[] characters;
        public Battle(iCharacter[] in_characters)
        {
            characters = in_characters;
            Loop();
        }

        private void Loop()
        {
            while (!Dead())
            {
                Step();
            }

        }

        private bool Dead()
        {
            bool dead = false;
            foreach (var character in characters)
            {
                if (character.hp <= 0)
                {
                    Console.WriteLine(character.name + " is dead.");
                    dead = true;
                }
            }
            return dead;
        }
        private void Step()
        {
            //Console.Clear();
            Update();
            Console.WriteLine("Please choose a command: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Evade");
            string input = Console.ReadLine();
            bool x = false;
            int[] damage = new int[2];
            damage[0] = 0;
            damage[1] = 0;

            while (!x)
            {
                switch (input)
                {
                    case "1":
                        damage[0] = characters[0].attack();
                        x = true;
                        break;
                    case "2":
                        Console.WriteLine(characters[0].block());
                        x = true;
                        break;
                    case "3":
                        Console.WriteLine(characters[0].evade());
                        x = true;
                        break;
                    default:
                        break;
                }
            }
            Random rnd = new Random();
            switch (rnd.Next(1, 4))
            {
                case 1:
                    damage[1] = characters[1].attack();
                    break;
                case 2:
                    Console.WriteLine(characters[1].block());
                    break;
                case 3:
                    Console.WriteLine(characters[1].evade());
                    break;
            }
            Damage(damage);
        }
        private void Damage(int [] damage)
        {
            characters[0].hp -= damage[1];
            characters[1].hp -= damage[0];
        }

        private void Update()
        {
            foreach (var character in characters)
            {
                Console.Write(character.name + " has " + character.hp + " hp. ");
            }
            Console.WriteLine();
        }
    }

}

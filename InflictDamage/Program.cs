using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InflictDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your enemy's health is 15\nInflict damage 'till he died!\n======================================\n");
            int x = 15;
            do
            {

                Console.Write("Damage : ");
                int dmg = int.Parse(Console.ReadLine());

                if (dmg <= 0)
                {
                    Console.WriteLine("Go with valid damage!");
                }
                else if (dmg >= 9)
                {
                    Console.WriteLine("DONT GO TOO HARD!");
                }
                else
                {
                    x = x - dmg;
                    if (x > 0)
                    {
                        Console.WriteLine($"Your enemy is still at {x}");
                    }
                    else
                    {
                        break;
                    }
                }

            } while (x > 0);
            Console.WriteLine("Your enemy is dead!");
        }
    }
}

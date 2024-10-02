using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTickBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           ===================== Tick Tick Boom =====================\nSetiap angka puluhan (10,20,30, dll) di perulangan ini, ubah menjadi kata 'BOOM'\n\n");
            Console.Write("Input Number : ");

            int x = int.Parse(Console.ReadLine());
            int z = 0;
            int a = 0;
            int y = 0;
            while (y < x)
            {
                a = x - z;
                if (a > 10)
                {
                    for (int y1 = 0; y1 < 9; y1++)
                    {
                        y++;
                        Console.WriteLine(y);
                    }
                    y++;
                    Console.WriteLine("BOOM!");
                    z += 10;
                }
                else
                {
                    for (int y2 = 0; y2 < a; y2++)
                    {
                        y++;
                        Console.WriteLine(y);
                    }
                }
            }
            //YA ALLAH AKHIRNYA BISA YA ALLAH!!!!! NANGIS BANGET 2 JAM CUMA NGOTAK NGATIK TICKTICKBOOM :((
        }
    }
}

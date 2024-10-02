using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================\nKonversi Detik\n======================================\n\nMengubah detik menjadi Menit dan Jam\n\n");
            Console.Write("Masukkan Detik : ");
            double a = double.Parse(Console.ReadLine());
            double s = a / 60;
            double h = a / 3600;
            Console.WriteLine($"{s} menit\n{h} jam\n");

        }
    }
}

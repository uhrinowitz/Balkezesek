using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Név: Uhrin Ákos 

            string path = "balkezesek.csv";
            List<Balkezesek> balkezesek = new List<Balkezesek>();
            string[] sorok = File.ReadAllLines(path);

            foreach (string sor in sorok.Skip(1))
            {
                balkezesek.Add(new Balkezesek(sor));
            }

            // 1. feladat
            int versenyzőkSzáma = balkezesek.Count;
            Console.WriteLine($"1. feladat: {versenyzőkSzáma} versenyzőről van adatunk.");

            // 2. feladat
            List<Balkezesek> elsők = new List<Balkezesek>();
            Console.WriteLine("2. feladat: 1980-ban lépett pályára:");
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Első.Contains("1980"))
                {
                    elsők.Add(balkezes);
                    Console.WriteLine($"\t{balkezes.Név}");
                }
            }

            // 3. feladat
            string bekértNév = Console.ReadLine();
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Név == bekértNév)
                {
                    Console.WriteLine($"3. feladat: {balkezes.Név} magassága: {balkezes.Magasság*2.54} cm.");
                }
            }


            Console.ReadLine();
        }
    }
}

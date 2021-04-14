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
            Console.WriteLine($"{versenyzőkSzáma} versenyzőről van adatunk.");

            Console.ReadLine();
        }
    }
}

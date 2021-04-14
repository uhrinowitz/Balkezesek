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
            Console.WriteLine("\n2. feladat: 1980-ban lépett pályára:");
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Első.Contains("1980"))
                {
                    elsők.Add(balkezes);
                    Console.WriteLine($"\t{balkezes.Név}");
                }
            }

            // 3. feladat
            Console.WriteLine($"\n3. feladat: Add meg egy játékos nevét:");
            string bekértNév = Console.ReadLine();
            bool nincs = true;
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Név == bekértNév)
                {
                    Console.WriteLine($"{balkezes.Név} magassága: {balkezes.Magasság*2.54} cm.");
                    nincs = false;
                } 

            }

            if (nincs)
            {
                Console.WriteLine($"3. feladat: Hibás adat!"); 
            }

            // 4. feladat
            Console.WriteLine("\n4. feladat: Adj meg évszámok 1900-1999 között:");
            bool jó = false;
            int évszám = 0;
            do
            {
                évszám = int.Parse(Console.ReadLine());
                if (évszám >= 1900 && évszám <= 1999)
                {
                    jó = true;
                }
                else
                {
                    Console.WriteLine("Adj meg évszámok 1900-1999 között:");
                }
            } while (!jó);

            Console.WriteLine($"{évszám}-ban pályára lépettek adatai:");
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Első.Contains(évszám.ToString()))
                {
                    Console.Write($"Név: {balkezes.Név}, első: {balkezes.Első}, utolsó: {balkezes.Utolsó}, magasság: {balkezes.Magasság}, súly: {balkezes.Súly}\n");
                }
            }

            // 5. feladat
            List<string> legkorábbiÉv = new List<string>();

            foreach (Balkezesek balkezes in balkezesek)
            {
                legkorábbiÉv.Add(balkezes.Első);
            }

            legkorábbiÉv.Sort();
            Console.WriteLine($"\n5. feladat: Legkorábbi év, amikor pályára léptek: {legkorábbiÉv[0].Split('-')[0]}");

            // 6. feladat
            List<int> kétezerElőttiek = new List<int>();
            foreach (Balkezesek balkezes in balkezesek)
            {
                kétezerElőttiek.Add(int.Parse(balkezes.Utolsó.Split('-')[0]));
            }
            Console.WriteLine($"\n6. feladat: Mindenki 2000 előtt lépet pályára? -> {((kétezerElőttiek.Max() > 2000) ? "nem" : "igen")}");

            // 7. feladat
            Console.WriteLine($"\n7. feladat: John nevűek:\n");

            bekértNév = "John";
            int johnDb = 0;
            foreach (Balkezesek balkezes in balkezesek)
            {
                if (balkezes.Név.Split(' ')[0] == bekértNév)
                {
                    johnDb++;
                    Console.WriteLine($"\t{balkezes.Név}");
                }
            }
            Console.WriteLine($"Összes John száma: {johnDb}");

            // 8. feladat
            Dictionary<string, int> keresztnevek = new Dictionary<string, int>();

            foreach (Balkezesek balkezes in balkezesek)
            {
                string név = balkezes.Név.Split(' ')[0];
                if (keresztnevek.ContainsKey(név))
                {
                    keresztnevek[név]++;
                }
                else
                {
                    keresztnevek.Add(név, 1);
                }

            }
            Console.WriteLine("\n8. feladat");
            string[] nevek = { "Joe", "John", "Jim", "Jack" };
            int length = nevek.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{nevek[i]}-ból van: {keresztnevek[nevek[i]]}");
            }

            Console.ReadLine();
        }
    }
}

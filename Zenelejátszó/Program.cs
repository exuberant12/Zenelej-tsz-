using System.Collections.Generic;
using System.IO;

namespace Zenelejátszó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\ujmappa\\playlist.csv", FileMode.Open);
            StreamReader rs = new StreamReader(fs);

            List<string> zenel = new List<string>
            {
                
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - Zeneszámok betöltése listázása");
                Console.WriteLine("2 - Keresés cím szerint");
                Console.WriteLine("3 - Jelenítsd meg a Pop műfajú dalokat");
                Console.WriteLine("4 - Csak az jelenjen meg ahol legalább 3,5 perc nél hosszabb a szám");
                Console.WriteLine("5 - Új zene hozzáadása");
                Console.WriteLine("6 - Zene törlése");
                Console.WriteLine("7 - Zene módosítása");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Clear();
                        int sorszam = 0;
                        foreach (string nevek in zenel)
                        {
                            Console.WriteLine($"{sorszam++}. {nevek}");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Add meg a keresett cím egy részletét:");
                        string keresettCim = Console.ReadLine();
                        foreach (string nevek in zenel)
                        {
                            if (nevek.Contains(keresettCim, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(nevek);
                            }
                        }
                        break;


                }        
            }
        }
    }
}

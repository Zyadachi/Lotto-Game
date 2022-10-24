using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLotto
{
    public static int[] PostawLos()
    {
        int[] liczby = new int[6];
        int liczba = -1;
        for (int i = 0; i < liczby.Length; i++)
        {
            liczba = -1;
            Console.Clear();
            Console.Write("Postawione liczby: ");
            foreach (var l in liczby)
            {
                if (l > 0)
                {
                    Console.Write(l + ", ");
                }
            }
            Console.WriteLine("\n\nWybierz liczbę od 1 do 49:");
            Console.Write("{0}/6: ", i + 1);
            bool prawidlowa = int.TryParse(Console.ReadLine(), out liczba);
            if (prawidlowa && liczba >= 1 && liczba <= 49 && !liczby.Contains(liczba))
            {
                liczby[i] = liczba;

            }
            else
            {
                Console.WriteLine("Niestety, błędna liczba.");
                i--;
                Console.ReadKey();
            }
        }
        Array.Sort(liczby);
        return liczby;
    }
}

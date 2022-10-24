using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLotto
{
    public static int[] SprawdzKupon(List<int[]> kupon, int[] wylosowane)
    {
        int[] wygrane = new int[4];
        int i = 0;
        Console.WriteLine("\n\nTWÓJ KUPON:");
        foreach (int[] los in kupon)
        {
            i++;
            Console.Write(i + ": ");
            int trafien = 0;
            foreach (int liczba in los)
            {
                if (wylosowane.Contains(liczba))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(liczba + ", ");
                    Console.ResetColor();
                    trafien++;
                }
                else
                {
                    Console.Write(liczba + ", ");
                }
            }
            switch (trafien)
            {
                case 3:
                    wygrane[0]++;
                    break;
                case 4:
                    wygrane[1]++;
                    break;
                case 5:
                    wygrane[2]++;
                    break;
                case 6:
                    wygrane[3]++;
                    break;
            }
            Console.WriteLine(" - Trafiono {0}/6", trafien);
        }
        return wygrane;
    }
}

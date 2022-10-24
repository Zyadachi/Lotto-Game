using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLotto
{
    public static int Sprawdz(List<int[]> kupon)
    {

        int[] wylosowane = new int[6];
        for (int i = 0; i < wylosowane.Length; i++)
        {
            int los = rnd.Next(1, 50);
            if (!wylosowane.Contains(los))
            {
                wylosowane[i] = los;
            }
            else
            {
                i--;
            }
        }
        Array.Sort(wylosowane);
        Console.WriteLine("Wylosowane liczby to:");
        foreach (int liczba in wylosowane)
        {
            Console.Write(liczba + ", ");
        }
        int[] trafione = SprawdzKupon(kupon, wylosowane);
        int wartosc = 0;
        int wygrana = 0;

        Console.WriteLine();
        if (trafione[0] > 0)
        {
            wartosc = trafione[0] * 24;
            Console.WriteLine("3 Trafienia: {0} + {1}zł", trafione[0], wartosc);
            wygrana += wartosc;
        }
        if (trafione[1] > 0)
        {
            wartosc = trafione[1] * rnd.Next(100, 301);
            Console.WriteLine("4 Trafienia: {0} + {1}zł", trafione[1], wartosc);
            wygrana += wartosc;
        }
        if (trafione[2] > 0)
        {
            wartosc = trafione[2] * rnd.Next(4000, 8001);
            Console.WriteLine("5 Trafienia: {0} + {1}zł", trafione[2], wartosc);
            wygrana += wartosc;
        }
        if (trafione[3] > 0)
        {
            wartosc = (trafione[3] * kumulacja) / (trafione[3] + rnd.Next(0, 5));
            Console.WriteLine("6 Trafienia: {0} + {1}zł", trafione[3], wartosc);
            wygrana += wartosc;
        }


        return wygrana;
    }
}

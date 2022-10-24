using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLotto
{
    public static void WyswietlKupon(List<int[]> kupon)
    {
        if (kupon.Count == 0)
        {
            Console.WriteLine("Nie postawiłeś jeszcze żadnych losów.");
        }
        else
        {
            int i = 0;
            Console.WriteLine("\nTWÓJ KUPON");
            foreach (int[] los in kupon)
            {
                i++;
                Console.Write(i + ": ");
                foreach (int liczba in los)
                {
                    Console.Write(liczba + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

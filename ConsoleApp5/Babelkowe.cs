using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Babelkowe
    {
        public static void Sort<T>(T[] tab) where T : IComparable
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length-1; j++)
                {
                    if (tab[j].CompareTo(tab[j+1]) > 0)
                    {
                        Swap(tab, j, j+1);
                    }
                }
            }
            show(tab);
        }

        private static void show<T>(T[] tab) where T : IComparable
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        private static void Swap<T>(T[] tab, int first, int second)
        {
            T temp = tab[first];
            tab[first] = tab[second];
            tab[second] = temp;
        }
    }
}

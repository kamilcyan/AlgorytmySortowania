using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Wybieranie
    {
        public static void Sort<T>(T[] tab) where T : IComparable
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = tab[i];
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = tab[j];
                    }
                }
                Swap(tab, i, minIndex);
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

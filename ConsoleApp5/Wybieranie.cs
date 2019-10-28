using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Wybieranie : Showing
    {
        public override void Sort<T>(T[] tab)
        {
            Wybieranie wybieranie = new Wybieranie();
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
                wybieranie.Swap(tab, i, minIndex);
            }
            wybieranie.Show(tab);
        }

        public override void Show<T>(T[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public override void Swap<T>(T[] tab, int first, int second)
        {
            T temp = tab[first];
            tab[first] = tab[second];
            tab[second] = temp;
        }
    }
}

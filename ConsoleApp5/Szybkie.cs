using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Szybkie : IModels
    {
        public static void Sort<T>(T[] tab) where T : IComparable
        {
            Szybkie szybkie = new Szybkie();

            Sort(tab, 0, tab.Length - 1);

            szybkie.Show(tab);
        }

        private static T[] Sort<T>(T[] tab, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(tab, lower, upper);
                Sort(tab, lower, p);
                Sort(tab, p + 1, upper);
            }
            return tab;
        }

        private static int Partition<T>(T[] tab, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = tab[lower];
            Szybkie szybkie = new Szybkie();

            do
            {
                while (tab[i].CompareTo(pivot) < 0) { i++; }
                while (tab[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                szybkie.Swap(tab, i, j);
            }
            while (i <= j);
            return j;
        }

        public void Show<T>(T[] tab) where T : IComparable
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public void Swap<T>(T[] tab, int first, int second)
        {
            T temp = tab[first];
            tab[first] = tab[second];
            tab[second] = temp;
        }
    }
}

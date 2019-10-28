using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Wstawianie : Showing
    {
        public override void Sort<T>(T[] tab)
        {
            Wstawianie wstawianie = new Wstawianie();

            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while (j > 0 && tab[j].CompareTo(tab[j - 1]) < 0)
                {
                    wstawianie.Swap(tab, j, j-1);
                    j--;
                }
            }
            wstawianie.Show(tab);
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

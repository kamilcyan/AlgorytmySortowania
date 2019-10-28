using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Babelkowe : Showing, IModels
    {
        public void Sort<T>(T[] tab) where T : IComparable
        {
            Babelkowe babelkowe = new Babelkowe();

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length-1; j++)
                {
                    if (tab[j].CompareTo(tab[j+1]) > 0)
                    {
                        babelkowe.Swap(tab, j, j+1);
                    }
                }
            }
            babelkowe.Show(tab);
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

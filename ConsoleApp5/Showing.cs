using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Showing : IModels
    {
        public virtual void Show<T>(T[] tab) where T : IComparable
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public virtual void Sort<T>(T[] tab) where T : IComparable
        {
            throw new NotImplementedException();
        }

        public virtual void Swap<T>(T[] tab, int first, int second)
        {
            T temp = tab[first];
            tab[first] = tab[second];
            tab[second] = temp;
        }
    }
}

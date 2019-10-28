using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IModels
    {
        void Show<T>(T[] tab) where T : IComparable;
        void Swap<T>(T[] tab, int first, int second);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IModels
    {
        void Sort<T>(T[] tab) where T : IComparable;
    }
}

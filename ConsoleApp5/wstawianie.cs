﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Wstawianie
    {
        public static void Sort<T>(T[] tab) where T : IComparable
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while (j > 0 && tab[j].CompareTo(tab[j - 1]) < 0)
                {
                    Swap(tab, j, j-1);
                    j--;
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
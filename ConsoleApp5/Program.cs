using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        enum Sortowanie
        {
            wybieranie,
            wstawianie,
            babelkowe,
            szybkie
        };

        static void Main(string[] args)
        {
            int[] tab = new int[10] { 1, 4, 14, -3, 22, 17, 102, 44, -90, 8 };

            Console.WriteLine("Ktore sortowanie?");

            string[] values = Enum.GetNames(typeof(Sortowanie));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            string chosen = Console.ReadLine();
            
            Sortowanie chose = (Sortowanie)Enum.Parse(typeof(Sortowanie), chosen, true);
            
            switch ((int)chose)
            {
                case 0:
                    Wybieranie.Sort(tab);
                    break;
                case 1:
                    Wstawianie.Sort(tab);
                    break;
                case 2:
                    Babelkowe.Sort(tab);
                    break;
                case 3:
                    Szybkie.Sort(tab);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}

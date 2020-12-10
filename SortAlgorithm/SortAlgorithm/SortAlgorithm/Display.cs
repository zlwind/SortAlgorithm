using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithm
{
    class Display
    {
        public static void DisPlayData(int[] arr)
        {
            foreach (int aa in arr)
            {
                Console.Write("{0} ", aa);
            }
            Console.WriteLine();
            Console.WriteLine("************************************************");
        }
        public static void DisPlayText(string text)
        {
            Console.WriteLine(text);
        }
    }
}

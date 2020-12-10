using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithm
{
    class DataCreate
    {
        static int[] arr;
        static List<int> list;
        static Random r = new Random();
        static int min = -100;
        static int max = 100;
        public static int[] Data(int length)
        {
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = r.Next(min,max);
            }
            return arr;
        }
        public static List<int> DataList(int length)
        {
            list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                list.Add(r.Next(min, max));
            }
            return list;
        }
        public static int[] Data(int length,int min,int max)
        {
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }
    }
}

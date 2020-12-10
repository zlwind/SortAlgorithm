using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SortAlgorithm
{
    class Test
    {
        static Stopwatch spw = new Stopwatch();
        static string str = null;
        static int corrextLeng=8;
        static int[] a;
        static int timeLeng=80000;

        
        /// <summary>
        /// 排序算法正确性测试
        /// </summary>
        public static void CorrectCheck()
        {
            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("1 排序前数据");
            Display.DisPlayData(a);
            int[] ba = Sort.BubbleSort(a);
            Display.DisPlayText("冒泡排序后数据");
            Display.DisPlayData(ba);


            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("2 排序前数据");
            Display.DisPlayData(a);
            int[] sa = Sort.SelectSort(a);
            Display.DisPlayText("选择排序后数据");
            Display.DisPlayData(sa);

            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("3 排序前数据");
            Display.DisPlayData(a);
            int[] ia = Sort.InsertionSort(a);
            Display.DisPlayText("插入排序后数据");
            Display.DisPlayData(ia);

            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("4.1 排序前数据");
            Display.DisPlayData(a);
            int[] sas = Sort.ShellSortSawp(a);
            Display.DisPlayText("希尔排序（交换式）后数据");
            Display.DisPlayData(sas);

            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("4.2 排序前数据");
            Display.DisPlayData(a);
            int[] sai = Sort.ShellSortInsert(a);
            Display.DisPlayText("希尔排序（插入式）后数据");
            Display.DisPlayData(sai);

            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("5 排序前数据");
            Display.DisPlayData(a);
            int[] qa = Sort.QuickSort(a,0,a.Length-1);
            Display.DisPlayText("快速排序后数据");
            Display.DisPlayData(qa);


            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("6 排序前数据");
            Display.DisPlayData(a);
            int[] ma = Sort.MergeSort(a, 0, a.Length - 1);
            Display.DisPlayText("归并排序后数据");
            Display.DisPlayData(ma);

            a = DataCreate.Data(corrextLeng,95,100);
            Display.DisPlayText("7 排序前数据");
            Display.DisPlayData(a);
            int[] ca = Sort.CountingSort(a);
            Display.DisPlayText("计数排序后数据");
            Display.DisPlayData(ca);

            a = DataCreate.Data(corrextLeng, 1, 1000);
            Display.DisPlayText("8 排序前数据");
            Display.DisPlayData(a);
            int[] buca = Sort.BucketSort(a);
            Display.DisPlayText("桶排序后数据");
            Display.DisPlayData(buca);

            a = DataCreate.Data(corrextLeng, 1, 10000);
            Display.DisPlayText("9 排序前数据");
            Display.DisPlayData(a);
            int[] ra = Sort.RadixSort(a);
            Display.DisPlayText("基数排序后数据");
            Display.DisPlayData(ra);


            a = DataCreate.Data(corrextLeng);
            Display.DisPlayText("10 排序前数据");
            Display.DisPlayData(a);
            int[] ha = Sort.HeapSort(a);
            Display.DisPlayText("堆排序后数据");
            Display.DisPlayData(ha);
        }
        /// <summary>
        /// 不同排序算法时间复杂度性能测试
        /// </summary>
        public static void TimeCheck() 
        {
            a = DataCreate.Data(timeLeng);
            spw.Start();
            int[] ba = Sort.BubbleSort(a);
            spw.Stop();
            str = String.Format("冒泡排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);


            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] sa = Sort.SelectSort(a);
            spw.Stop();
            str = String.Format("选择排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] ia = Sort.InsertionSort(a);
            spw.Stop();
            str = String.Format("插入排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] sas = Sort.ShellSortSawp(a);
            spw.Stop();
            str = String.Format("希尔(交换式)排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] sai = Sort.ShellSortInsert(a);
            spw.Stop();
            str = String.Format("希尔(插入式)排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] qa = Sort.QuickSort(a,0,a.Length-1);
            spw.Stop();
            str = String.Format("快速排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] ma = Sort.MergeSort(a, 0, a.Length - 1);
            spw.Stop();
            str = String.Format("归并排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng,95,100);
            spw.Restart();
            int[] ca = Sort.CountingSort(a);
            spw.Stop();
            str = String.Format("计数排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng, 1, 10000);
            spw.Restart();
            int[] buca = Sort.BucketSort(a);
            spw.Stop();
            str = String.Format("桶排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng, 1, 100000);
            spw.Restart();
            int[] ra = Sort.RadixSort(a);
            spw.Stop();
            str = String.Format("基数排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);

            a = DataCreate.Data(timeLeng);
            spw.Restart();
            int[] ha = Sort.HeapSort(a);
            spw.Stop();
            str = String.Format("堆排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);


            List<int> lt = DataCreate.DataList(timeLeng);
            spw.Restart();
            lt.Sort();
            spw.Stop();
            str = String.Format(".net 泛型数据结构排序：{0}数据 耗时：{1}毫秒", timeLeng, spw.ElapsedMilliseconds);
            Display.DisPlayText(str);
        }

    }
}

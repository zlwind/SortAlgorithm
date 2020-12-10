using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithm
{
    class Sort
    {
       
        /// <summary>
        ///    1、冒泡排序（Bubble Sort）
        ///    冒泡排序是一种简单的排序算法。它重复地走访过要排序的数列，一次比较两个元素，如果它们的顺序错误就把它们交换过来。走访数列的工作是重复地进行直到没有再需要交换，也就是说该数列已经排序完成。这个算法的名字由来是因为越小的元素会经由交换慢慢“浮”到数列的顶端。 
        ///     1.1 算法描述
        ///    比较相邻的元素。如果第一个比第二个大，就交换它们两个；
        ///    对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对，这样在最后的元素应该会是最大的数；
        ///    针对所有的元素重复以上的步骤，除了最后一个；
        ///    重复步骤1~3，直到排序完成。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)//共有arr.Length - 1轮
            {
                bool isExchange = false;
                for (int j = 0; j < arr.Length - 1-i; j++)//每1轮将最大值通过交换方式放到数组最末端
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //数据交换
                        isExchange = true;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                //如果不再发生交换 说明数组已经顺序排列 直接退出循环
                if (!isExchange)
                { 
                    break; 
                }
            }
            return arr;
        }
        /// <summary>
        ///    2、选择排序（Selection Sort）
        ///       选择排序(Selection-sort)是一种简单直观的排序算法。它的工作原理：首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置，然后，再从剩余未排序元素中继续寻找最小（大）元素，然后放到已排序序列的末尾。以此类推，直到所有元素均排序完毕。 
        ///    2.1 算法描述
        ///       n个记录的直接选择排序可经过n-1趟直接选择排序得到有序结果。具体算法描述如下：
        ///       初始状态：无序区为R[1..n]，有序区为空；
        ///       第i趟排序(i=1,2,3…n-1)开始时，当前有序区和无序区分别为R[1..i-1]和R(i..n）。
        ///       该趟排序从当前无序区中-选出关键字最小的记录 R[k]，将它与无序区的第1个记录R交换，
        ///       使R[1..i]和R[i+1..n)分别变为记录个数增加1个的新有序区和记录个数减少1个的新无序区；
        ///       n-1趟结束，数组有序化了。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)//共有arr.Length - 1轮 从后面数组中找出最小值
            {
                int index=i;
                int min = arr[i];
                for (int j = i+1; j < arr.Length; j++)//后面数组找出最小值
                {
                    if ( min>arr[j])
                    {
                        min= arr[j];
                        index=j;
                    }
                }
                if (index != i)//将最小值存放在起始位置
                {
                    arr[index] = arr[i];
                    arr[i] = min;
                }
            }
            return arr;
        }


        /// <summary>
        ///  3、插入排序（Insertion Sort）
        ///插入排序（Insertion-Sort）的算法描述是一种简单直观的排序算法。它的工作原理是通过构建有序序列，对于未排序数据，在已排序序列中从后向前扫描，找到相应位置并插入。
        ///    3.1 算法描述
        ///一般来说，插入排序都采用in-place在数组上实现。具体算法描述如下：
        ///从第一个元素开始，该元素可以认为已经被排序；
        ///取出下一个元素，在已经排序的元素序列中从后向前扫描；
        ///如果该元素（已排序）大于新元素，将该元素移到下一位置；
        ///重复步骤3，直到找到已排序的元素小于或者等于新元素的位置；
        ///将新元素插入到该位置后；
        ///重复步骤2~5。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)//共有arr.Length-1轮
            {
                int value = arr[i];//取无序数组元素
                int preIndex = i - 1;//最新有序数组指针
                while (preIndex >= 0 && value < arr[preIndex])//从后面无序数组中找到小的值
                {
                    arr[preIndex + 1] = arr[preIndex];//前面有序数组进行移位
                    preIndex--;//指针前移
                }
                if (preIndex + 1 != i)
                {
                    arr[preIndex + 1] = value;//将无序数组元素插入有序数组相应位置
                }
            }
            return arr;
        }
        /// <summary>
        /// 希尔排序（交换式）
        /// 4、希尔排序（Shell Sort）
        ///1959年Shell发明，第一个突破O(n2)的排序算法，是简单插入排序的改进版。它与插入排序的不同之处在于，它会优先比较距离较远的元素。希尔排序又叫缩小增量排序。
        ///4.1 算法描述
        ///先将整个待排序的记录序列分割成为若干子序列分别进行直接插入排序，具体算法描述：
        ///选择一个增量序列t1，t2，…，tk，其中ti>tj，tk=1；
        ///按增量序列个数k，对序列进行k 趟排序；
        ///每趟排序，根据对应的增量ti，将待排序列分割成若干长度为m 的子序列，分别对各子表进行直接插入排序。仅增量因子为1 时，整个序列作为一个表来处理，表长度即为整个序列的长度。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ShellSortSawp(int[] arr)
        {
            for (int gap = arr.Length / 2; gap > 0; gap=gap/2)//设置增量间隔
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    for (int j = i - gap; j > -1; j -= gap)
                    {
                        if (arr[j] > arr[j + gap])//增量间隔之间数据进行比较
                        {
                            //数据交换
                            int temp = arr[j];
                            arr[j] = arr[j + gap];
                            arr[j + gap] = temp;
                        }
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 希尔排序（插入式）
        /// 4、希尔排序（Shell Sort）
        ///1959年Shell发明，第一个突破O(n2)的排序算法，是简单插入排序的改进版。它与插入排序的不同之处在于，它会优先比较距离较远的元素。希尔排序又叫缩小增量排序。
        ///4.1 算法描述
        ///先将整个待排序的记录序列分割成为若干子序列分别进行直接插入排序，具体算法描述：
        ///选择一个增量序列t1，t2，…，tk，其中ti>tj，tk=1；
        ///按增量序列个数k，对序列进行k 趟排序；
        ///每趟排序，根据对应的增量ti，将待排序列分割成若干长度为m 的子序列，分别对各子表进行直接插入排序。仅增量因子为1 时，整个序列作为一个表来处理，表长度即为整个序列的长度。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ShellSortInsert(int[] arr)
        {
            for (int gap = arr.Length / 2; gap > 0; gap = gap / 2)//设置增量间隔
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int j = i;
                    int temp = arr[j];
                    while (j - gap > -1 && temp < arr[j - gap])//增量间隔之间的数据进行比较
                    {
                        arr[j] = arr[j - gap];//数据位移
                        j = j - gap;
                    }
                    arr[j] = temp;//将数据插入有序数组位置
                }
            }
            return arr;
        }

        /// <summary>
        /// 5、快速排序（Quick Sort）
        ///快速排序的基本思想：通过一趟排序将待排记录分隔成独立的两部分，其中一部分记录的关键字均比另一部分的关键字小，则可分别对这两部分记录继续进行排序，以达到整个序列有序。
        ///6.1 算法描述
        ///快速排序使用分治法来把一个串（list）分为两个子串（sub-lists）。具体算法描述如下：
        ///从数列中挑出一个元素，称为 “基准”（pivot）；
        ///重新排序数列，所有元素比基准值小的摆放在基准前面，所有元素比基准值大的摆在基准的后面（相同的数可以到任一边）。在这个分区退出之后，该基准就处于数列的中间位置。这个称为分区（partition）操作；
        ///递归地（recursive）把小于基准值元素的子数列和大于基准值元素的子数列排序。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] QuickSort(int[] arr,int left,int right)
        {
            //获取数组左指针 右指针 中间值
            int l = left;
            int r = right;
            int midValue=arr[(l+r)/2];
            //将 小于中间值移到左边 大于中间值移到右边
            while (l < r)
            {
                while (arr[l] < midValue)//左指针获取大于中间值
                { l++; }
                while (arr[r] > midValue)//右指针获取小于中间值
                { r--; }
                if (l >= r)//左右指针遍历完成
                { break; }
                else
                {
                    //小于中间值移到左边 大于中间值移到右边
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    //边界处理 说明有一边已经顺序排列
                    if (arr[r] == midValue)
                    { l++; }
                    if (arr[l] == midValue)
                    { r--; }
                   
                }
            }
            //边界处理 说明数组已经顺序排列
            if (l == r)
            {
                l++;
                r--;
            }
            //快速排序 左递归
            if (left < r)
            {
                QuickSort(arr, left, r);
            }
            //快速排序 右递归
            if (right > l)
            {
                QuickSort(arr, l, right);
            }
            return arr;
        }

        /// <summary>
        /// 6、归并排序（Merge Sort）
        ///归并排序是建立在归并操作上的一种有效的排序算法。
        ///该算法是采用分治法（Divide and Conquer）的一个非常典型的应用。
        ///将已有序的子序列合并，得到完全有序的序列；即先使每个子序列有序，再使子序列段间有序。
        ///若将两个有序表合并成一个有序表，称为2-路归并。 
        ///6.1 算法描述
        ///把长度为n的输入序列分成两个长度为n/2的子序列；
        ///对这两个子序列分别采用归并排序；
        ///将两个排序好的子序列合并成一个最终的排序序列。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MergeSort(int[] arr,int left,int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
               
                //左递归分解
             //   Console.WriteLine("左递归 left={0} mid={1} right={2}", left, mid, right);
                MergeSort(arr,left,mid);
                //右递归分解
           //     Console.WriteLine("右递归 left={0} mid={1} right={2}", left, mid, right);
                MergeSort(arr, mid+1, right);
                merge(arr,left,mid,right);
            }
            return arr;
        }
        /// <summary>
        /// 归并算法的合并代码
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        private static void merge(int[] arr,int left,int mid,int right)
        {
           // Console.WriteLine("left={0} mid={1} right={2}", left, mid, right);
            int i = left;
            int j = mid + 1;
            int t=0;
            int[] temp = new int[right + 1];
            //将左右两边的有序数组按照规则填充到temp数组
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                { temp[t++] = arr[i++]; }
                else
                {
                    temp[t++] = arr[j++]; 
                }
            }
            //把有剩余数据部分的数据依次全部填充到temp
            while (i <= mid)
            {
                temp[t++] = arr[i++]; 
            }
            while (j <= right)
            {
                temp[t++] = arr[j++];
            }
            //将temp数组的数据拷贝到arr
            t = 0;
            for (int k = left; k <= right; k++)
            {
                arr[k] = temp[t++];
            }
            
        }



        /// <summary>
        /// 7、计数排序（Counting Sort）
        ///计数排序不是基于比较的排序算法，其核心在于将输入的数据值转化为键存储在额外开辟的数组空间中。
        ///作为一种线性时间复杂度的排序，计数排序要求输入的数据必须是有确定范围的整数。
        ///7.1 算法描述
        ///找出待排序的数组中最大和最小的元素；
        ///统计数组中每个值为i的元素出现的次数，存入数组C的第i项；
        ///对所有的计数累加（从C中的第一个元素开始，每一项和前一项相加）；
        ///反向填充目标数组：将每个元素i放在新数组的第C(i)项，每放一个元素就将C(i)减去1
        ///计数排序算法 虽然它可以将排序算法的时间复杂度降低到O(N)，
        ///但是有两个前提需要满足：
        ///      一是需要排序的元素必须是整数，
        ///      二是排序元素的取值要在一定范围内，并且比较集中。
        ///      只有这两个条件都满足，才能最大程度发挥计数排序的优势。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] CountingSort(int[] arr)
        {
            //1.获取数组最大值 最小值 数组范围 计数数组
            int min = arr.Min();
            int max = arr.Max();
            int range = max - min + 1;
            int[] count = new int[range];
            //2.遍历数组 统计对应元素的个数
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }
            //3.统计数组变形，后面的元素等于前面的元素之和 保证排序的稳定性
            int sum = 0;
            for (int i = 0; i < count.Length; i++)
            {
                sum += count[i];
                count[i] = sum;
            }
            //4.倒序遍历原始数组，从统计数组找到正确位置，输出到结果数组
            int[] sortArr = new int[arr.Length];
            for (int i = arr.Length-1; i >-1; i--)
            { 
                int index=count[arr[i]-min]-1;
                sortArr[index] = arr[i];
                count[arr[i] - min]--;
            }
            return sortArr;
        }


        /// <summary>
        /// 8、桶排序（Bucket Sort）
        ///桶排序是计数排序的升级版。它利用了函数的映射关系，高效与否的关键就在于这个映射函数的确定。桶排序 (Bucket sort)的工作的原理：假设输入数据服从均匀分布，将数据分到有限数量的桶里，每个桶再分别排序（有可能再使用别的排序算法或是以递归方式继续使用桶排序进行排）。
        ///桶排序是计数排序的升级版，优化计数排序中数的范围比较大的情况
        /// 8.1 算法描述
        ///设置一个定量的数组当作空桶；
        ///遍历输入数据，并且把数据一个一个放到对应的桶里去；
        ///对每个不是空的桶进行排序；
        ///从不是空的桶里把排好序的数据拼接起来。 
        ///桶排序特点
        ///桶排序的的快慢取决于数据的分布：
        ///当输入的数据可以均匀的分配到每一个桶中，排序最快
        ///当输入的数据被分配到了同一个桶中，排序最慢
        ///关键点：
        ///每一个桶中有多少个数
        ///每一个数应该放到哪一个桶中
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BucketSort(int[] arr)
        {
            //获取数组的最大值 最小值 设置桶内元素的取值范围，计算桶的个数 声明桶
            int bucketRange = 5;//桶内元素的取值范围
            int max = arr.Max();
            int min = arr.Min();
            int bucketCount = (max - min) /bucketRange + 1;//桶的个数
            int[][] bucket = new int[bucketCount][];

            int[] count = new int[bucketCount];//确定每一个痛的容量
            //遍历待排序数组，计算每个桶的容量
            for (int i = 0; i < arr.Length; i++)
            {
                count[(arr[i] - min) / bucketRange]++;
            }
            //声明每个桶的长度
            for (int i = 0; i < bucketCount;i++)
            {
                bucket[i] = new int[count[i]];
            }
            //将待排序元素存入对应的桶中
            for (int i = 0; i < arr.Length; i++)
            {
                int k = (arr[i] - min) / bucketRange;
                bucket[k][--count[k]] = arr[i];
            }
            //将桶中数据进行拼接输出
            int index = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                if (bucket[i].Length > 0)//判断桶是不是为空
                {
                    bucket[i]=InsertionSort(bucket[i]);//对不为空的桶的数据进行插入排序
                    for (int j = 0; j < bucket[i].Length; j++)//对桶中数据按顺序取出
                    {
                        arr[index++] = bucket[i][j];
                    }
                }
            }
            return arr;
        }


        /// <summary>
        /// 9、基数排序（Radix Sort）
        ///基数排序是按照低位先排序，然后收集；再按照高位排序，然后再收集；依次类推，直到最高位。
        ///有时候有些属性是有优先级顺序的，先按低优先级排序，再按高优先级排序。最后的次序就是高优先级高的在前，高优先级相同的低优先级高的在前。
        ///9.1 算法描述
        ///取得数组中的最大数，并取得位数；
        ///arr为原始数组，从最低位开始取每个位组成radix数组；
        ///对radix进行计数排序（利用计数排序适用于小范围数的特点）；
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] RadixSort(int[] arr)
        {
            //获取数组最大值的长度，确定按照高低位循环的次数
            int maxLeng = arr.Max().ToString().Length;
            //定义0-9 10个编号的桶
            int[][] bucket = new int[10][];
            //定义数据位数统计个数 用于声明每个桶的长度
            int[] count = new int[10];

            //数据除以dev，再模10 取数据的每一位(dev=1,10,100....)
            //i依次个位 十位...maxLeng位
            for (int i = 0, dev = 1; i <maxLeng; i++, dev = dev * 10)
            {
                //统计位数对应桶编号的个数
                for (int j = 0; j < arr.Length; j++)
                {
                    int index = (int)(arr[j] / dev )% 10;
                    count[index]++;
                }
                //声明每一个编号桶对应的长度
                for (int j = 0; j < 10; j++)
                {
                    bucket[j] = new int[count[j]];
                    count[j] = 0;//重新置位统计个数
                }
                //将数据每一位分配保存到对应的桶编号中
                for (int j = 0; j < arr.Length; j++)
                {
                    int index = (int)(arr[j] / dev) % 10;
                    bucket[index][count[index]++] = arr[j];
                }
                //将统计数组重新置零
                for (int j = 0; j < 10; j++)
                {
                    count[j] = 0;//重新置位统计个数
                }
                //将桶中的数据按顺序填充回数组
                int arrIndex = 0;//定义数组的指针
                for (int k = 0; k < 10; k++)
                {
                    if (bucket[k].Length > 0)
                    {
                        for (int j = 0; j < bucket[k].Length; j++)
                        {
                            arr[arrIndex++] = bucket[k][j];
                        }
                    }
                }
            }

            return arr;
        }

        /// <summary>
        ///  /// 10、堆排序（Heap Sort）
        ///堆排序（Heapsort）是指利用堆这种数据结构所设计的一种排序算法。
        ///堆积是一个近似完全二叉树的结构，并同时满足堆积的性质：即子结点的键值或索引总是小于（或者大于）它的父节点。
        ///10.1 算法描述
        ///将初始待排序关键字序列(R1,R2….Rn)构建成大顶堆，此堆为初始的无序区；
        ///将堆顶元素R[1]与最后一个元素R[n]交换，此时得到新的无序区(R1,R2,……Rn-1)和新的有序区(Rn),且满足R[1,2…n-1]小于等于R[n].
        ///由于交换后新的堆顶R[1]可能违反堆的性质，因此需要对当前无序区(R1,R2,……Rn-1)调整为新堆，
        ///然后再次将R[1]与无序区最后一个元素交换，得到新的无序区(R1,R2….Rn-2)和新的有序区(Rn-1,Rn)。
        ///不断重复此过程直到有序区的元素个数为n-1，则整个排序过程完成。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] HeapSort(int[] arr)
        {
            //从下到上，确定非叶子节点索引，进行大顶堆构建
            //第n个节点的对应非叶子节点索引（n-1）/2
            //因此最低端节点索引：n=arr.Length-1 最低端二叉树对应非叶子节点索引 （arr.Length-1-1）/2=arr.Length / 2 - 1
            for (int i = arr.Length / 2 - 1; i > -1; i--)
            {
                arr = AdjustMaxHeapCir(arr, i, arr.Length);
               // arr = AdjustMaxHeapRec(arr, i, arr.Length);
            }
            //1.大顶堆构建完成
            //2 将数组首末值进行交换，将交换后数组末尾移除 即数组长度减1
            //3重新构建大顶堆
            //循环2,3步，得到有序数组，循环次数arr.Length-1次

            //1.每次在构建好最大堆后，将第一个元素和最后一个元素交换； 
            //2.第一次以索引0到length-1出的元素组成新的堆，第二次0到length-2，直到剩下最后两个元素组成堆 
            //3 因为交换后，只有索引0的元素发生变动，其他元素不变，在构建大顶堆时，只需要考察索引0的非叶子节点即可
            //4.每次新组成的堆除了根节点其他节点都能保持最大堆的特性，因此只要arr=AdjustMaxHeapCir(arr,0,j);就可以得到新的最大堆 
            int temp;
            for (int j = arr.Length - 1; j > 0; j--)
            {
                //arr数组首末位数据交换
                temp = arr[j];
                arr[j] = arr[0];
                arr[0] = temp;
                //因为交换后，只有索引0的元素发生变动，其他元素不变，在构建大顶堆时，只需要考察索引0的非叶子节点即可
                //交换完成后，末尾移除，arr长度减1 继续构建大顶堆
                arr = AdjustMaxHeapCir(arr, 0, j);
                //arr = AdjustMaxHeapRec(arr, 0, j);
            }
            return arr;
        }

        /// <summary>
        /// 调整二叉树为大顶堆(递归方式)
        /// 如何构造最大堆。 
        /// 万事开头难，首先来看一种特殊的情形吧：堆的根节点的左子树和右子树都已经是最大堆了，
        /// 然而根节点却比孩子节点小，当然，这个堆不满足最大堆的定义。为了⑩这个堆成为最大堆，我们可以按如下步骤操作： 
        ///（1）将根节点与左右孩子中最大的交换 
        ///（2）交换之后可能会面临左或右子树不是最大堆的问题，但由于整个左(右)子树一开始就是最大堆，
        ///     问题又回到了最开始的状态，因此只要如此反复即可得到最大堆。 
        /// 对于一般意义上的堆
        /// 我们可以选择自底向上来构造：叶子节点是特殊的最大堆，举个例子有叶子节点a,b,它们的父节点是p;a,b肯定已经是最大堆了，
        /// 这是要保证a,b,p组成的子树是最大堆。这个堆很眼熟是不是？
        /// 没错，它就是前面提到的特殊的堆。在a,b,p组成的子树变成最大堆后，我们又可以类似的使该子树，
        /// 该子树的父节点，以及同胞子树（或节点）组成的新子树成为最大堆，如此类推，最终使堆变为最大堆。 
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="i">非叶子节点索引</param>
        /// <returns></returns>
        private static int[] AdjustMaxHeapRec(int[] arr, int i,int length)
        {
            int left = 2 * i + 1;//第i节点对应的左子节点索引
            int right = left + 1;//第i节点对应的右子节点索引
            int temp=arr[i];//保存第i个非叶子节点的值
            int largeIndex = i;//最大值的索引指针
            if (left < length &&arr[left]>arr[largeIndex])//左子节点与与父节点比较
            {
                largeIndex = left;//指针指向最大值节点
            }
            if (right < length&&arr[right]>arr[largeIndex])//右子节点与最大值节点比较
            {
                largeIndex = right;//指针指向最大值节点
            }
            if (largeIndex != i)//最大值指针改变 说明父节点不是最大值 否则说明已经是大顶堆
            {
                arr[i] = arr[largeIndex];
                arr[largeIndex] = temp;//进行交换到父节点
                //子节点发生变动，将指针指向已经变动的子节点，进行递归，查看该节点与其左右子节点是否还是大顶堆
                AdjustMaxHeapRec(arr, largeIndex,length);
            }

            return arr;
        }

        /// <summary>
        /// 调整二叉树为大顶堆(循环方式)
        /// 如何构造最大堆。 
        /// 万事开头难，首先来看一种特殊的情形吧：堆的根节点的左子树和右子树都已经是最大堆了，
        /// 然而根节点却比孩子节点小，当然，这个堆不满足最大堆的定义。为了⑩这个堆成为最大堆，我们可以按如下步骤操作： 
        ///（1）将根节点与左右孩子中最大的交换 
        ///（2）交换之后可能会面临左或右子树不是最大堆的问题，但由于整个左(右)子树一开始就是最大堆，
        ///     问题又回到了最开始的状态，因此只要如此反复即可得到最大堆。 
        /// 对于一般意义上的堆
        /// 我们可以选择自底向上来构造：叶子节点是特殊的最大堆，举个例子有叶子节点a,b,它们的父节点是p;a,b肯定已经是最大堆了，
        /// 这是要保证a,b,p组成的子树是最大堆。这个堆很眼熟是不是？
        /// 没错，它就是前面提到的特殊的堆。在a,b,p组成的子树变成最大堆后，我们又可以类似的使该子树，
        /// 该子树的父节点，以及同胞子树（或节点）组成的新子树成为最大堆，如此类推，最终使堆变为最大堆。
        /// 采用先左后右的顺序
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="i">非叶子节点索引</param>
        /// <returns></returns>
        private static int[] AdjustMaxHeapCir(int[] arr, int i,int length)
        {
            int temp = arr[i];//保存非叶子节点的值
            //i节点对应的左子节点索引为2*i+1 右子节点索引为2*i+2
            //k = 2 * k + 1表示k索引的非叶子节点对应的左子节点索引
            for (int k = 2 * i + 1; k < length; k = 2 * k + 1)
            {
                if (k + 1 < length && arr[k] < arr[k + 1])//左右子节点比较 如果右子节点大于左子节点
                {
                    k++;//将原来指向左子节点的k指向更大值的右子节点
                }
                if (arr[k] > temp)//如果左子节点或者有子节点大于i父节点
                {
                    arr[i] = arr[k];//将最大值移至i的非叶子节点处 
                    //!!!!temp仍然等于最开始的非叶子节点值，他被交换到变动的子节点处
                    //下次循环以该变动的子节点作为非叶子节点，考察大顶堆结构是否改变
                    //因此 temp值并没有改变
                    i = k;//i指向k，继续循环 考察已经变化的k子节点作为新的非叶子结点，是否还是大顶堆解读
                }
                else
                {
                    //因为是从下到上构建大顶堆
                    //说明父节点就是最大值，不用进行交换
                    //因此，也没有破坏已经构建好的下边的大顶堆结构，循环可以直接退出
                    break;
                }
            }
            //for循环结束后，i及以下非叶子节点都已经调整为大顶堆结构
            // i已经指向变动的子节点
            // 将原先非叶子节点比较小的值赋值给变动的节点位置，完成最后的调整
            // temp=a  b>a 则a=b,b=temp,在以b为非叶子节点，循环考察
            //因此循环考察的非叶子节点的值 始终是temp，即最开始非叶子节点的值
            //只是在循环完成后，最后将temp值赋值给变动的节点 完成交换
            arr[i] = temp;
            return arr;
        }
        
    }
}

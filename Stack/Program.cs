using System;
using System.Diagnostics;
using System.Threading;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ListStack
            Console.WriteLine("Алгортим");
            var stackRdy = new Model.Stack<int>();           
            stackRdy.Push(1);
            Console.WriteLine(stackRdy.Peek());
            #endregion
            #region Types Of Sorting
            Console.WriteLine("");
            int amountElems = 5000;
            Random rnd = new Random();
            var array = new int[100000];  
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(amountElems);
            }
            foreach (var arr in array)
            {
                //Console.Write(arr + " ");
            }
            Console.WriteLine();

            var dopArr = array;

            Stopwatch sw = new Stopwatch();
            var time=sw.Elapsed;
           
            sw.Start();
            CountingSort.countingSort(dopArr, 0, amountElems-1);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Counting Sort: " + time);
            sw.Reset();
            
            dopArr = array;
            sw.Start();
            // Console.WriteLine("Array in insert sort: {0}", string.Join(" / ", InsertSort.InsertionSort(array)));
            InsertSort.InsertionSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Insertion Sort"+time);
            sw.Reset();

            dopArr = array;
            sw.Start();
            MergeSort.MergeSorting(dopArr, 0, array.Length);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Merge Sort: " + time);
            sw.Reset();

            dopArr = array;
            sw.Start();
            BubbleSort.bubbleSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Bubble Sort: " + time);
            sw.Reset();

            dopArr = array;
            sw.Start();
            ShellSort.shellSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of shell Sort: " + time);
            sw.Reset();

            dopArr = array;
            sw.Start();
            QuickSort.quickSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of quick Sort: " + time);
            sw.Reset();


            #endregion
            #region SelecProblem
            Console.Write("Selected activities:");
            int[] f = { 1, 3, 0, 5, 8, 5 };
            int[] l = { 2, 4, 6, 7, 9, 9 };
            int n = f.Length;
            ChangeEvent.choose(n, f, l);
            #endregion
            #region Dynamic
            Dynamic.check("abcdfd", "assbcd");
            #endregion
            Console.ReadLine();
        }
        
    }
}
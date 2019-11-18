using System;
using System.Diagnostics;
using System.Threading;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#region ListStack
            Console.WriteLine("Алгортим");
            var stackRdy = new Model.Stack<int>();           
            stackRdy.Push(1);
            stackRdy.Push(40);
            stackRdy.Push(532);
            stackRdy.Pop();
            Console.WriteLine(stackRdy.Peek() + " " + stackRdy.Pop()+ " "+stackRdy.Peek());
            #endregion
            #region Types Of Sorting
            Console.WriteLine("Generated array");
            int amountElems = 5;
            Random rnd = new Random();
            var array = new int[60];  
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(amountElems);
            }
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine("\n");

            var dopArr = array;

            Stopwatch sw = new Stopwatch();
            var time=sw.Elapsed;
            sw.Reset();
            //Counting sort
            sw.Start();
            CountingSort.countingSort(dopArr, 0, amountElems-1);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Counting Sort: " + time);
            Console.WriteLine("Array in Counting Sort: {0}", string.Join("/", CountingSort.countingSort(dopArr,0,amountElems-1)));
            Console.WriteLine();
            sw.Reset();
            
            //Insert sort
            dopArr = array;
            sw.Start();
            // Console.WriteLine("Array in insert sort: {0}", string.Join(" / ", InsertSort.InsertionSort(array)));
            InsertSort.InsertionSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            //Console.WriteLine("Time of Insertion Sort"+time);
            sw.Reset();

            //Merge sort
            dopArr = array;
            sw.Start();
            //MergeSort.MergeSorting(dopArr, 0, array.Length);

            sw.Stop();
            //Console.WriteLine("Array in insert sort: {0}", string.Join(" / ", MergeSort.MergeSorting(dopArr,0,dopArr.Length)));
            time = sw.Elapsed;
            //Console.WriteLine("Time of Merge Sort: " + time);
            sw.Reset();

            //Bubble sort
            dopArr = array;
            sw.Start();
            BubbleSort.bubbleSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Bubble Sort: " + time);
            Console.WriteLine("Array in Bubble sort: {0}", string.Join(" / ", BubbleSort.bubbleSort(dopArr)));
            Console.WriteLine();
            sw.Reset();

            //Shell sort
            dopArr = array;
            sw.Start();
            ShellSort.shellSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Shell Sort: " + time);
            Console.WriteLine("Array in Shell sort: {0}", string.Join(" / ", ShellSort.shellSort(dopArr)));
            Console.WriteLine();
            sw.Reset();

            //Quick sort
            dopArr = array;
            sw.Start();
            // QuickSort.quickSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
           // Console.WriteLine("Time of quick Sort: " + time);
            sw.Reset();
            

            #endregion
            
            #region SelecProblem
            Console.Write("Selected activities:");
             //int[] f = { 1, 3, 0, 5, 8, 5 };
             //int[] l = { 2, 4, 6, 7, 9, 9 };
            int[] f = {10,12,20,21,26};
            int[] l = {20,25,25,40,35};
            int n = f.Length;
            ChangeEvent.choose(n, f, l);
            #endregion
            #region Dynamic
            Dynamic.check("abcdfd", "adasdacdfd");
            #endregion*/
            #region BinaryTree
            var tree = new BinaryTree();
            tree.Insert(55);
            tree.Insert(100);
            tree.Insert(77);
            BinaryTreeOutput.Print(tree);
            #endregion 
            Console.ReadLine();
        }
        
    }
}

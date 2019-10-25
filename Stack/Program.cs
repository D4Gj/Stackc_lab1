using System;

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
            #region InsertAndMerge
            Console.WriteLine("");
            Console.Write("Write down elements: ");
            Random rnd = new Random();
            var array = new int[10];  
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(100);
            }
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array in insert sort: {0}", string.Join(" / ", InsertSort.InsertionSort(array)));
            Console.WriteLine("Array in merge sort: {0}", string.Join(" / ", MergeSort.MergeSorting(array,0,array.Length)));
            #endregion
            #region SelecProblem
            Console.Write("Selected activities:");
            int[] f = { 1, 3, 0, 5, 8, 5 };
            int[] l = { 2, 4, 6, 7, 9, 9 };
            int n = f.Length;
            ChangeEvent.choose(n, f, l);
            #endregion
            #region Dynamic
            
            #endregion
            Console.ReadLine();
        }
        
    }
}
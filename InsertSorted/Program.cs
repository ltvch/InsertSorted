using System;

namespace InsertSorted
{
    class Program
    {
        static void InsertSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int cursor = array[i];
                int k = i;

                while (i > 0 && cursor < array[k - 1])
                {
                    array[k] = array[k - 1];
                    k--;
                }
                array[k] = cursor;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 4, 5, 7, 7, 8, 2, 3, 7 };

            InsertSort(arr);

            foreach (int item in arr)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.Read();
        }
    }
}

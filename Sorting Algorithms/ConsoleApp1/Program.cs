namespace ConsoleApp1
{
    internal class Program
    {
        // Bubble sort with optimization so it dosn't make unnessary loops if the array is sorted 
        static void Main(string[] args)
        {
            int[] ints = { 3, 15, 8, 12, 9, 1 };
            BubbleSort(ints);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] BubbleSort(int[] arr)
        {
            bool swaps;
            for (int i = arr.Length; i > 0; i--)
            {
                swaps = true;
                for (int j = 0; j < i -1; j++)
                {
                    if (arr[j] > arr[j+ 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+ 1];
                        arr[j+ 1] = temp;
                        swaps = false;
                    }
                }
                if (swaps)
                {
                    break;
                }
            }
            return arr;
        }
    }
}

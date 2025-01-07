namespace Inserion_Sort
{
    internal class Program
    {
        //insertion sort is a little more complicated than bubble and selection sort best use is when u keep intering data to your set
        static void Main(string[] args)
        {
            int[] ints = { 3, 15, 8, 12, 9, 1 };
            InsertionSort(ints);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] InsertionSort(int[] Arr)
        {
            for (int i = 1; i < Arr.Length; i++)
            {
                var Val = Arr[i];
                int j;
                for ( j = i - 1; j >= 0 && Arr[j] > Val; j--)
                {
                    Arr[j+1] = Arr[j];
                }
                Arr[j+1] = Val;
            }
            return Arr;
        }

    }
}

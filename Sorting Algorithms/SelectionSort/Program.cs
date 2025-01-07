namespace SelectionSort
{
    internal class Program
    {
        //Selection sort is one of the easier sorting algorithms to implement but not the best one in terms of preformance

        static void Main(string[] args)
        {
            int[] ints = { 3, 15, 8, 12, 9, 1 };
            SelectionSort(ints);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] SelectionSort(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++) 
            {
                int Lowest = i;
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[j] < Arr[Lowest])
                    {
                        Lowest = j;
                    }
                    var temp = Arr[i];
                    Arr[i] = Arr[Lowest];
                    Arr[Lowest] = temp;
                }
            }

            return Arr;
        }
    }
}

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 3, 6, 1, 4};

            int[] array3 = MergeSort(array);
            foreach (var item in array3)
            {
                Console.WriteLine(item);
            }

        }
        public static int[] MergeSort(int[] Arr)
        {
            if(Arr.Length <= 1 ) return Arr;
            int mid = Arr.Length / 2;

            var left = MergeSort(Arr.Take(mid).ToArray());
            var right = MergeSort(Arr.Skip(mid).ToArray());

            return Merge(left,right);   
        }
        public static int[] Merge(int[] Arr1, int[] Arr2)
        {
            int[] bigArr = new int[Arr1.Length + Arr2.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < Arr1.Length && j < Arr2.Length) 
            {
                if (Arr1[i] < Arr2[j])
                {
                    bigArr[k] = Arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    bigArr[k] = Arr2[j];
                    j++;
                    k++;
                }
            }
            while (i < Arr1.Length)
            {
                bigArr[k] = Arr1[i];
                i++; k++;   
            }
            while (j < Arr2.Length)
            {
                bigArr[k] = Arr2[j];
                j++; k++;   
            }
            return bigArr;
        }
    }
}

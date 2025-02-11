namespace section3
{
    public delegate bool SortConditionDelegate(int A, int B);
    public delegate bool SortConditionDelegate<T>(T A, T B);

    internal class SortingAlgorithms
    {
        public static void BubbleSort<T>(T[] Arr, Func<T,T,bool> sortConditionDelegate)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (sortConditionDelegate.Invoke(Arr[j], Arr[j + 1]))
                            Swape(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }
        public static void BubbleSort(int[] Arr, SortConditionDelegate sortConditionDelegate)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (sortConditionDelegate.Invoke(Arr[j], Arr[j + 1]))
                            Swape(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }
        private static void Swape<T>(ref T A, ref T B)
        {
            T Temp = B;
            B = A;
            A = Temp;
        }
        private static void Swape(ref int A, ref int B)
        {
            int Temp = B;
            B = A;
            A = Temp;
        }
    }
}

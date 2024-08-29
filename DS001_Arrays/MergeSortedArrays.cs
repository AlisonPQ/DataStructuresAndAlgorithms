class Program
{
    private static void Main(string[] args)
    {
        int[] res = MergeArrays([1, 3, 5, 7], [3, 5, 9, 9]);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }

    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int mergedArrIndex = 0;
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        int i = 0;
        int j = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                mergedArray[mergedArrIndex] = arr1[i];
                i++;
            }
            else
            {
                mergedArray[mergedArrIndex] = arr2[j];
                j++;
            }
            mergedArrIndex++;
        }
        if (i == arr1.Length)
            AddToResult(mergedArray, mergedArrIndex, j, arr2);

        if (j == arr2.Length)
            AddToResult(mergedArray, mergedArrIndex, i, arr1);

        return mergedArray;
    }

    static void AddToResult(int[] mergedArray, int mergedArrIndex, int pos, int[] arr)
    {
        for (int i = pos; i < arr.Length; i++)
        {
            mergedArray[mergedArrIndex] = arr[i];
            mergedArrIndex++;
        }
    }
}

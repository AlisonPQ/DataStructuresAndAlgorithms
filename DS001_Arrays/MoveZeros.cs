/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]
*/
class Program
{
    private static void Main(string[] args)
    {
        int[] arr = [0, 2, 1, 0, 0, 8, 3];
        MoveZeroes(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


    static void MoveZeroes(int[] arr)
    {

        int cont = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                cont++;
            }
            else
            {
                arr[i - cont] = arr[i];
            }
        }
        for (int i = arr.Length - cont; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
    }
}

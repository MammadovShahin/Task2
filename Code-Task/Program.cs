using System;

namespace Code_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 10, 20, 62, 4 };
            Console.WriteLine(Sum(arr));
        }
        static int Sum (int[] arr)
        {
           int result = 0;
           int sum=0;
            int j=0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                j++;
            }
            result = sum / j;

            return result;

        } 
    }
}

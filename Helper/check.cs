using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortApi1.Helper
{
    public class check
    {
        
            /// <summary>
            /// Determines if int array is sorted from 0 -> Max
            /// </summary>
            public bool IsSorted(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        return false;
                    }
                }
                return true;
            }

           

            /// <summary>
            /// Determines if int array is sorted from Max -> 0
            /// </summary>
            public  bool IsSortedDescending(int[] arr)
            {
                for (int i = arr.Length - 2; i >= 0; i--)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
        public  bool almostSort(int[] arr)
        {

            // One by one compare adjacents. 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i++;
                }
            }

            // Check whether resultant is 
            // sorted or not 
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > arr[i + 1])
                    return false;

            // is resultant is sorted return true 
            return true;
        }
        public bool sort(int[]arr)
        {

            int s_count = 0;
            int count = 0;
            Double val = (0.25 * arr.Length);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    count++;

                }
                else
                {
                    if (s_count < count)
                    {
                        s_count = count;
                        Console.WriteLine(s_count);
                    }
                    count = 0;
                }
            }
            return false;


        }


    }
    
}

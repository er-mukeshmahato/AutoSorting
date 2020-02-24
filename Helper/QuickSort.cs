using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortApi.Helper
{
    public class QuickSort
    {
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {


                int pi = Partition(arr, low, high);


                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];


            int i = (low - 1);
            for (int j = low; j < high; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }


            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }



    }      
}

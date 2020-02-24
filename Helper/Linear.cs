using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortApi.Helper
{
    public class Linear
    {
        public  int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class introsort
    {
        public static void start(ref Int64 [] arr)
        {
            int partsize = partition(ref arr, 0, arr.Length - 1);

            if (partsize < 16)
            {
                rutinasX.insertion(ref arr);
            }
            else if ((Math.Log(arr.Length)*2) < partsize)
            {
                rutinasX.heap(ref arr);
            }
            else
            {
                rutinasX.quick(ref arr);
            }
        }

        private static int partition(ref Int64 [] arr, int left, int right)
        {
            Int64 pivot = arr[right];

            int i = left;


            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    swap.make(ref arr, j, i);
                    ++i;
                }
            }

            arr[right] = arr[i];

            arr[i] = pivot;

            return i;
        }
    }
}

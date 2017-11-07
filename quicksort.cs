using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class quicksort
    {
        public static void start(ref Int64 [] arr)
        {
            sort(ref arr, 0, arr.Length-1);
        }

        private static void sort(ref Int64 [] arr, int left, int right)
        {
            if (left < right)
            {
                int q = partition(ref arr, left, right);
                sort(ref arr, left, q - 1);
                sort(ref arr, q + 1, right);
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
                    swap.make(ref arr, j,i);
                    i++;
                }
            }

            arr[right] = arr[i];
            arr[i] = pivot;

            return i;
        }

        /*
        public static void start(ref int [] arr)
        {
            xquicksort(0, arr.Length - 1, ref arr);
        }

        public static void xquicksort(int left, int right ,ref int [] arr)
        {
            int izq, der, pivot, tmp;

            izq = left;

            der = right;

            pivot = arr[(left + right) / 2];

            do
            {

                while (arr[izq] < pivot)
                {
                    ++izq;
                }

                while (der > pivot)
                {
                    --der;
                }

                if (izq <= der)
                {
                    tmp = arr[izq];
                    arr[izq] = arr[der];
                    arr[der] = tmp;
                    ++izq;
                    --der;
                }

            } while (izq <= der);

            if (left < der)
               xquicksort(left, der, ref arr);

            if (right > izq)
                xquicksort(izq, right, ref arr);
        }

    */
    }
   
}

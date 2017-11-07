using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class heapsort
    {
        public static void ordenarmonticulo(ref Int64 [] arr, int n, int largo)
        {
            int root = largo;
            int left = (2 * largo) + 1;
            int right = (2 * largo) + 2;
            try
            {

                if (left < n && arr[left] > arr[root])
                {
                    root = left;
                }

                if (right < n && arr[right] > arr[root])
                {
                    root = right;
                }

                if (!(largo == root))
                {
                    swap.make(ref arr, largo, root);
                    ordenarmonticulo(ref arr, n, root);
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }

        public static void start(ref Int64 [] arr)
        {
            int n = arr.Length;

            for (int x = (n / 2) - 1; 0 <= x; --x)
            {
                ordenarmonticulo(ref arr, n, x);
            }

            for (int x = n - 1; 0 <= x; --x)
            {
                swap.make(ref arr, 0, x);

                ordenarmonticulo(ref arr, x, 0);
            }
        }

/// <summary>
/// SAME BUT WITH ANOTER DATA TYPE
/// </summary>
/// <param name="arr"></param>
/// <param name="n"></param>
/// <param name="largo"></param>
/// 

        public static void ordenarmonticulo(ref int[] arr, int n, int largo)
        {
            int root = largo;
            int left = (2 * largo) + 1;
            int right = (2 * largo) + 2;
            try
            {

                if (left < n && arr[left] > arr[root])
                {
                    root = left;
                }

                if (right < n && arr[right] > arr[root])
                {
                    root = right;
                }

                if (!(largo == root))
                {
                    swap.make(ref arr, largo, root);
                    ordenarmonticulo(ref arr, n, root);
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }

        public static void start(ref int[] arr)
        {
            int n = arr.Length;

            for (int x = (n / 2) - 1; 0 <= x; --x)
            {
                ordenarmonticulo(ref arr, n, x);
            }

            for (int x = n - 1; 0 <= x; --x)
            {
                swap.make(ref arr, 0, x);

                ordenarmonticulo(ref arr, x, 0);
            }
        }

        private static int getleft(int x)
        {
            return x * 2 + 1;
        }

        private static int getright(int x)
        {
            return x * 2 + 2;
        }
    }
}

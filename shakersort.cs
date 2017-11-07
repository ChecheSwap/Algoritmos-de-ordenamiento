using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class shakersort
    {
        public static void start(ref Int64 [] arr)
        {

            try
            {
                int n = arr.Length;
                int izq = 0;
                int der = n - 1;
                while (izq <= der)
                {
                    for (int j = izq; j < der; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            swap.make(ref arr, j, j + 1);
                        }
                    }
                    --der;
                    for (int j = der; j > izq; j--)
                    {
                        if (arr[j] < arr[j - 1])
                        {
                            swap.make(ref arr, j, j - 1);
                        }
                    }
                    ++izq;
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }
    }
}

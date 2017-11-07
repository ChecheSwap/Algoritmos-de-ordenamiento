using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class insertionsort
    {
        public static void start(ref Int64 [] arr)//ES MAS RAPIDO POR QUE EN EL MEJOR DE LOS CASOS TIENE UN TIEMPO DE N (SI LLEGA ESTAR ORDENADO EL ARREGLO)
        {
            int n = arr.Length;

            try
            {

                int i, j;
                Int64 val;

                for (i = 1; i < n; i++)
                {
                    val = arr[i];

                    j = i - 1;

                    while (j >= 0 && arr[j] > val)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = val;
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }
    }
}

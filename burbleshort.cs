using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class burbleshort
    {
        public static void start(ref Int64 [] arr)
        {
            int n = arr.Length;

            try
            {
                for (int x = 0; x < n; ++x)
                {
                    for (int y = 0; y < n - 1; ++y)
                    {
                        if (arr[y] > arr[y + 1])
                        {
                            swap.make(ref arr, y, y+1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }

        public static void start(ref int [] arr)
        {
            int n = arr.Length;

            try
            {

                for (int x = 0; x < n; ++x)
                {
                    for (int y = 0; y < n - 1; ++y)
                    {
                        if (arr[y] > arr[y + 1])
                        {
                            swap.make(ref arr, y, y+1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg.error(ex.ToString());
            }
        }
    }
}

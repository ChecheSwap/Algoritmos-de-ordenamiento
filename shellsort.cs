using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class shellsort
    {
        public static void start(ref Int64 [] arr)
        {
            int n = arr.Length;

            try
            {

                for (int gap = n / 2; gap > 0; gap /= 2)
                {
                    for (int x = gap; x < n; ++x)
                    {
                        for (int y = x - gap; 0 <= y; y -= gap)
                        {
                            if (arr[y] > arr[gap + y])
                            {
                                swap.make(ref arr, y, y + gap);
                            }
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

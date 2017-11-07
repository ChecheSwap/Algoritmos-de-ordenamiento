using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
  
    public static class mergesort
    {
      
        public static void start(ref Int64 [] arr)
        {
            xmerge(ref arr, 0, arr.Length - 1);
        }

        private static void xmerge(ref Int64 [] arr, int left, int right)
        {
            if (left < right)
            {

                int m = (left + right) / 2;
            
                xmerge(ref arr, left, m);
                xmerge(ref arr, m + 1, right);
                merge(ref arr, left, m, right);

            }
        }

        private static void merge(ref Int64 [] arr, int l, int m, int r)
        {
            int lindex, rindex, k;
            int n1 = m - l + 1;
            int n2 = r - m;


            Int64 [] arrleft = new Int64 [n1];
            Int64 [] arrright = new Int64 [n2];


                for (lindex = 0; lindex < n1; ++lindex)
                {
                    arrleft[lindex] = arr[l + lindex];
                }

                for (rindex = 0; rindex < n2; ++rindex)
                {
                    arrright[rindex] = arr[m + 1 + rindex];
                }


            lindex = 0; 
            rindex = 0; 
            k = l; // Mergedindex


            while (lindex < n1 && rindex < n2)
            {
                if (arrleft[lindex] <= arrright[rindex])
                {
                    arr[k] = arrleft[lindex];
                    ++lindex;
                }
                else
                {
                    arr[k] = arrright[rindex];
                    ++rindex;
                }

                k++;
            }


            while (lindex < n1)
            {
                arr[k] = arrleft[lindex];

                    ++lindex;

                    ++k;
            }

            while (rindex < n2)
            {
                arr[k] = arrright[rindex];

                    ++rindex;

                    ++k;
            }
        }   
    }
}


//INTRO SORT tarea
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    static class rutinasX
    {        

        public static void burbuja(ref Int64 [] arr)
        {
            burbleshort.start(ref arr);
        }


        public static void shaker(ref Int64 [] arr)
        {
            shakersort.start(ref arr);
        }

        public static void insertion(ref Int64 [] arr)//ES MAS RAPIDO POR QUE EN EL MEJOR DE LOS CASOS TIENE UN TIEMPO DE N (SI LLEGA ESTAR ORDENADO EL ARREGLO)
        {
            insertionsort.start(ref arr);
        }


        public static void shell(ref Int64 [] arr)
        {
            shellsort.start(ref arr);
        }

        public static void heap(ref Int64 [] arr)
        {
            heapsort.start(ref arr);
        }

        public static void merge(ref Int64 [] arr)
        {
            mergesort.start(ref arr);
        }

        public static void quick(ref Int64 [] arr)
        {
            quicksort.start(ref arr);
        }

        public static void intro(ref Int64 [] arr)
        {
            introsort.start(ref arr);
        }
               
    }
}
//MERGE AND HEAP SHORT TODO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsecsum.ROUTINES
{
    public static class swap
    {

        public static void make(ref Int64 [] arr, int x, int y)
        {
            Int64 temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public static void make(ref int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public static void make(ref int[] arr, int i, char caso, int step)
        {
            int temp;
            switch (caso)
            {
                case 'r':
                case 'R':
                    {
                        temp = arr[i];
                        arr[i] = arr[i + step];
                        arr[i + step] = temp;

                        break;
                    }
                case 'l':
                case 'L':
                    {
                        temp = arr[i];
                        arr[i] = arr[i - step];
                        arr[i - step] = temp;

                        break;
                    }
            }

        }

        public static void make(ref int[] arr, int i, char caso)
        {
            int temp;
            switch (caso)
            {
                case 'r':
                case 'R':
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        break;
                    }
                case 'l':
                case 'L':
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;

                        break;
                    }
            }

        }
    }
}

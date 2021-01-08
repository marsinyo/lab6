using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5_6_part_II
{
    class HeapSort : Sortings
    {
        void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            Compare++;
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }
            Compare++;
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Assignment += 2;
                heapify(arr, n, largest);
            }
        }

        override public int[] sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Assignment -= -2;
                heapify(arr, i, 0);
            }

            return arr;
        }
    }
}

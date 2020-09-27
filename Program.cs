using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProc
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, K = 0;
            int[] inputArr = new int[1];
            FileWork.ReadF(ref N, ref inputArr, ref K);
            int[] outputArr = new int[K];

            PartialQuicksort(inputArr, 0, inputArr.Length - 1, K);
            for (int i = 0; i < K; i++)
            {
                outputArr[i] = inputArr[i];
            }
            FileWork.WriteF(outputArr);
        }
        private static void PartialQuicksort(int[] input, int left, int right, int k)
        {
            while (right > left)
            {
                int pivot = Partition(input, left, right);
                if (k - 1 <= pivot)
                {
                    right = pivot - 1;
                }
                else if (pivot - left > right - pivot)
                {
                    Quicksort(input, pivot + 1, right);
                    right = pivot - 1;
                }
                else
                {
                    Quicksort(input, left, pivot - 1);
                    left = pivot + 1;
                }
            }
        }
        private static void Quicksort(int[] input, int left, int right)
        {
            if (left >= right) return;

            int pivot = Partition(input, left, right);
            Quicksort(input, left, pivot - 1);
            Quicksort(input, pivot + 1, right);

        }

        private static int Partition(int[] input, int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (input[i] > input[right])
                {
                    Swap(input, pointer, i);
                    pointer++;
                }
            }
            Swap(input, pointer, right);
            return pointer;
        }

        private static void Swap(int[] ar, int a, int b)
        {
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Algorithms
{
    class SortAlgorithms
    {
        public List<int> ArrayToSort { get; set; }
        public int Speed { get; set; }

        public SortAlgorithms(List<int> list, int speed)
        {
            ArrayToSort = list;
            Speed = speed;
        }

        public List<int> BubbleSort(List<int> arrayToSort)
        {
            int n = arrayToSort.Count - 1;
            for (int i = 0; i < n; i++)
            {

                for (int j = n; j > i; j--)
                {
                    if (((IComparable)arrayToSort[j - 1]).CompareTo(arrayToSort[j]) > 0)
                    {
                        int temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;

                    }
                    Thread.Sleep(Speed);
                }
            }
            return arrayToSort;
        }

        public List<int> MergeSort(List<int> a, int low, int height)
        {
            int l = low;
            int h = height;

            if (l >= h)
            {
                return a;
            }

            int mid = (l + h) / 2;
            Thread.Sleep(Speed);
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, h);

            int end_lo = mid;
            int start_hi = mid + 1;
            while ((l <= end_lo) && (start_hi <= h))
            {
                if (((IComparable)a[l]).CompareTo(a[start_hi]) < 0)
                {
                    l++;
                }
                else
                {
                    int temp = a[start_hi];
                    for (int k = start_hi - 1; k >= l; k--)
                    {

                        a[k + 1] = a[k];
                      
                    }
                    a[l] = temp;
                    l++;
                    end_lo++;
                    start_hi++;
                }
            }
            return a;
        }

        public List<int> CombSort(List<int> arrayToSort)
        {
            int gap = arrayToSort.Count;
            int swaps = 0;

            do
            {
                gap = (int)(gap / 1.247330950103979);
                if (gap < 1)
                {
                    gap = 1;
                }
                int i = 0;
                swaps = 0;

                do
                {
                    if (((IComparable)arrayToSort[i]).CompareTo(arrayToSort[i + gap]) > 0)
                    {
                        int temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + gap];
                        arrayToSort[i + gap] = temp;                       
                        swaps = 1;
                    }
                    i++;
                    Thread.Sleep(Speed);
                } while (!(i + gap >= arrayToSort.Count));

            } while (!(gap == 1 && swaps == 0));

            return arrayToSort;
        }

    }
}

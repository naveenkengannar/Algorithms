using System;

namespace Algortithms
{
    public class QuickSort
    {
        //https://www.geeksforgeeks.org/quick-sort/
        public void Execute(int[] data)
        {
            //Time Complexity: O(n2) worst case, nlog(n) best case
            Sort(data, 0, data.Length - 1);

            Utility.PrintArray(data,"QuickSort");
        }

        private void Sort(int[] data,int start,int end)
        {
            if (start >= end) return;

            int partionIndex = Parttion(data, start, end);

            Sort(data, start, partionIndex-1);

            Sort(data, partionIndex + 1, end);
        }

        private int Parttion(int[] data, int start, int end)
        {
            int pivot = data[end];
            int partionIndex = start;

            for (int i = start; i < end; i++)
            {
                if (data[i] <= pivot)
                {
                    int temp = data[i];
                    data[i] = data[partionIndex];
                    data[partionIndex] = temp;
                    partionIndex += 1;
                }
            }
            int temp2 = data[partionIndex];
            data[partionIndex] = pivot;
            data[end] = temp2;

            return partionIndex;
        }
    }
}
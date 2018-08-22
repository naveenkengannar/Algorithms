using System;

namespace Algortithms
{
    public class MergeSort
    {       
        public void Execute(int[] data)
        {
            //Time Complexity: O(nlogn) 
            //Space Complexity: O(n)
            MergeAndSort(data);

            Utility.PrintArray(data);
        }

        private void MergeAndSort(int[] data)
        {
            int n = data.Length;

            if (n < 2) return;

            int right, left = 0;
           
            
            left = n / 2;
            right = n - left;

            int[] leftPart = new int[left];
            int[] rightPart = new int[right];

            for (int i = 0; i < left; i++)            
                leftPart[i] = data[i];

            for (int i = 0; i < right; i++)            
                rightPart[i] = data[left+i];

            MergeAndSort(leftPart);
            MergeAndSort(rightPart);

            MergeSortedParts(leftPart, rightPart, data);

        }

        private void MergeSortedParts(int[] leftPart, int[] rightPart, int[] data)
        {
            int i=0;int j = 0;int k = 0;

            while(i < leftPart.Length && j < rightPart.Length)
            {
                if(leftPart[i] >= rightPart[j])
                {
                    data[k] = rightPart[j];
                    j += 1;
                    k += 1;
                }
                else
                {
                    data[k] = leftPart[i];
                    i += 1;
                    k += 1;
                }
            }

            while (i < leftPart.Length)
            {
                data[k] = leftPart[i];
                i += 1;
                k += 1;

            }
            while (j < rightPart.Length)
            {
                data[k] = rightPart[j];
                j += 1;
                k += 1;

            }

        }
    }
}
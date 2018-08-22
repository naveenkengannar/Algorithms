using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class SelectionSort
    {
        //https://www.geeksforgeeks.org/selection-sort/
        public void Execute(int[] data)
        {         
            //Time Complexity: O(n2) 
            Sort(data);

            Utility.PrintArray(data,"Selection Sort");
        }
        
        private void Sort(int[] data)
        {
            int n = data.Length;
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                int iMin = i;
                iMin = FindMinInUnSortedArray(data, i, iMin);
                Swap(data, i, iMin);
            }
        }

        private int FindMinInUnSortedArray(int[] data, int i, int iMin)
        {
            // Find the minimum element in unsorted array
            for (int j = i + 1; j < data.Length; j++)            
                if (data[j] < data[iMin])                
                    iMin = j;

            return iMin;
        }

        private void Swap(int[] data, int i, int iMin)
        {
            // Swap the found minimum element with the first                
            int temp = data[iMin];
            data[iMin] = data[i];
            data[i] = temp;
        }       
    }
}

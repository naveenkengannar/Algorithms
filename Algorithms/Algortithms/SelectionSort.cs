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
        public void Execute()
        {
            int[] data = { 64, 25, 12, 22, 11 };

            //Time Complexity: O(n2) 
            Sort(data);

            PrintArray(data);
        }
        
        public void Sort(int[] data)
        {
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < data.Length - 1; i++)
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

        private void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write("{0} \t", data[i]);

            Console.WriteLine();
        }
       

        
    }
}

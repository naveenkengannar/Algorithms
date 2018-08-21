using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class InsertionSort
    {
        //https://www.geeksforgeeks.org/insertion-sort/
        public void Execute(int[] data)
        {
            Utility.PrintArray(data);

            //Time Complexity: O(n2) 
            Sort(data);

            Utility.PrintArray(data,"Insertion sort");
        }

        private void Sort(int[] data)
        {
            int n = data.Length;

            for (int i = 1; i <= n-1; i++)            
                for (int j = i-1; j >= 0 ; j--)               
                    if(data[j] > data[j+1])                    
                        Swap(data, j);            
        }

        private static void Swap(int[] data, int j)
        {
            int temp = data[j];
            data[j] = data[j + 1];
            data[j + 1] = temp;
        }
    }
}

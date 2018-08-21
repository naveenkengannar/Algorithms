using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class BubbleSort
    {
        //https://www.geeksforgeeks.org/bubble-sort/
        public void Execute(int[] data)
        {           
            //Time Complexity: O(n2) 
            Sort(data);

            Utility.PrintArray(data,"Bubble sort");
        }

        private void Sort(int[] data)
        {
            int n = data.Length;
            for (int pass = 0; pass < n-1; pass++)
            {
                bool isSwapped = false;
                isSwapped = IterateOverArray(data, n, pass, isSwapped);
                if (!isSwapped)
                    break;

            }
        }

        private bool IterateOverArray(int[] data, int n, int pass, bool isSwapped)
        {
            for (int j = 0; j < n - pass - 1; j++)            
                isSwapped = Swap(data, isSwapped, j);         

            return isSwapped;
        }

        private bool Swap(int[] data, bool isSwapped, int j)
        {
            if (data[j] > data[j + 1])
            {
                int temp = data[j];
                data[j] = data[j + 1];
                data[j + 1] = temp;
                isSwapped = true;
            }

            return isSwapped;
        }

       
    }
}

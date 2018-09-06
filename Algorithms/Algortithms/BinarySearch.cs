using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class BinarySearch
    {
        //https://www.geeksforgeeks.org/binary-search/
        public void Execute(int[] data,int searchElement)
        {
            Utility.PrintArray(data);
            //Time Complexity: O(logn) 
            int result = Search(data, searchElement);
            Console.WriteLine("Result: {0}",result);
        }

        private int Search(int[] data, int searchElement)
        {
            int start = 0;
            int end = data.Length-1;

            if (data == null || data.Length <= 0)
                return -1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (data[mid] == searchElement)
                    return mid;
                else if (searchElement > data[mid])
                    start = mid + 1;
                else if (searchElement < data[mid])
                    end = mid - 1;
            }
            return -1;
        }
    }
}

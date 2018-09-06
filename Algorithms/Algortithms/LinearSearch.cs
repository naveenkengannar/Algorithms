using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    //https://www.geeksforgeeks.org/linear-search/
    public class LinearSearch
    {
        public void Execute(int[] data,int searchElement)
        {
            //Time Complexity: O(n)
            int result = Search(data,searchElement);

            Utility.PrintArray(data);
            Console.WriteLine("Result: {0}",result);
        }

        private int Search(int[] data,int searchElement)
        {
            if (data == null || data.Length < 1)
                return -1;

            for (int i = 0; i < data.Length; i++)            
                if (data[i] == searchElement)
                    return i;                
            
            return -1;
        }
    }
}

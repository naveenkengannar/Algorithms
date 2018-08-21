using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class Utility
    {
        public static void PrintArray(int[] data,string algorithm=null)
        {
            if(!string.IsNullOrEmpty(algorithm))
                Console.WriteLine("Sorted using {0} alogorithm:",algorithm);

            for (int i = 0; i < data.Length; i++)
                Console.Write("{0} \t", data[i]);

            Console.WriteLine();
        }
    }
}

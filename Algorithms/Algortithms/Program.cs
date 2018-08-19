using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortithms
{
    public class Program
    {
        static void Main(string[] args)
        {
           
               int algo = Convert.ToInt32(Algorithms.SelectionSort);

                switch (algo)
                {
                    case (int)Algorithms.SelectionSort:
                        new SelectionSort().Execute();
                        break;
                    

                }
            }        
    }

    enum Algorithms
    {
        SelectionSort
    }
}

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
           
             int algo = Convert.ToInt32(Algorithms.BinarySearch);

            int[] data = { 5, 4, 3, 2, 1 };
            int[] data2 = { 64, 25, 12, 22, 11 };
            int[] data3 = { 2,4,1,6,8,5,3,7,9 };
            int[] data4 = { 2, 4, 3,1 };
            int[] binarySearchData = { 2, 4, 9,11,17,88,88 };
            switch (algo)
            {
                case (int)Algorithms.SelectionSort:
                    new SelectionSort().Execute(data);
                    break;

                case (int)Algorithms.BubbleSort:
                    new BubbleSort().Execute(data);
                    break;

                case (int)Algorithms.InsertionSort:
                    new InsertionSort().Execute(data);
                    break;

                case (int)Algorithms.MergeSort:
                    new MergeSort().Execute(data3);
                    break;

               case (int)Algorithms.QuickSort:
                    new QuickSort().Execute(data3);
                    break;

                case (int)Algorithms.LinearSearch:
                    new LinearSearch().Execute(data: data2, searchElement: 111);
                    break;

                case (int)Algorithms.BinarySearch:
                    new BinarySearch().Execute(data: binarySearchData, searchElement: 88);
                        break;

            }
            }        
    }

    enum Algorithms
    {
        SelectionSort=0,
        BubbleSort=1,
        InsertionSort=2,
        MergeSort=3,
        QuickSort=4,
        LinearSearch=5,
        BinarySearch=6
    }
}

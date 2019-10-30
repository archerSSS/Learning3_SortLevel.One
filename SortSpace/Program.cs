using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 2, 1, 5, 3, 11 };
            SortLevel.SelectionSortStep(arr, 0);
            SortLevel.BubbleSortStep(arr);
        }
    }
}

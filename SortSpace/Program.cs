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
            int[] ar1 = new int[] { 1, 2, 3, 4, 5 };
            int[] ar2 = new int[2];
            ar2[0] = ar1[2];
            ar2[1] = ar1[4];

            ar2[0] += 10;
            ar2[1] += 10;
        }
    }
}

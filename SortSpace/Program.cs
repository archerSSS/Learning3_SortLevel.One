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
            int[] a1 = new int[] { 1, 2, 3, 4, 5 };
            int[] a2 = new int[3];
            a2[0] = a1[0];
            a2[1] = a1[1];

            a2[0] += 22;
        }
    }
}

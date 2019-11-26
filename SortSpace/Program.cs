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
            int[] tt = new int[] { 1, 3, 5, 7 };
            int[] r = new int[] { 10, 10, 10, 10 };

            Array.Copy(tt, 1, r, 0, 2);

            r[1] = 22;
        }
    }
}

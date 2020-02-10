using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest_1
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        private int result;
        private int[] array;

        public BinarySearch(int[] array)
        {
            Left = 0;
            Right = array.Length - 1;
            result = 0;
            this.array = array;
        }

        public void Step(int N)
        {
            int middle = (Right + Left) / 2;
            
            if (array[middle] > N)
                Right = (Right - 1) / 2;
            else if (array[middle] < N)
                Left = (Right + 1) / 2;
            else if (array[middle] == N) result = 1;
            else result = -1;
        }

        public int GetResult()
        {
            return result;
        }
    }
}

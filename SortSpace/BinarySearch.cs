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
            if (result == 0)
            {
                int middle = (Right + Left) / 2;
                
                if (N != array[middle])
                {
                    if (Left == Right) result = -1;
                    if (N < array[middle])
                    {
                        if (Right - Left == 1) Right = Left;
                        else Right = middle - 1;
                    }
                    else if (Right - Left == 1) Left = Right;
                    else Left = middle + 1;
                }
                else result = 1;
            }
        }

        public int GetResult()
        {
            return result;
        }
    }
}

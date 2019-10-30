using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void SelectionSortStep(int[] array, int i)
        {
            if (i < array.Length - 1) ExchangeValues(array, i, MinorElement(array, i + 1));
        }

        public static bool BubbleSortStep(int[] array)
        {
            bool Compared = false;
            bool Changed = false;
            for (int i = 0; ; i++)
            {
                if (i + 1 == array.Length)
                {
                    if (Changed)
                    {
                        if (!Compared) return false;
                        i = 0;
                        Compared = false;
                    }
                    else return true;
                }
                if (Compare(array[i], array[i + 1]))
                {
                    Changed = true;
                    Compared = Changed;
                    ExchangeValues(array, i, i + 1);
                }
            }
        }

        public static bool Compare(int a, int b)
        {
            return a > b;
        }

        public static int MinorElement(int[] array, int i)
        {
            int minor = i;
            for (; i < array.Length; i++)
                if (array[i] < array[minor]) minor = i;
            return minor;
        }

        public static void ExchangeValues(int[] array, int i, int j)
        {
            array[i] += array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
        }
    }
}

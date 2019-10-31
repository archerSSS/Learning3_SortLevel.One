using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    public static class SortLevel
    {
        /*
         *      Основные функции.
         */
        // Сортировка выбором.
        //
        public static void SelectionSortStep(int[] array, int i)
        {
            if (i < array.Length - 1)
            {
                int m = MinorElement(array, i + 1);
                if (array[m] < array[i]) ExchangeElements(array, i, m);
            }
        }

        // Сортировка пузырьком.
        //
        public static bool BubbleSortStep(int[] array)
        {
            return Cyc(array, 0);
        }


        /*
         *      Вспомогательные функции.
         */
        // Цикл обхода по всему массиву, сортируя элементы в порядке возрастания.
        //      Возвращает true если сортировка не происходила;
        //          false если был произведен хотя бы один обмен элементов между двумя ячейками.
        //
        public static bool Cyc(int[] array, int i)
        {
            if (i + 1 == array.Length) return true;
            if (Compare(array[i], array[i + 1]) && ExchangeElements(array, i, i + 1)) return Cyc(array, 0) && false;
            return Cyc(array, i + 1);
        }

        // Сравнение двух целочисленных значений.
        //      Возвращает true если первый аргумент больше второго.
        //
        public static bool Compare(int a, int b)
        {
            return a > b;
        }

        // Находит наименьший элемент массива.
        //
        public static int MinorElement(int[] array, int i)
        {
            int minor = i;
            for (; i < array.Length; i++)
                if (array[i] < array[minor]) minor = i;
            return minor;
        }

        // Меняет два элемента массива местами.
        //
        public static bool ExchangeElements(int[] array, int i, int j)
        {
            array[i] += array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
            return true;
        }
    }
}

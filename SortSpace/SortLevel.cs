using System;
using System.Collections.Generic;

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
        //      Проходит по всем элементам, проверяя является ли i-й элемент больше (i+1)-го.
        //          Если такой элемент обнаруживается, то он меняется местами с (i+1)-м и возвращает значение false.
        //
        public static bool BubbleSortStep(int[] array)
        {
            return BCycle(array, 0);
        }

        // Сортировка пузырьком.
        //
        public static bool BubbleSortAll(int[] array)
        {
            return ACycle(array, 0);
        }
        
        public static void InsertSortStep(int[] array, int t, int i)
        {
            if (!CCycle(array, t, i)) InsertSortStep(array, t, i);
        }

        /*
         *      Вспомогательные функции.
         */
        // Цикл обхода по всему массиву, сортируя все элементы в порядке возрастания.
        //      Возвращает true если сортировка не происходила;
        //          false если был произведен хотя бы один обмен элементов между двумя ячейками.
        //
        public static bool ACycle(int[] array, int i)
        {
            if (i + 1 == array.Length) return true;
            if (Compare(array[i], array[i + 1]) && ExchangeElements(array, i, i + 1)) return ACycle(array, 0) && false;
            return ACycle(array, i + 1);
        }

        // Цикл обхода по всему массиву, сортируя элементы в порядке возрастания.
        //      Возвращает true если сортировка не происходила;
        //          false если был произведен хотя бы один обмен элементов между двумя ячейками.
        //
        public static bool BCycle(int[] array, int i)
        {
            if (i + 1 == array.Length) return true;
            if (Compare(array[i], array[i + 1]) && ExchangeElements(array, i, i + 1)) return BCycle(array, i + 1) && false;
            return BCycle(array, i + 1);
        }

        public static bool CCycle(int[] array, int t, int i)
        {
            if (i + t >= array.Length) return true;
            if (Compare(array[i], array[i + t]) && ExchangeElements(array, i, i + t)) return CCycle(array, t, i + t) && false;
            return CCycle(array, t, i + t);
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

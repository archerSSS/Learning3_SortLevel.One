using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        /*
         *      // Основные функции. //
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

        // Сортировка вставками.
        //      Проходит по элементам находящимся в указанной шаговой разности по ячейкам начиная с ячейки i.
        //          [5, 4, 3, 2, 1] (t = 2, 0)      =>      [3, 4, 1, 2, 5]
        //
        public static void InsertSortSingle(int[] array, int t, int i)
        {
            if (t <= 0) return;
            CCycle(array, t, i);
        }

        // Сортировка вставками (Полная).
        //      Проходит по элементам находящимся в указанной шаговой разности по ячейкам начиная с ячейки i.
        //          [5, 4, 3, 2, 1] (t = 2, 0)      =>      [1, 4, 3, 2, 5]
        //
        public static void InsertSortStep(int[] array, int t, int i)
        {
            if (t <= 0) return;
            if (!CCycle(array, t, i)) InsertSortStep(array, t, i);
        }

        // Сортировка Шелла.
        //      Проходит по элементам массива в последовательности Кнута
        //
        public static void ShellSort(int[] array)
        {
            foreach (int s in KnuthSequence(array.Length))
                for (int i = 0; i < s; i++) InsertSortStep(array, s, i);
        }

        // Создает лист числовых значений в порядке убывания последовательностью Кнута
        //
        public static List<int> KnuthSequence(int array_size)
        {
            List<int> list = new List<int>();
            int t = KnuthNextStep(1, array_size);
            for (; t >= 1; t = CalculateKnuthPrestep(t))
                list.Add(t);
            return list;
        }

        // Алгоритм разбиения
        //
        public static int ArrayChunk(int[] M)
        {
            return ArrayChunkA(M, M[M.Length / 2], M.Length / 2, 0, M.Length - 1);
        }


        /*
         *      // Вспомогательные функции. //
         */
        // Вычисляет максимальный размер шага доступный для 
        //      данного размера массива s, в соответствии с последовательностью Кнута
        //
        public static int KnuthNextStep(int t, int s)
        {
            if (CalculateKnuthStep(t) > s) return t;
            t = CalculateKnuthStep(t);
            return KnuthNextStep(t, s);
        }

        public static int CalculateKnuthStep(int t)
        {
            return 3 * t + 1;
        }

        public static int CalculateKnuthPrestep(int t)
        {
            return (t - 1) / 3;
        }
        
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

        // Алгоритм разбиения 2-я ступень
        //
        public static int ArrayChunkA(int[] M, int N, int n, int i1, int i2)
        {
            //  Если разница индексов в 1
            //      и первый элемент больше другого
            if (IsStick(i1, i2) && IsBigger(M[i1], M[i2]) && ExchangeElements(M, i1, i2))
                return ArrayChunkA(M, M[M.Length / 2], M.Length / 2, 0, M.Length - 1);

            // Если индексы равны либо 
            //      один индекс больше другого на 1 и 
            //          значение первого элемента меньше второго
            if (IsEquivalents(i1, i2) || (IsStick(i1, i2) && IsLess(M[i1], M[i2])))
                return n;

            if (IsLess(M[i1], N))
                return ArrayChunkA(M, N, n, ++i1, i2);
            if (IsBigger(M[i2], N))
                return ArrayChunkA(M, N, n, i1, --i2);
            
            if (ExchangeElements(M, i1, i2))
                n = PivotUpdateIndex(n, i1, i2);

            return ArrayChunkA(M, N, n, i1, i2);
        }

        // true Если значение меньше другого
        //
        public static bool IsLess(int i, int n)
        {
            return i < n;
        }

        // true Если значение больше другого
        //
        public static bool IsBigger(int i, int n)
        {
            return i > n;
        }

        // true если у значений разница в 1
        //
        public static bool IsStick(int a, int b)
        {
            return a == b - 1;
        }

        // true если значения равны
        //
        public static bool IsEquivalents(int a, int b)
        {
            return a == b;
        }

        public static int PivotUpdateIndex(int n, int i1, int i2)
        {
            if (i1 == n) return i2;
            else if (i2 == n) return i1;
            else return n;
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

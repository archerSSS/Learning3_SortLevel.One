﻿using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        /*
         *      // Основные функции. //
         */
        //
        // Алгоритм разбиения для быстрой сортировки
        //
        public static int ArrayChunk(int[] M)
        {
            return ArrayChunkA(M, 0, M.Length - 1);
        }

        //
        // Сортировка пузырьком.
        //      Проходит по всем элементам, проверяя является ли i-й элемент больше (i+1)-го.
        //          Если такой элемент обнаруживается, то он меняется местами с (i+1)-м и возвращает значение false.
        //
        public static bool BubbleSortStep(int[] array)
        {
            return BCycle(array, 0);
        }

        //
        // Сортировка пузырьком.
        //
        public static bool BubbleSortAll(int[] array)
        {
            return ACycle(array, 0);
        }

        // 
        // Бинарный поиск "От края"
        //
        public static bool GallopingSearch(int[] array, int N)
        {
            if (N < array[0] || N > array[array.Length - 1]) return false; 

            BinarySearch BS = new BinarySearch(array);
            for (int i = 1; i <= array.Length - 1; i++)
            {
                int index = (int)(Math.Pow(2, i) - 2);
                if (index > array.Length - 1) index = array.Length - 1;
                if (array[index] == N) return true;

                if (array[index] < N) continue;
                else if (array[index] > N)
                {
                    BS.Left = (int)(Math.Pow(2, i - 1) - 2) + 1;
                    BS.Right = index;
                }
                break;
            }

            while (BS.GetResult() == 0) BS.Step(N);
            return BS.GetResult() == 1;
        }

        //
        // Сортировка вставками (Полная).
        //      Проходит по элементам находящимся в указанной шаговой разности по ячейкам начиная с ячейки i.
        //          [5, 4, 3, 2, 1] (t = 2, 0)      =>      [1, 4, 3, 2, 5]
        //
        public static void InsertSortStep(int[] array, int t, int i)
        {
            if (t <= 0) return;
            if (!CCycle(array, t, i)) InsertSortStep(array, t, i);
        }

        //
        // Сортировка вставками.
        //      Проходит по элементам находящимся в указанной шаговой разности по ячейкам начиная с ячейки i.
        //          [5, 4, 3, 2, 1] (t = 2, 0)      =>      [3, 4, 1, 2, 5]
        //
        public static void InsertSortSingle(int[] array, int t, int i)
        {
            if (t <= 0) return;
            CCycle(array, t, i);
        }

        //
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

        public static List<int> KthOrderStatisticsStep(int[] array, int L, int R, int k)
        {
            int N = ArrayChunkA(array, L, R);
            List<int> list = new List<int>();
            if (N == k)
            {
                list.Add(N);
                list.Add(k);
            }
            else if (N < k)
            {
                list.Add(N + 1);
                list.Add(R);
            }
            else
            {
                list.Add(L);
                list.Add(N - 1);
            }
            return list;
        }

        public static List<int> KthOrderStatisticsTotal(int[] array, int L, int R, int k)
        {
            int N = ArrayChunkA(array, L, R);
            if (N == k)
            {
                List<int> list = new List<int>
                {
                    N, k
                };
                return list;
            }
            else if (N < k)
            {
                return KthOrderStatisticsTotal(array, N + 1, R, k);
            }
            else return KthOrderStatisticsTotal(array, L, N - 1, k);
        }

        public static List<int> MergeSort(List<int> list)
        {
            if (list.Count == 1) return list;

            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            for (int i = 0; i < (list.Count + 1) / 2; i++) listA.Add(list[i]);
            for (int i = (list.Count + 1) / 2; i < list.Count; i++) listB.Add(list[i]);

            List<int> list1 = MergeSort(listA);
            List<int> list2 = MergeSort(listB);
            return MixArrays(list1, list2);
        }

        public static List<int> MixArrays(List<int> LA, List<int> LB)
        {
            List<int> result = new List<int>();

            while (true)
            {
                if (LA.Count == 0 && LB.Count != 0)
                {
                    foreach (int num in LB) result.Add(num);
                    break;
                }
                else if (LA.Count != 0 && LB.Count == 0)
                {
                    foreach (int num in LA) result.Add(num);
                    break;
                }
                else if (LA.Count == 0 && LB.Count == 0) break;

                if (LA[0] >= LB[0])
                {
                    result.Add(LB[0]);
                    LB.Remove(LB[0]);
                }
                else
                {
                    result.Add(LA[0]);
                    LA.Remove(LA[0]);
                }
            }
            return result;
        }

        // Алгоритм быстрой сортировки массива
        //
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left == right) return;
            int n = ArrayChunkA(array, left, right);
            if (!(n <= left)) QuickSort(array, left, n - 1);
            if (!(n >= right)) QuickSort(array, n + 1, right);
        }

        // Алгоритм быстрой сортировки с хвостовой рекурсией
        //
        public static void QuickSortTailOptimization(int[] array, int left, int right)
        {
            if (left == right) return;

            // QuickSort алгоритм
            int n = ArrayChunkA(array, left, right);

            int i1;
            int i2;
            if (right - n < n - left) { i1 = n; i2 = right; right = n - 1; }
            else { i1 = left; i2 = n; left = n + 1; }

            int temp_left = i1;
            while (!(i1 >= i2))
            {
                if (array[i1] > array[i2]) ExchangeElements(array, i1, i2);
                i1++;
                if (i1 == i2)
                {
                    i1 = temp_left;
                    i2--;
                }
            }

            QuickSortTailOptimization(array, left, right);
        }
        
        //
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

        //
        // Сортировка Шелла.
        //      Проходит по элементам массива в последовательности Кнута
        //
        public static void ShellSort(int[] array)
        {
            foreach (int s in KnuthSequence(array.Length))
                for (int i = 0; i < s; i++) InsertSortStep(array, s, i);
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

        public static int FindIndex(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n) return i;
            }
            return -1;
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

        public static int SortFindMedian(int[] array, int L, int R)
        {
            int[] ms = new int[(R - L) / 5 + 1];
            int m = 0;

            for (int i = L; i <= R; i += 5)
            {
                if (i + 4 > R)
                {
                    QuickSortTailOptimization(array, i, R);
                    ms[m++] = array[((R - i + 1) / 2) + i];
                }
                else
                {
                    QuickSortTailOptimization(array, i, i + 4);
                    ms[m++] = array[i + 2];
                }
            }

            if (ms.Length == 1) return ms[0]; 
            return SortFindMedian(ms, 0, ms.Length - 1);
        }

        // Алгоритм разбиения 1-я ступень
        //
        public static int ArrayChunkA(int[] M, int i1, int i2)
        {
            while (true)
            {
                int n = ArrayChunkAA(M, M[(i1 + i2 + 1) / 2], (i1 + i2 + 1) / 2, i1, i2);
                if (n > -1) return n;
            }
        }
        
        // Алгоритм разбиения 2-я ступень
        //
        public static int ArrayChunkAA(int[] M, int N, int n, int i1, int i2)
        {
            if (IsStick(i1, i2) && IsBigger(M[i1], M[i2]) && ExchangeElements(M, i1, i2))
                return -1;
            
            if (IsEquivalents(i1, i2) || (IsStick(i1, i2) && IsLess(M[i1], M[i2])))
                return n;

            while (M[i1] < N || M[i2] > N)
            {
                if (M[i1] < N) i1++;
                if (M[i2] > N) i2--;
            }

            if (!IsStick(i1, i2))
            {
                ExchangeElements(M, i1, i2);
                n = PivotUpdateIndex(n, i1, i2);
            }
            return ArrayChunkAA(M, N, n, i1, i2);
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
            if (i == j) return true; 
            array[i] += array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
            return true;
        }
    }

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
                    if (N < array[middle])
                        Right = middle - 1;
                    else Left = middle + 1;

                    if (Left == Right)
                    {
                        if (N == array[Left]) result = 1;
                        else result = -1;
                    }
                    else if ((Right - Left) == 1 && !(N == array[Left] || N == array[Right])) result = -1;
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

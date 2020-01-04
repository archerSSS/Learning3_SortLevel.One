using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            



            List<int> list1 = new List<int>() { 1, 4 };
            List<int> list2 = new List<int>() { 3, 7 };
            List<int> result = new List<int>();
            
            while (true)
            {
                if (list1.Count == 0 && list2.Count != 0)
                {
                    foreach (int num in list2) result.Add(num);
                    break;
                }
                else if (list1.Count != 0 && list2.Count == 0)
                {
                    foreach (int num in list1) result.Add(num);
                    break;
                }
                else if (list1.Count == 0 && list2.Count == 0) break;
                
                if (list1[0] >= list2[0])
                {
                    result.Add(list2[0]);
                    list2.Remove(list2[0]);
                }
                else
                {
                    result.Add(list1[0]);
                    list1.Remove(list1[0]);
                }
            }
        }
    }
}

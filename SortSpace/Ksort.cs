using System;

namespace SortSpace
{
    public class Ksort
    {
        public string[] items;

        public Ksort()
        {
            items = new string[799];
        }

        public int Index(string s)
        {
            if (s.Length != 3 || Char.GetNumericValue(s[1]) == -1 || Char.GetNumericValue(s[2]) == -1 || s[0] < 97 || s[0] > 104) return -1;
            return (int)(((s[0] - 97) * 100) + (Char.GetNumericValue(s[1]) * 10) + Char.GetNumericValue(s[2]));
        }

        public bool Add(string s)
        {
            int index = Index(s);
            if (index != -1)
            {
                items[index] = s;
                return true;
            }
            return false;
        }
    }
}

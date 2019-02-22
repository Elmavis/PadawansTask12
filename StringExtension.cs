using System;
using System.Collections.Generic;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();
            List<char> l = new List<char>();
            char[] arr = source.ToCharArray();
            foreach (char c in arr)
                if (l.Contains(c))
                    return false;
                else
                    l.Add(c);

            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>
                                    (IEnumerable<T> items, T reference)
                                    where T : IComparable
        {
            foreach (T item in items)
            {
                if (item.CompareTo(reference) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}
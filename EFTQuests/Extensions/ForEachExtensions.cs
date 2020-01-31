using System;
using System.Collections.Generic;

namespace EFTQuests.Extensions
{
    public static class ForEachExtensions
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var i in enumerable)
            {
                action(i);
            }

            return enumerable;
        }
    }
}

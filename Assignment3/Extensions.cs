using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignments03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) => items.SelectMany(x => x);

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> p) => items.Where(x => p(x));

        public static bool IsSecure(this Uri u) => u.Scheme == Uri.UriSchemeHttps;

        public static int WordCount(this string s) => Regex.Matches(s, @"(?<word>[\S]+)").Count;

    }
}

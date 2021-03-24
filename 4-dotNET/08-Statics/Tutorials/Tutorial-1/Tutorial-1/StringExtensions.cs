using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public static class StringExtensions
    {
        public static string ToHtmlComment(this string content)
        {
            return $"<!--{content}-->";
        }

        public static string CutByHalf(this string phrase)
        {
            return phrase.Substring(0,(phrase.Length+1) /2);
        }
    }
}

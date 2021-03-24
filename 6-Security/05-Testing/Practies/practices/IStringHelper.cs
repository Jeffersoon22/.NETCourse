using System;
using System.Collections.Generic;
using System.Text;




namespace practices
{
    public interface IStringHelper
    {
        bool ContainsVowel(string inputedString);
        string ReverseString(string inputedString);
        bool ContainsSubstring(string inputedString, string substring);
    }
}

using System;
using System.Collections.Generic;
using System.Text;




namespace practices
{
    public class StringHelper : IStringHelper
    {
        private char[] _vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        private readonly IHttpService _httpService;
        public StringHelper(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public bool ContainsVowel(string inputedString)
        {
            if (!string.IsNullOrEmpty(inputedString))
            {
                foreach (char character in _vowels)
                {
                    if (inputedString.ToLower().Contains(character))
                        return true;
                }
            }
            return false;
        }



        public string ReverseString(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                char[] characterArray = input.ToCharArray();
                Array.Reverse(characterArray);
                return new string(characterArray);
            }
            return string.Empty;
        }




        public bool ContainsSubstring(string input, string substring)
        {
            if (!string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(substring))
            {
                if(input.IndexOf(substring) != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
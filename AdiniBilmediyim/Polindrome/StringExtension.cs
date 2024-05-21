
namespace Polindrome
{
    internal static class StringExtension
    {
        public static bool IsPalindrome(this string str)
        {
            var reversed = new System.Text.StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return str == reversed.ToString();          
        }
       
    }

}

namespace EnumeratingInterfaces
{
    internal static class StringExtensions
    {
        public static string Repeat(this string s, int n)
        {
            var newString = "";
            for (int i = 0; i < n; i++)
            {
                newString += s;
            }
            return newString;
        }
    }
}

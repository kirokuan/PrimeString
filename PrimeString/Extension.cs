using System.Linq;


namespace PrimeString
{
    public class Extension
    {
        public static bool PrimeString(string s)
        {
            //coding and coding..
            for (var j = 1; j <= s.Length / 2; j++)
            {
                var token = s.Substring(0, j);
                if (s.Length%token.Length == 0 && string.Concat(Enumerable.Repeat(token, s.Length / token.Length)).Equals(s))
                {
                    return false;
                }
            }
            return true;
        }

    }

}
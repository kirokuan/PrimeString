using System;
using System.Linq;


namespace PrimeString
{
    public class Extension
    {
        public static bool PrimeString(string s)
        {
            //coding and coding..
            for (var j = 1; j <= s.Length/2; j++)
            {
                var token = s.Substring(0, j);
                if (s.Length%token.Length == 0 &&
                    string.Concat(Enumerable.Repeat(token, s.Length/token.Length)).Equals(s))
                {
                    return false;
                }
            }
            return true;
        }

        public static string AverageString(string str)
        {
            return changeStr((int) str.Split(' ').Select(changeNum).Average());
        }


        private static string changeStr(int i)
        {
            switch (i)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return "zero";
                case -1: return "n/a";
            }
            return "n/a";
        }

        private static int changeNum(string str)
        {
            switch (str)
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
            }
            return -1;
        }
    }
}
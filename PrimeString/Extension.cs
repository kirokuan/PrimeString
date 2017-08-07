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
        public static int DeadAntCount(string ants)
        {
            if (ants == null) return 0;

            int antsCount =new []{CountChar(ants, 'a')
                , CountChar(ants, 't'), CountChar(ants, 'n')}.Max();
            var completeAnt = GetOccurance(ants, "ant");
            return antsCount-completeAnt;
        }

        private static int GetOccurance(string ants, string substr)
        {
            int occurance = 0;
            var start = 0;
            while (start < ants.Length)
            {
                var i = ants.IndexOf(substr, start);
                if (i > -1)
                {
                    occurance++;
                    start = i + 1;
                }
                else
                {
                    break;
                }
            }
            return occurance;
        }

        private static int CountChar(string ants, char ch)
        {
            return ants.ToCharArray().Count(c => c == ch);
        }

        public static string AverageString(string str)
        {
            var s=str.Split(' ').Select(ChangeNum);
            return s.Contains(-1)?"n/a":ChangeStr((int) s.Average());
        }


        private static string ChangeStr(int i)
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
            }
            return "n/a";
        }

        private static int ChangeNum(string str)
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
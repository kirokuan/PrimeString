using System.Linq;
using NUnit.Framework;

namespace PrimeString
{
    public class Class1
    {
        public bool PrimeString(string s)
        {
            //coding and coding..
            for (var j = 1; j <= s.Length / 2; j++)
            {
                var token = s.Substring(0, j);
                if (s.Length%token.Length != 0) continue;
                if (string.Concat(Enumerable.Repeat(token, s.Length / token.Length)).Equals(s))
                {
                    return false;
                }
            }
            return true;
        }


        [Test]
        public void BasicTests()
        {
            //var kata = new Kata();

            Assert.AreEqual(true, PrimeString("abac"));

            Assert.AreEqual(false, PrimeString("abab"));

            Assert.AreEqual(false, PrimeString("aaaa"));

            Assert.AreEqual(true, PrimeString("x"));

            Assert.AreEqual(true, PrimeString("abc"));

            Assert.AreEqual(false, PrimeString("fdsyffdsyffdsyffdsyffdsyf"));

            Assert.AreEqual(true, PrimeString("utdutdtdutd"));

            Assert.AreEqual(true, PrimeString("abba"));
            Assert.AreEqual(false, PrimeString("pp"));
            Assert.AreEqual(false, PrimeString("mmm"));
        }
    }
}

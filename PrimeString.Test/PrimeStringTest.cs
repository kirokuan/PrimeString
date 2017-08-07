using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeString.Test
{
    public class PrimeStringTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, Extension.PrimeString("abac"));
            Assert.AreEqual(false, Extension.PrimeString("abab"));
            Assert.AreEqual(false, Extension.PrimeString("aaaa"));
            Assert.AreEqual(true, Extension.PrimeString("x"));
            Assert.AreEqual(true, Extension.PrimeString("abc"));
            Assert.AreEqual(false, Extension.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));
            Assert.AreEqual(true, Extension.PrimeString("utdutdtdutd"));
            Assert.AreEqual(true, Extension.PrimeString("abba"));
            Assert.AreEqual(false, Extension.PrimeString("pp"));
            Assert.AreEqual(false, Extension.PrimeString("mmm"));
        }


        [Test]
        public void TestAverageString()
        {
            Assert.AreEqual("four", Extension.AverageString("zero nine five two"));
            Assert.AreEqual("three", Extension.AverageString("four six two three"));
            Assert.AreEqual("three", Extension.AverageString("one two three four five"));
            Assert.AreEqual("four", Extension.AverageString("five four"));
            Assert.AreEqual("zero", Extension.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Extension.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Extension.AverageString(""));
        }
    }
}

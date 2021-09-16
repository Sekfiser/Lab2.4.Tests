using NUnit.Framework;
using System;

namespace Lab2._4.Tests
{
    public class RemainderTests
    {
        Remainder remainder;
        [SetUp]
        public void Setup()
        {
            remainder = new Remainder(15.0,5.0);
        }

        [Test]
        public void Difference_between_15_and_5_is_10()
        {
            double expected = 10.0;

            Assert.AreEqual(expected, remainder.Remain, 0.1); //fails if "expected" not equals "remained" with needed accuracy
        }

        [TestCase("","")]
        [TestCase("1,0", "asd")]
        [TestCase("asd", "1,0")]
        [TestCase("1.0", "1.0")]
        [TestCase("1,0", "1,0")]
        public void Check_Convert_From_Strings(string firtsDigit, string secondDigit)
        {
            void CheckConvert()
            {
                Remainder remain = new Remainder(Convert.ToDouble(firtsDigit), Convert.ToDouble(secondDigit));
            }
            Assert.Throws<FormatException>(() =>CheckConvert()); // fails if conversion not throws FormatException
        }
    }
}
using System;
using Xunit;
using System.Linq;

namespace BDSA2021.Assignments03.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData("Testdrevet udvikling", "gnilkivdu teverdtseT")]
        [InlineData("God kaffe er sort", "tros re effak doG")]
        public void Test_DelegateReversingString(string input, string expected)
        {
        //Given
        Func<string, string> reverseString = s => s = new string(s.ToCharArray().Reverse().ToArray());
        //When
        string actual = reverseString(input);
        Console.WriteLine(actual);
        //Then
        Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20.0, 10.0, 200.0)]
        [InlineData(10.0, 5.4, 54.0)]
        public void Test_DelegateProductOfTwoDecimals(double d1, double d2, double expected)
        {
            //Given
            Func<double, double, double> Product = (x,y) => x*y;
            //When
            double actual = Product(d1, d2);
            //Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_IsNumericallyEqual()
        {
        //Given
            Func<int, string, bool> NumEqual = (n,s) => n == Int32.Parse(s);
            string y = "0042";
            int x = 42;
            bool expected = true;
        //When
            bool actual = NumEqual(x,y);
        //Then
            Assert.Equal(expected, actual);
        }
    }
}

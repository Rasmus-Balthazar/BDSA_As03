using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignments03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Test_Flatten_Given_ListOfList()
        {
            //Arrange
            var expected = new List<int>(){1,2,3,4};
            var list1 = new List<int>(){1,2};
            var list2 = new List<int>(){3,4};
            List<List<int>> input = new List<List<int>>(){list1, list2};

            //Act
            var output = input.SelectMany(x => x).ToList();
            //Assert
            Assert.Equal(expected,output);
        }

        [Fact]
        public void Test_Filter_intsDivisibleBy7AndAreGreaterThan42_givenStreamOfInts()
        {
        //Given
        int[] ys = new int[]{1,4,49,42,600,700,420,69};
        int[] expected = new int[]{49, 700, 420};
        //When
        var actual = ys.Where(i => i > 42 && i % 7==0).ToArray();
        //Then
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_LeapYear_givenStreamOfInts_returnLeapYearsAsStream()
        {
        //Given
        int[] ys = new int[]{1584, 1684, 1945, 1992, 2000, 2021,};
        int[] expected = new int[]{1584, 1684, 1992, 2000};
        //When
        var actual = ys.Where(y => y % 4 == 0).ToArray();
        
        //Then
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_WordCount_givenSentence()
        {
        //Given
        string sentence = "Jeg elsker at spise mad og være glad men det er ikke altid nemt";
        int expected = 14;
        //When
        int actual = sentence.WordCount();
        //Then
        Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData("  ")]
        public void Test_WordCount_givenEmptyString(string s)
        {
        //Given
        int expected = 0;
        //When
        int actual = s.WordCount();
        //Then
        Assert.Equal(expected, actual);
        }
    }
}

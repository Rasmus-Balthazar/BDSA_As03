using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignments03.Tests

{
    public class QueriesTests
    {
        [Fact]
        public void Test_FindWizardsByAuthor_WhereAuthorIsRowling()
        {
            IEnumerable<string> expected = new List<string>(){"Sirius Black"};

            var actual = Queries.FindWizardsByAuthor("J.K. Rowling");

            Assert.Equal(expected, actual);  
        }

        [Fact]
        public void Test_FindTheYear_TheFirstSith_ContainingDarth_WasIntroduced()
        {
        //Given
        int? expected = 1977;
        //When
        var actual = Queries.FindYearOfFirstSith();
        //Then
        Assert.Equal(expected, actual);  
        }

        [Fact]
        public void Test_FindUniqueWizardsFromHPBooks_ReturnedAsTupleList()
        {
        //Given
        var expected = new List<(string name, int? year)>
        {
            ("Sirius Black", 1999)
        }; 
        //When
        var actual = Queries.FindUniqueWizardsFromHarryPotter();
        //Then
        Assert.Equal(expected, actual);
        }
    }
}

using System;
using Xunit;

namespace alternatingcharacters.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("AAAA", 3)]
        [InlineData("BBBBB", 4)]
        [InlineData("ABABABAB", 0)]
        [InlineData("BABABA", 0)]
        [InlineData("AAABBB", 4)]
        [InlineData("AAABBBAABB", 6)]
        [InlineData("AABBAABB", 4)]
        [InlineData("ABABABAA", 1)]
        [InlineData("ABBABBAA", 3)]
        public void Test1(string s, int expected)
        {  
            var sut = Result.alternatingCharacters(s);
            Assert.Equal(expected, sut);
        }

    }
}

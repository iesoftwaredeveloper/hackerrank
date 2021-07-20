using System;
using Xunit;

namespace sherlockvalidstring.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", "NO")]
        [InlineData("aaaaabc", "NO")]
        [InlineData("abc", "YES")]
        [InlineData("aabbcd", "NO")]
        [InlineData("aabbccddeefghi", "NO")]
        [InlineData("abcdefghhgfedecba", "YES")]
        [InlineData("abbbbccccdddd", "YES")]
        [InlineData("abcdefghhgfedecbae", "NO")]       
        public void Test1(string s, string expected)
        {
            var sut = Result.isValid(s);
            Assert.Equal(expected, sut);
        }
    }
}

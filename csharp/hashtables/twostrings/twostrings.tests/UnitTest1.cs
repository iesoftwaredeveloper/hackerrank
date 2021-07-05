using System;
using Xunit;

namespace twostrings.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s1 = "hello";
            string s2 = "world";

            Assert.Equal("YES", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test2()
        {
            string s1 = "hi";
            string s2 = "world";

            Assert.Equal("NO", Result.twoStrings(s1, s2));
        }
    }
}

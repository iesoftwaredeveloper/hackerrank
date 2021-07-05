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

        [Fact]
        public void Test3()
        {
            string s1 = "wouldyoulikefries";
            string s2 = "abcabcabcabcabcabc";

            Assert.Equal("NO", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test4()
        {
            string s1 = "hackerrankcommunity";
            string s2 = "cdecdecdecde";

            Assert.Equal("YES", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test5()
        {
            string s1 = "writetoyourparents";
            string s2 = "fghmqzldbc";

            Assert.Equal("NO", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test6()
        {
            string s1 = "jackandjill";
            string s2 = "wentupthehill";

            Assert.Equal("YES", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test7()
        {
            string s1 = "aardvark";
            string s2 = "apple";

            Assert.Equal("YES", Result.twoStrings(s1, s2));
        }

        [Fact]
        public void Test8()
        {
            string s1 = "beetroot";
            string s2 = "sandals";

            Assert.Equal("NO", Result.twoStrings(s1, s2));
        }
    }
}

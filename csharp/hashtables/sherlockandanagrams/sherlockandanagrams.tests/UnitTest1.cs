using System;
using Xunit;

namespace sherlockandanagrams.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = "abba";
            var sut = Result.sherlockAndAnagrams(s);
            Assert.Equal(4, sut);
        }

        [Fact]
        public void Test2()
        {
            string s = "abcd";
            var sut = Result.sherlockAndAnagrams(s);
            Assert.Equal(0, sut);
        }

        [Fact]
        public void Test3()
        {
            string s = "ifailuhkqq";
            var sut = Result.sherlockAndAnagrams(s);
            Assert.Equal(3, sut);
        }

        [Fact]
        public void Test4()
        {
            string s = "kkkk";
            var sut = Result.sherlockAndAnagrams(s);
            Assert.Equal(10, sut);
        }

        [Fact]
        public void Test5()
        {
            string s = "cdcd";
            var sut = Result.sherlockAndAnagrams(s);
            Assert.Equal(5, sut);
        }

    }
}

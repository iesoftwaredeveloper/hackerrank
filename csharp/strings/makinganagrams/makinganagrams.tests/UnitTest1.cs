using System;
using Xunit;
using makinganagrams;

namespace makinganagrams.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string a = "cde";
            string b = "abc";

            var sut = Result.makeAnagram(a, b);
            Assert.Equal(4, sut);
        }

        [Fact]
        public void Test2()
        {
            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            var sut = Result.makeAnagram(a, b);
            Assert.Equal(30, sut);
        }

        [Fact]
        public void Test3()
        {
            string a = "showman";
            string b = "woman";

            var sut = Result.makeAnagram(a, b);
            Assert.Equal(2, sut);
        }
    }
}

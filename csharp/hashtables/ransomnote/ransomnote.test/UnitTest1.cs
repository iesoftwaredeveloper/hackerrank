using System;
using Xunit;
using System.Collections.Generic;

namespace ransomnote.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<string> magazine = new List<string>() { "give", "me", "one", "grand", "today", "night" };
            List<string> note = new List<string>() { "give", "one", "grand", "today" };

            Assert.True(Result.checkMagazine(magazine, note));
        }

        [Fact]
        public void Test2()
        {
            // Cannot be replicated because "two" only appears once in magazine
            List<string> magazine = new List<string>() { "two", "times", "three", "is", "not", "four" };
            List<string> note = new List<string>() { "two", "times", "two", "is", "four" };

            Assert.False(Result.checkMagazine(magazine, note));
        }


        [Fact]
        public void Test3()
        {
            // Cannot be replicated because "two" only appears once in magazine
            List<string> magazine = new List<string>() { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" };
            List<string> note = new List<string>() { "ive", "got", "some", "coconuts" };

            Assert.False(Result.checkMagazine(magazine, note));
        }
    }
}

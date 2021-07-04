using System;
using Xunit;
using System.Collections.Generic;

namespace arraymanipulation.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int n = 10, m = 3;
            List<List<int>> queries = new() {
                new List<int>{1,5,3},
                new List<int>{4,8,7},
                new List<int>{6,9,1}
            };
            var sut = Result.arrayManipulation(n, queries);
            Assert.Equal(10, sut);
        }

        [Fact]
        public void Test2()
        {
            int n = 5, m = 3;
            List<List<int>> queries = new() {
                new List<int>{1,2,100},
                new List<int>{3,5,100},
                new List<int>{3,4,100}
            };
            var sut = Result.arrayManipulation(n, queries);
            Assert.Equal(200, sut);
        }

        [Fact]
        public void Test3()
        {
            int n = 10, m = 4;
            List<List<int>> queries = new() {
                new List<int>{2,6,8},
                new List<int>{3,5,7},
                new List<int>{1,8,1},
                new List<int>{5,9,15}
            };
            var sut = Result.arrayManipulation(n, queries);
            Assert.Equal(31, sut);
        }

        [Fact]
        public void Test4()
        {
            int n = 10, m = 0;
            List<List<int>> queries = new() {
            };
            var sut = Result.arrayManipulation(n, queries);
            Assert.Equal(0, sut);
        }

    }
}

using System;
using Xunit;
using System.Collections.Generic;

namespace markandtoys.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int n = 7, k = 50;
            List<int> prices = new List<int>() { 1, 12, 5, 111, 200, 1000, 10 };
            int expected = 4;
            var sut = Result.maximumToys(prices, k);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test2()
        {
            int n = 4, k = 7;
            List<int> prices = new List<int>() { 1, 2, 3, 4 };
            int expected = 3;
            var sut = Result.maximumToys(prices, k);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test3()
        {
            int n = 5, k = 15;
            List<int> prices = new List<int>() { 3, 7, 2, 9, 4 };
            int expected = 3;
            var sut = Result.maximumToys(prices, k);
            Assert.Equal(expected, sut);
        }
    }
}

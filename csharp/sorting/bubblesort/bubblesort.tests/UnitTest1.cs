using System;
using Xunit;
using System.Collections.Generic;

namespace bubblesort.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> arr = new() { 1, 2, 3 };
            var sut = Result.countSwaps(arr.ToArray());
            int[] expected = new int[3] { 0, 1, 3 };
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test2()
        {
            List<int> arr = new() { 3, 2, 1 };
            var sut = Result.countSwaps(arr.ToArray());
            int[] expected = new int[3] { 3, 1, 3 };
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test3()
        {
            List<int> arr = new() { 4, 2, 3, 1 };
            var sut = Result.countSwaps(arr.ToArray());
            int[] expected = new int[3] { 5, 1, 4 };
            Assert.Equal(expected, sut);
        }
    }
}

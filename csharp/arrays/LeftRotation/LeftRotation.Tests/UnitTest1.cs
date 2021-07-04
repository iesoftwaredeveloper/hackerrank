using System;
using Xunit;
using System.Collections.Generic;

namespace LeftRotation.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> arr = new(){1,2,3,4,5};
            List<int> expected = new(){5,1,2,3,4};
            var sut = Result.rotLeft(arr, 4);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test2()
        {
            List<int> arr = new(){41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51};
            List<int> expected = new(){77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77};
            var sut = Result.rotLeft(arr, 10);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test3()
        {
            List<int> arr = new(){33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97};
            List<int> expected = new(){87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60};
            var sut = Result.rotLeft(arr, 13);
            Assert.Equal(expected, sut);
        }
    }
}

using System;
using Xunit;
using System.Collections.Generic;

namespace counttriplets.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<long> arr = new List<long>() { 1, 2, 2, 4 };
            var sut = Program.countTriplets(arr, 2);
            Assert.Equal(2, sut);
        }

        [Fact]
        public void Test2()
        {
            List<long> arr = new List<long>() { 1, 3, 9, 9, 27, 81 };
            var sut = Program.countTriplets(arr, 3);
            Assert.Equal(6, sut);
        }

        [Fact]
        public void Test3()
        {
            List<long> arr = new List<long>() { 1, 5, 5, 25, 125 };
            var sut = Program.countTriplets(arr, 5);
            Assert.Equal(4, sut);
        }
    }
}

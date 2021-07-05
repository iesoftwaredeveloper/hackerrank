using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void Test4()
        {
            List<long> arr = new List<long>() { 1, 1, 1, 2, 2, 2, 3, 4, 5 };
            var sut = Program.countTriplets(arr, 1);
            Assert.Equal(2, sut);
        }

        [Fact]
        public void Test4_r()
        {
            List<long> arr = new List<long>() { 5, 4, 3, 2, 2, 2, 1, 1, 1 };
            var sut = Program.countTriplets(arr, 1);
            Assert.Equal(2, sut);
        }

        [Fact]
        public void Test5()
        {
            List<long> arr = new List<long>() { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            var sut = Program.countTriplets(arr, 1);
            Assert.Equal(84, sut);
        }

        [Fact]
        public void Test6()
        {
            List<long> arr = new List<long>() { };
            var sut = Program.countTriplets(arr, 5);
            Assert.Equal(0, sut);
        }

        [Fact]
        public void Test7()
        {
            var bigArray = new long[100000];
            Array.Fill<long>(bigArray, 1237L);
            var sut = Program.countTriplets(bigArray.ToList(), 1);
            Assert.Equal(166661666700000L, sut);
        }

    }
}

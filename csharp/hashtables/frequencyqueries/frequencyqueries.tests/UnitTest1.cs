using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace frequencyqueries.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> queries = new List<List<int>>()
            {
                new(){ 1, 1 },
                new(){ 2, 2 },
                new(){ 3, 2 },
                new(){ 1, 1 },
                new(){ 1, 1 },
                new(){ 2, 1 },
                new(){ 3, 2 }
            };
            List<int> expected = new List<int>() { 0, 1 };
            var sut = Program.freqQuery(queries);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> queries = new List<List<int>>()
            {
                new(){ 1, 5 },
                new(){ 2, 6 },
                new(){ 3, 2 },
                new(){ 1, 10 },
                new(){ 1, 10 },
                new(){ 1, 6 },
                new(){ 2, 5 },
                new(){ 3, 2 }
            };
            List<int> expected = new List<int>() { 0, 1 };
            var sut = Program.freqQuery(queries);
            Assert.Equal(expected, sut);
        }

        [Fact]
        public void Test3()
        {
            List<List<int>> queries = new List<List<int>>()
            {
                new(){ 3,4 },
                new(){ 2, 1003 },
                new(){ 1, 16 },
                new(){ 3,1 }
            };
            List<int> expected = new List<int>() { 0, 1 };
            var sut = Program.freqQuery(queries);
            Assert.Equal(expected, sut);
        }
        
        [Fact]
        public void Test4()
        {
            List<List<int>> queries = new List<List<int>>()
            {
                new(){ 1, 3 },
                new(){ 2, 3 },
                new(){ 3, 2 },
                new(){ 1, 4 },
                new(){ 1, 5 },
                new(){ 1, 5 },
                new(){ 1, 4 },
                new(){ 3, 2 },
                new(){ 2, 4 },
                new(){ 3, 2 }
            };
            List<int> expected = new List<int>() { 0, 1, 1 };
            var sut = Program.freqQuery(queries);
            Assert.Equal(expected, sut);
        }
    }
}

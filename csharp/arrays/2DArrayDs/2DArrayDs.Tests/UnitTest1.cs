using System;
using Xunit;
using System.Collections.Generic;
using _2DArrayDs;

namespace _2DArrayDs.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> arr = new List<List<int>> {
                new List<int>(){1,1,1,0,0,0},
                new List<int>(){0,1,0,0,0,0},
                new List<int>(){1,1,1,0,0,0},
                new List<int>(){0,0,2,4,4,0},
                new List<int>(){0,0,0,2,0,0},
                new List<int>(){0,0,1,2,4,0}
            };

            int result = Result.hourglassSum(arr);

            Assert.Equal(19, result);
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> arr = new List<List<int>> {
                new List<int>(){1,1, 1, 0, 0, 0},
                new List<int>(){0, 1, 0, 0, 0, 0},
                new List<int>(){1,1,1,0,0,0},
                new List<int>(){0, 9, 2, -4, -4, 0},
                new List<int>(){0, 0, 0, -2, 0, 0},
                new List<int>(){0, 0, -1, -2, -4, 0}
            };

            int result = Result.hourglassSum(arr);

            Assert.Equal(13, result);
        }

        [Fact]
        public void Test3()
        {
            List<List<int>> arr = new List<List<int>> {
                new List<int>(){-1, -1, 0, -9, -2, -2},
                new List<int>(){-2, -1, -6, -8, -2, -5},
                new List<int>(){-1, -1, -1, -2, -3, -4},
                new List<int>(){-1, -9, -2, -4, -4, -5},
                new List<int>(){-7, -3, -3, -2, -9, -9},
                new List<int>(){-1, -3, -1, -2, -4, -5}
            };

            int result = Result.hourglassSum(arr);

            Assert.Equal(-6, result);
        }

        [Fact]
        public void Test4()
        {
            List<List<int>> arr = new List<List<int>> {
                new List<int>(){-9, -9, -9, 1, 1, 1},
                new List<int>(){0, -9, 0, 4, 3, 2},
                new List<int>(){-9, -9, -9, 1, 2, 3},
                new List<int>(){0, 0, 8, 6, 6, 0},
                new List<int>(){0, 0, 0, -2, 0, 0},
                new List<int>(){0, 0, 1, 2, 4, 0}
            };

            int result = Result.hourglassSum(arr);

            Assert.Equal(28, result);
        }
    }
}

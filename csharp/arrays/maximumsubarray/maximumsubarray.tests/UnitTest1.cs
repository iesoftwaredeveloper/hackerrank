using System;
using Xunit;

namespace maximumsubarray.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, -1, -5, -4 }, 0)]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, 0, -5, -4 }, 0)]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, 1, -5, -4 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        public void TestKadanesMaxSum(int[] arr, int expected)
        {
            var sut = Kadanes.maxSum(arr);
            Assert.Equal(expected, sut);
        }

        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, new int[] { 4, -1, 2, 1 })]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, -1, -5, -4 }, new int[] {})]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, 0, -5, -4 }, new int[] {})]
        [InlineData(new int[] { -2, -1, -3, -4, -1, -2, 1, -5, -4 }, new int[] {1})]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void TestKadanesMaxSubArray(int[] arr, int[] expected)
        {
            var sut = Kadanes.maxSubArray(arr);
            Assert.Equal(expected, sut);
        }
    }
}

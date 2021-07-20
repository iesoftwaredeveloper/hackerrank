using System;
using Xunit;
using System.Collections.Generic;
using System.Collections;

namespace fraudulentactivitynotifications.tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new List<int> {2, 3, 4, 2, 3, 6, 8, 4, 5}, 5, 2},
            new object[] { new List<int> {10, 20, 30, 40, 50}, 3, 1},
            new object[] { new List<int> {10, 20, 30, 40, 50}, 5, 0},
            new object[] { new List<int> {1,2,3,4,4}, 4, 0},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class UnitTest1
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Test1(List<int> expenditure, int d, int expected)
        {
            var sut = Result.activityNotifications(expenditure, d);
            Assert.Equal(expected, sut);
        }
    }
}

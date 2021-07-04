using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

public class minimumSwaps2Tests
{
    [Fact]
    public void Test_case_0()
    {
        var arr = new int[] { };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(0, sut);
    }

    [Fact]
    public void Test_case_1()
    {
        var arr = new int[] { 4, 3, 1, 2 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(3, sut);
    }

    [Fact]
    public void Test_case_2()
    {
        var arr = new int[] { 2, 3, 4, 1, 5 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(3, sut);
    }

    [Fact]
    public void Test_case_7()
    {
        var arr = new int[] { 1, 3, 5, 2, 4, 6, 7 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(3, sut);
    }

    [Fact]
    public void Test_case_10_Rev()
    {
        var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(5, sut);
    }

    [Fact]
    public void Test_case_5_ordered()
    {
        var arr = new int[] { 1, 2, 3, 4, 5 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(0, sut);
    }

    [Fact]
    public void Test_case_5_maxswap()
    {
        var arr = new int[] { 5, 1, 2, 3, 4 };
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(4, sut);
    }

    [Fact]
    public void Test_case_fixed_15()
    {
        var arr = new int[]{10, 5, 9, 1, 14, 13, 3, 12, 11, 7, 2, 6, 4, 15, 8};

        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(14, sut);
    }

    [Fact]
    public void Test_case_forever_15()
    {
        var arr = new int[]{14, 10, 2, 9, 7, 11, 15, 8, 3, 4, 5, 1, 13, 12, 6};

        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(10, sut);
    }

    [Fact]
    public void Test_case_cnt_100()
    {
        var arr = new int[100];
        for (int i = 0; i < 100; i++)
        {
            arr[i] = 100 - i;
        }
        var sut = Solution.minimumSwaps(arr);
        Assert.Equal(50, sut);
    }

}

public class Sort_Selection_Tests
{    
    [Fact]
    public void Test_1()
    {
        var solution = new Sort_Selection();
        var A = new int[] { 10, 1, -1, 3, 7, 9, 2};
        var result = solution.SelectionSort(A);
        Assert.Equal(new int[] {-1, 1, 2, 3, 7, 9, 10 }, result);
    }

    [Fact]
    public void Test_2()
    {
        var solution = new Sort_Selection();
        var A = new int[] { 4, 3, 2, 1, 0 };
        var result = solution.SelectionSort(A);
        Assert.Equal(new int[] { 0, 1, 2, 3, 4 }, result);
    }

    [Fact]
    public void Test_3()
    {
        var solution = new Sort_Selection();
        var A = new int[] { 2, 1, 3 };
        var result = solution.SelectionSort(A);
        Assert.Equal(new int[] { 1, 2, 3 }, result);
    }

    [Fact]
    public void Test_4()
    {
        var solution = new Sort_Selection();
        var A = new int[] { 10, 1, -1, 3, 7, 9, };
        var result = solution.SelectionSort(A);
        Assert.Equal(new int[] { -1, 1, 3, 7, 9, 10 }, result);
    }
}
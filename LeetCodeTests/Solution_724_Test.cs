public class Solution_724_Test{

    [Fact]
    public void Test_1(){
        var solution = new Solution_724();

        var nums = new int[]{1,7,3,6,5,6};
        var expected = 3;
        var result = solution.PivotIndex(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_2(){
        var solution = new Solution_724();

        var nums = new int[]{1,2,3};
        var expected = -1;
        var result = solution.PivotIndex(nums);

        Assert.Equal(expected, result);  
    }

        [Fact]
    public void Test_3(){
        var solution = new Solution_724();

        var nums = new int[]{2,1,-1};
        var expected = 0;
        var result = solution.PivotIndex(nums);

        Assert.Equal(expected, result);  
    }
}
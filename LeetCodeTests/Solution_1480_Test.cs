using LeetCode;

namespace LeetCodeTests;

public class Solution_Test
{
    [Fact]
    public void Test_1234()
    {
        var solution = new Solution_1480();
        
        var nums = new int[]{1,2,3,4}; 
        var expectedResult = new int[]{1,3,6,10};
        
        var result = solution.RunningSum(nums);

        Assert.Equal(expectedResult, result);
    }
}
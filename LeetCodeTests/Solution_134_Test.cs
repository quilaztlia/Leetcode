using LeetCode;

namespace LeetCodeTests;

public class Solution_134_Test
{
    [Fact]
    public void Test_1()
    {        
        var solution = new Solution_134();
        var gas =  new int[]{1,2,3,4,5};
        var cost = new int[]{3,4,5,1,2};

        var expectedResult = 3;

        var result = solution.CanCompleteCircuit(gas, cost);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Test_2()
    {        
        var solution = new Solution_134();
        var gas =  new int[]{2,3,4};
        var cost = new int[]{3,4,3};

        var expectedResult = -1;

        var result = solution.CanCompleteCircuit(gas, cost);

        Assert.Equal(expectedResult, result);
    }
}
using LeetCode;

namespace LeetCodeTests;

public class Solution_6287_Test
{
    [Fact]
    public void Test_1()
    {
        var solution = new Solution_6287();
        int length = 1000, width = 35, height = 700, mass = 300;

        var expectedResult = "Heavy";

        var result = solution.CategorizeBox(length, width, height, mass);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Test_2()
    {
        var solution = new Solution_6287();
        int length = 200, width = 50, height = 800, mass = 50;

        var expectedResult = "Neither";

        var result = solution.CategorizeBox(length, width, height, mass);

        Assert.Equal(expectedResult, result);
    }


    [Fact]
    public void Test_3()
    {
        var solution = new Solution_6287();
        int length = 2909, width = 3968, height = 3272, mass = 727;

        var expectedResult = "Both";

        var result = solution.CategorizeBox(length, width, height, mass);

        Assert.Equal(expectedResult, result);
    }
 
    [Fact]
    public void Test_4()
    {
        uint a = 0xffff;
        int b = (int)a;

        Assert.Equal(a.ToString(), b.ToString());
    }
}
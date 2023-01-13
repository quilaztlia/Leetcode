using LeetCode;

public class Solution_205_Test{

    [Fact]
    public void Test_1(){
        var s = "egg";
        var t = "add";
        var expected = true;

        var solution = new Solution_205();
        var result = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_2(){
        var s = "foo";
        var t = "bar";
        var expected = false;

        var solution = new Solution_205();
        var result = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_3(){
        var s = "paper";
        var t = "title";
        var expected = true;

        var solution = new Solution_205();
        var result = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_4(){
        var s = "badc";
        var t = "baba";
        var expected = false;

        var solution = new Solution_205();
        var result = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, result);
    }
}
using LeetCode;

public class Solution_452_Intervals_Test{

    [Fact]
    public void Test_1(){
        var points = new int[][] { 
            new int[2]{10,16},
            new int[2]{2,8},
            new int[2]{1,6},
            new int[2]{7,12}
        };
        var expected = 2;

        var solution = new Solution_452_Intervals();
        var result = solution.FindMinArrowShots(points);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_2(){
        var points = new int[][] { 
            //[[1,2],[3,4],[5,6],[7,8]]
            new int[2]{1,2},
            new int[2]{3,4},
            new int[2]{5,6},
            new int[2]{7,8}
        };
        var expected = 4;

        var solution = new Solution_452_Intervals();
        var result = solution.FindMinArrowShots(points);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_3(){
        var points = new int[][] { 
            // [[1,2],[2,3],[3,4],[4,5]]
            new int[2]{1,2},
            new int[2]{2,3},
            new int[2]{3,4},
            new int[2]{4,5}
        };
        var expected = 2;

        var solution = new Solution_452_Intervals();
        var result = solution.FindMinArrowShots(points);
        
        Assert.Equal(expected, result);
    }

}
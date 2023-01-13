namespace LeetCode;

public class Solution_1480 {
    public int[] RunningSum(int[] nums) {
        
        int totalNums = nums.Length;

        int []runningSum = new int[totalNums];
        
        runningSum[0] = nums[0];
        
        for(int index=1; index < nums.Length; index++ ){
            runningSum[index] = runningSum[index-1] + nums[index];            
        }
        return runningSum;
    }
}
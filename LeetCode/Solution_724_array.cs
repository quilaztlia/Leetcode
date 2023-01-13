public class Solution_724 {
    public int PivotIndex(int[] nums) {
        bool isPivot = false;
        int left = 0, right = 0;
        int pivotIndex = 0;
        int total =  nums.Length;
        
    for(int i=1; i < total; i++)
        right+= nums[i];

        while(pivotIndex < total)
        {            
            isPivot = left == right;

            if(isPivot)
                return pivotIndex;

            pivotIndex++;

            left += nums[pivotIndex - 1];
            right = (pivotIndex == total)? 0
            : right - nums[pivotIndex];
        }

        return (isPivot)? pivotIndex : -1;
    }
}
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[2* nums.Length];
        int indx = 0;
        for(int i=0; i<2; i++)
        {
            foreach(int num in nums)
            {
                ans[indx++] = num;
            }
        }
        return ans;
        
    }
}
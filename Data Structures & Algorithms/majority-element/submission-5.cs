public class Solution {
    public int MajorityElement(int[] nums) {
        int k = 0;
        for(int i=0; i< nums.Length; i++)
        {
            for(int j = i; j< nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    k++;
                }
                if(k > nums.Length/2)
                {
                    return nums[i];
                }
            }
        }
        return -1;
    }
}
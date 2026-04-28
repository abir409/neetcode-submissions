public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int n = nums.Length;
        int[] arr = new int[nums.Length*2];

        for(int i = 0; i< n; i++)
        {
            arr[i] = nums[i];
            arr[i+n] = nums[i];
        }
        return arr;
}
}
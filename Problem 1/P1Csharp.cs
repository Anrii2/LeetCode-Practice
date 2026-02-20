using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int complement = target - num;

            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }

            map[num] = i;
        }

        return new int[0]; 
    }
}

using System;

namespace s2 
{
    public class Solution 
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            public int[] subtract(int[] nums, int target, int index) 
            {
                int difference = target - nums[index];
            
                int matchingIndex = Array.IndexOf(nums, difference);
            
                if (matchingIndex > -1) {
                    int[] indices = {index, matchingIndex};
                    return indices;
                }
                else {
                    index += 1;
                }
            }
        
            public int[] TwoSum() 
            {
                int index = 0;
                int[] nums = {2, 7, 11, 15};
                int target = 9;
                int[] arrayIndices = subtract(nums, target, index);
                return arrayIndices;
            }
        }
    }
}

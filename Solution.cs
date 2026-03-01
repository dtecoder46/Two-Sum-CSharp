using System;

namespace S2;
{
	public class Solution
	{
	  
	  private int[] nums;
	  private int target;
	  
	  public int[] subtract(int[] nums, int target, int index) {
	      int difference = target - nums[index];
	      
	      int matchingIndex = Array.IndexOf(nums, difference);
	      
	      if (matchingIndex > -1) {
	          int[] indices = {index, matchingIndex};
	          return indices
	      }
	      else {
	        index += 1;
	      }
	  }
	  
	  public Solution() {
	      nums = {};
	      target = 0;
	  }
	  
	  public Solution(int[] inputNums, int inputTarget) {
	      this.nums = inputNums;
	      this.target = inputTarget;
	  }
	  
		public int[] TwoSum()
		{
		    int index = 0;
		    int[] arrayIndices = subtract(this.nums, this.target, index);
		    return arrayIndices;
		}
	}
}

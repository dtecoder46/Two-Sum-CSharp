using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Main2
{
	public class Main3
	{
		public static void Main(string[] args)
		{
		  int array = {2, 7, 11, 15};
		  int target = 9;
		  
		  Solution twoSum = new Solution(array, target);
		  
			Console.WriteLine(twoSum.TwoSum());
		}
	}
}

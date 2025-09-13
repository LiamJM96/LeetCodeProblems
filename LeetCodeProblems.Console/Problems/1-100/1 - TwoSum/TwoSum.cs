using LeetCodeProblems.Console.Core;

namespace LeetCodeProblems.Console.Problems;

/// <summary>
/// Return indices of two numbers in nums that add up to target.
/// </summary>
/// <remarks>
/// <para>
/// You may assume that each input has exactly one solution, and you may not use the same element twice.
/// The answer can be returned in any order.
/// </para>
/// </remarks>
/// <example>
/// <code language="text">
/// Input:
///   nums = [2,7,11,15]
///   target = 9
/// Output:
///   [0,1]
/// Explanation:
///   nums[0] + nums[1] == 9
/// </code>
/// </example>
/// <example>
/// <code language="text">
/// Input:
///   nums = [3,2,4]
///   target = 6
/// Output:
///   [1,2]
/// </code>
/// </example>
/// <example>
/// <code language="text">
/// Input:
///   nums = [3,3]
///   target = 6
/// Output:
///   [0,1]
/// </code>
/// </example>

[LeetCode(1, "Two Sum", Difficulty.Easy, "https://leetcode.com/problems/two-sum/")]
public class TwoSum : ProblemBase
{
	public override IEnumerable<ITestCase> TestCases => new List<ITestCase>
	{
		new TwoSumTestCase([2, 7, 11, 15], 9, [0, 1]),
		new TwoSumTestCase([3, 2, 4], 6, [1, 2]),
		new TwoSumTestCase([3, 3], 6, [0, 1]),
	};
	
	private static int[] Solve(int[] nums, int target)
	{
		for (var i = 0; i < nums.Length; i++)
		{
			if (i == nums.Length - 1)
				return [];
			
			if (nums[i] + nums[i + 1] == target)
				return [i, i + 1];
		}
		
		return [];
	}

	private class TwoSumTestCase(int[] nums, int target, int[] expected) : ITestCase
	{
		private readonly int[] _nums = nums;
		private readonly int _target = target;
		private readonly int[] _expected = expected;

		public string InputDescription => 
			$"nums = [{string.Join(", ", _nums)}], target = {_target}, expected = [{string.Join(", ", _expected)}]";

		public bool Execute(out string actual)
		{
			var result = Solve(_nums, _target);

			actual = $"[{string.Join(", ", result)}]";
			
			return result.SequenceEqual(_expected);
		}
	}
}
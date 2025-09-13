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
	};
	
	private static int[] Solve(int[] nums, int target)
	{
		return [0, 1];
	}

	private class TwoSumTestCase(int[] nums, int target, int[] expected) : ITestCase
	{
		private readonly int[] _nums = nums;
		private readonly int _target = target;
		private readonly int[] _expected = expected;

		public string InputDescription => 
			$"nums = [{string.Join(", ", _nums)}], target = {_target}, expected = [{string.Join(", ", _expected)}]";

		public bool Execute()
		{
			var result = Solve(_nums, _target);
			return result.SequenceEqual(_expected);
		}
	}
}
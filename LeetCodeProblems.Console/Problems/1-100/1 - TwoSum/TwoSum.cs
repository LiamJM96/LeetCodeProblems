using LeetCodeProblems.Console.Core;

namespace LeetCodeProblems.Console.Problems;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
///
/// You can return the answer in any order.
/// </summary>

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
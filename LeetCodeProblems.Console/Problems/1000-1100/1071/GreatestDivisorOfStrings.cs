namespace LeetCodeProblems.Console.Problems;

/// <summary>
/// For two strings s and t, we say "t divides s" if and only if "s = t + t + t + ... + t + t"
/// (i.e., t is concatenated with itself one or more times).
/// </summary>
/// <remarks>
/// <para>
/// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
/// </para>
/// </remarks>
/// <example>
/// <code language="text">
/// Input:
///	  str1 = "ABCABC"
///   str2 = "ABC"
/// Output:
///   "ABC"
/// </code>
/// </example>

[LeetCode(1071, "Greatest Common Divisor of Strings", Difficulty.Easy, "https://leetcode.com/problems/greatest-common-divisor-of-strings")]
public class GreatestDivisorOfStrings : ProblemBase
{
	public override IEnumerable<ITestCase> TestCases => new List<ITestCase>
	{
		new GreatestDivisorOfStringsTestCase("ABCABC", "ABC", "ABC"),
		new GreatestDivisorOfStringsTestCase("ABABAB", "ABAB", "AB"),
		new GreatestDivisorOfStringsTestCase("LEET", "CODE", ""),
	};

	private static string Solve(string str1, string str2)
	{
		// Confirms if the 2 strings are dividable as adding in any order should give the same result
		if (str1 + str2 != str2 + str1)
			return "";

		var result = GetGreatestCommonDivisor(str1.Length, str2.Length);

		return str1[..result];
	}

	private static int GetGreatestCommonDivisor(int a, int b)
	{
		while (true)
		{
			// Logic - Euclidean Algorithm
			// 1. Start with 2 numbers
			// 2. Divide the larger by the smaller and get the remainder
			// 3. Replace the numbers and repeat until the remainder is zero
			// 4. Return the last non-zero remainder
			// 5. This will be the Greatest Common Divisor (GCD)

			var larger = Math.Max(a, b);
			var smaller = Math.Min(a, b);

			var remainder = larger % smaller;

			if (remainder == 0) 
				return smaller;
			
			a = remainder;
			b = smaller;
		}
	}

	private class GreatestDivisorOfStringsTestCase(string str1, string str2, string expected) : ITestCase
	{
		private readonly string _str1 = str1;
		private readonly string _str2 = str2;
		private readonly string _expected = expected;
		
		public string InputDescription => $"Str 1 = {(_str1)}, Str 2 = {_str2}, Expected = {_expected}";
		
		public bool Execute(out string actual)
		{
			var result = Solve(_str1, _str2);
			
			actual = result;
			
			return result == _expected;
		}
	}
}

using System.Text;
using LeetCodeProblems.Console.Core;

namespace LeetCodeProblems.Console.Problems;

/// <summary>
/// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
/// If a string is longer than the other, append the additional letters onto the end of the merged string.
/// </summary>
/// <remarks>
/// <para>
/// Return the merged string
/// </para>
/// </remarks>
/// <example>
/// <code language="text">
/// Input:
///	  word1 = "abc"
///   word2 = "pqr"
/// Output:
///   "apbqcr"
/// Explanation:
///   The merged string will be merged as so:
///   word1:  a   b   c
///   word2:    p   q   r
///   merged: a p b q c r
/// </code>
/// </example>

[LeetCode(1768, "Merge Strings Alternately", Difficulty.Easy, "https://leetcode.com/problems/merge-strings-alternately")]
public class MergeStringsAlternately : ProblemBase
{
	public override IEnumerable<ITestCase> TestCases => new List<ITestCase>
	{
		new MergeStringsAlternatelyTestCase("abc", "pqr", "apbqcr"),
		new MergeStringsAlternatelyTestCase("ab", "pqrs", "apbqrs"),
		new MergeStringsAlternatelyTestCase("abcd", "pq", "apbqcd")
	};

	private static string Solve(string word1, string word2)
	{
		var i = 0;
		var j = 0;
		
		var stringBuilder = new StringBuilder();

		var word1Length = word1.Length;
		var word2Length = word2.Length;

		while (i < word1Length || j < word2Length)
		{
			if (i < word1Length)
				stringBuilder.Append(word1[i++]);

			if (j < word2Length)
				stringBuilder.Append(word2[j++]);

		}
		
		return stringBuilder.ToString();
	}
	
	private class MergeStringsAlternatelyTestCase(string word1, string word2, string expected) : ITestCase
	{
		private readonly string _word1 = word1;
		private readonly string _word2 = word2;
		private readonly string _expected = expected;
		
		public string InputDescription => $"Word 1 = {_word1}, Word 2 = {_word2}, Expected = {_expected}";
		
		public bool Execute(out string actual)
		{
			var result = Solve(_word1, _word2);
			
			actual = result;
			
			return result == _expected;
		}
	}
	
	// Old Solutions
	/*private static string Solve(string word1, string word2)
	{
		var stringBuilder = new StringBuilder();

		var longestIndex = word1.Length > word2.Length 
			? word1.Length 
			: word2.Length;
		
		for (var i = 0; i < longestIndex; i++)
		{
			if (i < word1.Length)
				stringBuilder.Append(word1[i]);
			
			if (i < word2.Length)
				stringBuilder.Append(word2[i]);
		}
		
		return stringBuilder.ToString();
	}*/
}
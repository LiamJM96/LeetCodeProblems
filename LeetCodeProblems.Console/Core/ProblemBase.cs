using System.Diagnostics;

namespace LeetCodeProblems.Console.Core;

public abstract class ProblemBase : IProblem
{
	public abstract IEnumerable<ITestCase> TestCases { get; }

	public virtual void Run()
	{
		var type = GetType();
		var attribute = (LeetCodeAttribute?)Attribute.GetCustomAttribute(type, typeof(LeetCodeAttribute));

		if (attribute is not null)
			System.Console.WriteLine($"{attribute.Id}: {attribute.Title} - ({attribute.Difficulty}) - {attribute.Url}\n");

		var i = 1;
		foreach (var testCase in TestCases)
		{
			var sw = Stopwatch.StartNew();

			bool passed;
			var actual = string.Empty;

			try
			{
				passed = testCase.Execute(out actual);
			}
			catch (Exception e)
			{
				passed = false;
				System.Console.WriteLine($"Error: {e}");
			}
			
			sw.Stop();
			
			var status = passed ? "PASSED" : "FAILED";
			
			System.Console.WriteLine($"Test Case {i}: {status} - {testCase.InputDescription} - {sw.ElapsedMilliseconds}ms");
			System.Console.WriteLine($"Actual: {actual}\n");

			i++;
		}
		
		System.Console.WriteLine();
	}
}
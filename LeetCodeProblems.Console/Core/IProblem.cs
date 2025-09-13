namespace LeetCodeProblems.Console.Core;

public interface IProblem
{
	IEnumerable<ITestCase> TestCases { get; }
	
	void Run();
}
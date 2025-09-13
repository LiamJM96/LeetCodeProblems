namespace LeetCodeProblems.Console.Core;

public interface ITestCase
{
	string InputDescription { get; }
	bool Execute();
}
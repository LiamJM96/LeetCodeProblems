namespace LeetCodeProblems.Console.Core;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class LeetCodeAttribute(int id, string title, Difficulty difficulty, string url) : Attribute
{
	public int Id { get; } = id;
	public string Title { get; } = title;
	public Difficulty Difficulty { get; } = difficulty;
	public string Url { get; } = url;
}
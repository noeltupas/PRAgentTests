namespace PRAgentTests;

public interface ITestStuff
{
	void WriteThisString();
}

public class TestDependency(string test) : ITestStuff
{
	public void WriteThisString() => Console.WriteLine(test);
}


public class AnotherTestDependency(string test) : ITestStuff
{
	public void WriteThisString() => Console.WriteLine($"{test} again!");
}
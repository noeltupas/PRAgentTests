// See https://aka.ms/new-console-template for more information

using PRAgentTests;

string testStr = """
		In Project Mayhem, we have no name.
		But in death, we do.

		His name, is Robert Paulson.

		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		His name is Robert Paulson.
		""";


List<ITestStuff> stuff =
[
	new TestDependency(testStr),
	new AnotherTestDependency(testStr)
];


stuff.ForEach(thing => thing.WriteThisString());
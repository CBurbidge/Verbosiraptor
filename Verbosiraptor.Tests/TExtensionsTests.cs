using NUnit.Framework;

namespace Verbosiraptor.Tests
{
	[TestFixture]
	public class TExtensionsTests
	{
		public class Usages
		{
			public void IfThingInThings()
			{
				var things = new[] {"one", "two"};
				var thing = "";

				if (thing.IsIn(things))
				{
					// Do stuff...
				}
			}
		}

		[Test]
		public void IfThingInThings_WorksWithStrings()
		{
			var things = new[] {"one", "two"};
			var thing = "one";
			
			Assert.That(thing.IsIn(things));
		}

		[Test]
		public void IfThingInThings_WorksWithThings()
		{
			var thing1 = new Thing("one", "two");
			var thing2 = new Thing("three", "four");
			var things = new[] {
				thing1,
				thing2
			};
			var thing = thing1;
			
			Assert.That(thing.IsIn(things));
		}
	}

	public class Thing
	{
		private string _one;
		private string _two;

		public Thing(string one, string two)
		{
			_one = one;
			_two = two;
		}
	}
}

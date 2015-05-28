using System;
using Verbosiraptor; 
using NUnit.Framework;

namespace Verbosiraptor.Tests
{
	[TestFixture]
	public class ThereTests
	{
		public class Usages
		{
			public void IfThereAreAny()
			{
				var things = new[] {"one", "two"};

				if (There.AreAny(things))
				{
					
				}
			}
		}

		[Test]
		public void IfThereAreAny_ReturnsTrueIfSome()
		{
			var things = new[] {"one", "two"};

			Assert.That(There.AreAny(things));
		}
	}
}

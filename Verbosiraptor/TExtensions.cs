using System.Collections.Generic;
using System.Linq;

namespace Verbosiraptor
{
	public static class TExtensions
	{
		public static bool IsIn<T>(this T thing, IEnumerable<T> things)
		{
			return things.Contains(thing);
		}
	}
}

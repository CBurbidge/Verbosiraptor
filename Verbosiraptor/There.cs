using System.Collections.Generic;
using System.Linq;

namespace Verbosiraptor
{
    public static class There
    {
	    public static bool AreAny<T>(IEnumerable<T> things)
	    {
		    return things.Any();
	    }
    }
}

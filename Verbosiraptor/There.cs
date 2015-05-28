using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

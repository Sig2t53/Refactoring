using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }
    }
}

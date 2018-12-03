using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    class ChildrenPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }
    }
}

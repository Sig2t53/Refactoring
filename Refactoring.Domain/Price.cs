using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    public abstract class Price
    {
        public abstract int GetPriceCode();

        public double GetCharge(int dayRented)
        {
            double result = 0;
            switch (PriceCode)
            {
                case REGULAR:
                    result += 2;
                    if (dayRented > 2)
                    {
                        result += (dayRented - 2) * 1.5;
                    }
                    break;
                case NEW_RELEASE:
                    result += dayRented * 3;
                    break;
                case CHILDRENS:
                    result += 1.5;
                    if (dayRented > 3)
                    {
                        result += (dayRented - 3) * 1.5;
                    }
                    break;
            }
            return result;
        }
    }
}

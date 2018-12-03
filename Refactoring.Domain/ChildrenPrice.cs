namespace Refactoring.Domain
{
    class ChildrenPrice : Price
    {
        public override int PriceCode
        {
            get
            {
                return Movie.CHILDRENS;
            }
        }

        public override double GetCharge(int dayRented)
        {
            double result = 1.5;
            if (dayRented > 3)
            {
                result += (dayRented - 3) * 1.5;
            }
            return result;
        }
    }
}

namespace Refactoring.Domain
{
    public class RegularPrice : Price
    {
        public override int PriceCode
        {
            get
            {
                return Movie.REGULAR;
            }
        }

        public override double GetCharge(int dayRented)
        {
            double result = 2;

            if (dayRented > 2)
            {
                result += (dayRented - 2) * 1.5;
            }
            return result;
        }
    }
}

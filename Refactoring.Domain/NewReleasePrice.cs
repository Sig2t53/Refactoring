namespace Refactoring.Domain
{
    public class NewReleasePrice : Price
    {
        public override int PriceCode
        {
            get
            {
                return Movie.NEW_RELEASE;
            }

        }

        public override double GetCharge(int dayRented)
        {
            return dayRented * 3;
        }
    }
}

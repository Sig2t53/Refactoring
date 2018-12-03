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
    }
}

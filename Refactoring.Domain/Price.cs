namespace Refactoring.Domain
{
    public abstract class Price
    {
        public virtual int PriceCode { get; set; }

        public abstract double GetCharge(int dayRented);

        public virtual int GetFrequentRenterPoints(int dayRented)
        {
            return 1;
        }
    }
}

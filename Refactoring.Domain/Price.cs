namespace Refactoring.Domain
{
    public abstract class Price
    {
        public virtual int PriceCode { get; set; }

        public abstract double GetCharge(int dayRented);

        public int GetFrequentRenterPoints(int dayRented)
        {
            //新作を２日以上かりた場合はボーナスポイント
            if (PriceCode == Movie.NEW_RELEASE && dayRented > 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}

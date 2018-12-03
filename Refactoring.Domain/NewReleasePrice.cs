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

        public override int GetFrequentRenterPoints(int dayRented)
        {
            //新作を２日以上かりた場合はボーナスポイント
            return dayRented > 1 ? 2 : 1;
        }
    }
}

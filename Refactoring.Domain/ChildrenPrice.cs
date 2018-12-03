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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private Price _price;

        public string Title
        {
            get
            {
                return _title;
            }
        }
        public int PriceCode
        {
            get
            {
                return _price.PriceCode;
            }
            set
            {
                switch(value)
                {
                    case REGULAR:
                        _price = new RegularPrice();
                        break;
                    case CHILDRENS:
                        _price = new ChildrenPrice();
                        break;
                    case NEW_RELEASE:
                        _price = new NewReleasePrice();
                        break;
                    default:
                        throw new ArgumentException("不正な料金コード");
                }
            }
        }

        public Movie(string title,int priceCode)
        {
            _title = title;
            PriceCode = priceCode;
        }

        public int GetFrequentRenterPoints(int dayRented)
        {
            return _price.GetFrequentRenterPoints(dayRented);
        }

        public double GetCharge(int dayRented)
        {
            return _price.GetCharge(dayRented);
        }

    }
}

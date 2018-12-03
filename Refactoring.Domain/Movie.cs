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
        private int _priceCode;

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
                return _priceCode;
            }
        }

        public Movie(string title,int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
        }

        public double GetCharge()
        {
            double result = 0;
            switch (Movie.PriceCode)
            {
                case Movie.REGULAR:
                    result += 2;
                    if (DayRented > 2)
                    {
                        result += (DayRented - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    result += DayRented * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (DayRented > 3)
                    {
                        result += (DayRented - 3) * 1.5;
                    }
                    break;
            }
            return result;
        }

    }
}

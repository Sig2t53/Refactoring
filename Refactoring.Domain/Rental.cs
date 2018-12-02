using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    public class Rental
    {
        private Movie _movie;
        private int _dayRented;

        public Rental(Movie movie,int dayRented)
        {
            _movie = movie;
            _dayRented = dayRented;
        }

        public Movie Movie
        {
            get
            {
                return _movie;
            }
        }

        public int DayRented
        {
            get
            {
                return _dayRented;
            }
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

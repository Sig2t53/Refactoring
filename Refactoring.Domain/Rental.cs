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
    }
}

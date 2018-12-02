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

    }
}

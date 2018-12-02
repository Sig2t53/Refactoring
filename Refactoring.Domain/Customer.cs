using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Domain
{
    public class Customer
    {

        private string _name;
        private List<Rental> _rentals=new List<Rental>();
         
        public Customer(string name)
        {
            _name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + Name + "\n"; 

            foreach(Rental rental in _rentals)
            {
                double thisAmount = 0;
                thisAmount = amountFor(rental);
                //レンタルポイントを加算
                frequentRenterPoints++;

                //新作を２日以上かりた場合はボーナスポイント
                if(rental.Movie.PriceCode == Movie.NEW_RELEASE && rental.DayRented > 1)
                {
                    frequentRenterPoints++;
                }
                result += "\t" + rental.Movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }
            //フッタの追加
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + "frequent Renter Points";

            return result;
        }

        private double amountFor(Rental rental)
        {
            double thisAmount = 0;
            switch (rental.Movie.PriceCode)
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (rental.DayRented > 2)
                    {
                        thisAmount += (rental.DayRented - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += rental.DayRented * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (rental.DayRented > 3)
                    {
                        thisAmount += (rental.DayRented - 3) * 1.5;
                    }
                    break;
            }
            return thisAmount;
        }
    }
}

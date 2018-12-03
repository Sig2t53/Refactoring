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
                frequentRenterPoints += rental.GetFrequentRenterPoints();
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge().ToString() + "\n";
                totalAmount += rental.GetCharge();
            }
            //フッタの追加
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + "frequent Renter Points";

            return result;
        }


    }
}

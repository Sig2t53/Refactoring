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
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + Name + "\n"; 

            foreach(Rental rental in _rentals)
            {
                frequentRenterPoints += rental.GetFrequentRenterPoints();
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge().ToString() + "\n";
            }
            //フッタの追加
            result += "Amount owed is " + GetTotalCharge().ToString() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints().ToString() + "frequent Renter Points";

            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;

            foreach (Rental rental in _rentals)
            {
                result += rental.GetCharge();    
            }

            return result;
        }

        private double GetTotalFrequentRenterPoints()
        {
            int result = 0;

            foreach (Rental rental in _rentals)
            {
                result += rental.GetFrequentRenterPoints();
            }

            return result;
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Domain;

namespace RefactoringTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void 新作テスト()
        {
            Movie newMovie1 = new Movie("テスト新作1",Movie.NEW_RELEASE);
            Movie newMovie2 = new Movie("テスト新作2", Movie.NEW_RELEASE);

            Rental newRental1 = new Rental(newMovie1, 1);
            Rental newRental2 = new Rental(newMovie2, 2);

            Customer customer = new Customer("テスト顧客");
            customer.AddRental(newRental1);
            customer.AddRental(newRental2);
            Assert.AreEqual(customer.Statement()
                           ,"Rental Record for テスト顧客\n\tテスト新作1\t3\n\tテスト新作2\t6\nAmount owed is 9\nYou earned 3frequent Renter Points"
            );
        }

        [TestMethod]
        public void 一般作テスト()
        {
            Movie regularMovie1 = new Movie("テスト一般1", Movie.REGULAR);
            Movie regularMovie2 = new Movie("テスト一般2", Movie.REGULAR);

            Rental regularRental1 = new Rental(regularMovie1, 1);
            Rental regularRental2 = new Rental(regularMovie2, 4);

            Customer customer = new Customer("テスト顧客");
            customer.AddRental(regularRental1);
            customer.AddRental(regularRental2);
            Assert.AreEqual(customer.Statement()
                           , "Rental Record for テスト顧客\n\tテスト一般1\t2\n\tテスト一般2\t5\nAmount owed is 7\nYou earned 2frequent Renter Points"
            );
        }

        [TestMethod]
        public void 子供用テスト()
        {
            Movie childMovie1 = new Movie("テスト子供1", Movie.CHILDRENS);
            Movie childMovie2 = new Movie("テスト子供2", Movie.CHILDRENS);

            Rental childRental1 = new Rental(childMovie1, 1);
            Rental childRental2 = new Rental(childMovie2, 5);

            Customer customer = new Customer("テスト顧客");
            customer.AddRental(childRental1);
            customer.AddRental(childRental2);
            Assert.AreEqual(customer.Statement()
                           , "Rental Record for テスト顧客\n\tテスト子供1\t1.5\n\tテスト子供2\t4.5\nAmount owed is 6\nYou earned 2frequent Renter Points"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    //inheritance: that the class in question is inheriting/getting all the public OR protected members of the base class
    public class SavingsAccount: BankAccount
    {
        public SavingsAccount(string iban, double balance, User owner, double interestRate) : base  (iban, balance, owner)
        {
            InterestRate = interestRate;
        }
         
        public double InterestRate { get; set; }
         
        /// <summary>
        /// Basically this calculates the end balance of the year according the interest rate set
        /// </summary>
        /// <returns>It returns the actual interest</returns>
        public double CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }

    }


 
}

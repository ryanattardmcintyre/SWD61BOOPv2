using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{

    public enum AccountStatus { Active, Suspended, Frozen, Disabled, Closed }

    public class BankAccount
    {

        /// <summary>
        /// Default constructor (is usually also the parameterless constructor)
        /// </summary>
        public BankAccount()
        {
            Balance = 0;
            OpeningDate = DateTime.Now;
        }
        /// <summary>
        /// 2nd Constructor with parameters
        /// </summary>
        /// <param name="iban"></param>
        /// <param name="balance"></param>
        /// <param name="owner"></param>
        public BankAccount(string iban, double balance, User owner) : this()
        {
            Iban =  iban;
            Balance =  balance;
            Owner =  owner;
        }

        public string Iban { get; set; }
        protected double Balance { get; set; } //if you want to allow access to this property ONLY from inherited classes
        public User Owner { get; set; }

        public DateTime OpeningDate { get; }
        public DateTime? ClosingDate { get; set; } //value stored inside this property/field can also be null

        public AccountStatus Status { get; set; }

        public double Withdraw(double amount) {
            //log the withrawal tranaction
            if(amount <= Balance)
                    Balance -= amount;

            return Balance;

        }
        public double Deposit(double amount) {

            Balance += amount;
            return Balance;
        
        }

    }
}

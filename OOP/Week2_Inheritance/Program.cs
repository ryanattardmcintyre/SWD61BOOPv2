using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           /* SavingsAccount mySavingsAccount = new SavingsAccount(); //created an instance of SavingsAccount. name of instance: mySavingAccount
            mySavingsAccount.Balance = 1000;
            mySavingsAccount.InterestRate = 5;
            double interestInEuros = mySavingsAccount.CalculateInterest();
           */

            User myUser = new User();
            myUser.IdCard = "3838383";
            myUser.Name = "Joe";
            myUser.Surname = "Borg";

            // BankAccount b = new BankAccount("585858588585858585", 100, myUser );
            SavingsAccount s = new SavingsAccount("585858588585858585", 1000, myUser, 1.5);
            

           double updatedBalance =  s.Withdraw(100);


        }
    }
}

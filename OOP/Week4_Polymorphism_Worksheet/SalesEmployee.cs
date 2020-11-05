using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    public class SalesEmployee: Employee
    {
        public double Bonus { get; set; }

        public override double CalculateTotalPay()
        {
            return Bonus + BasePay;
        }
         
    }
}

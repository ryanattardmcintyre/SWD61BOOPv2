using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    public class Employee 
    {
        public Employee()
        { }


        public string IdCard { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }


        public virtual double CalculateTotalPay()
        {
            return BasePay;
        }

        public override int GetHashCode()
        {
            return IdCard.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.GetHashCode() == obj.GetHashCode())
                return true;
            else return false;
        }
    }
}

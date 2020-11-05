using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism_Worksheet
{
    class Program
    {
        //asking the end user to input a number
        //we will create a loop to keep asking the user to input details about employees
        //we will ask the user what to input employee? or salesemployee?
        //we will store all the employees in a list
        //we will output all the calculated wages

        //the user inputs the idcard of the employee & you need to verify that when being input the employee is unique


        static void Main(string[] args)
        {
            Console.WriteLine("Please input how many employees you recruited?");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            List<Employee> myList = new List<Employee>();

            int choice = 0;
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. Sales Employee");
                Console.WriteLine("Input value: (1 or 2)");
                choice = Convert.ToInt32(Console.ReadLine());

                Employee emp = null ;
                switch(choice)
                {
                    case 1:
                        emp = new Employee();
                        Console.WriteLine("Id please");
                        emp.IdCard = Console.ReadLine();


                        Console.WriteLine("Name please");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Salary please");
                        emp.BasePay = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 2:

                        emp = new SalesEmployee();

                        Console.WriteLine("Id please");
                        emp.IdCard = Console.ReadLine();

                        Console.WriteLine("Name please");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Salary please");
                        emp.BasePay = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Bonus please");
                       ((SalesEmployee)emp).Bonus = Convert.ToDouble(Console.ReadLine());
                  
                        break;

                    default:
                        Console.WriteLine("The choice is not valid");
                        break;
                }

                if (myList.IndexOf(emp) == -1  && emp != null) //search for this emp, if index == -1 then not found, if index != -1 then it is found
                {
                    myList.Add(emp);
                }

            }


            Console.WriteLine("Press a key to calculate all wages:");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            foreach (Employee employee in myList)
            {

                Console.WriteLine($"Employee ({employee.GetType().Name}) {employee.Name} earns \n Euros{employee.CalculateTotalPay()}");
            }
           
            Console.WriteLine("Press a key to terminate...");
            Console.ReadKey();


        }
    }
}

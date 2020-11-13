using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet2
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = new Car[2];


            Car car1 = new Car();
            car1.Manufacturer = "Honda";
            car1.Colour = "White";
            car1.Litres = 1.5;
            car1.OdometerReading = 1000;
            car1.TypeOfFuel = "Diesel";

            Car car2 = new Car();
            car2.Manufacturer = "Fiat";
            car2.Colour = "Black";
            car2.Litres = 1;
            car2.OdometerReading = 5000;
            car2.TypeOfFuel = "Petrol";


            //Console.WriteLine("Input manufacturer");
            //car1.Manufacturer = Console.ReadLine();
            cars[0] = car1;
            cars[1] = car2;

            for (int i = 1; i < cars.Length; i++)
            {
                Console.WriteLine($"{i}. {cars[i-1].Manufacturer}");
            }
            Console.WriteLine("Choose: ");
            int carChoice =  Convert.ToInt32(Console.ReadLine());

            int choice = 0;
            do
            {
                Console.WriteLine("1. Drive Car");
                Console.WriteLine("2. Fill with fuel");
                Console.WriteLine("3. Change car details");
                Console.WriteLine("4. Repaint");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Input menu option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Car chosenCar = cars[carChoice - 1];

                switch(choice)
                {
                    case 1:
                        chosenCar.DriveCar();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("you are exitting the application...");
                        break;

                    default:
                        Console.WriteLine("Invalid menu option!");
                        break;
                }


            } while (choice != 5);

            Console.ReadKey();


        }
    }
}

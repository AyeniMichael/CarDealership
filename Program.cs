using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
    public class Program
    {
        public static void Main()
        {
            Car volkswagen = new Car("Volkwagen Passat", 16782, 8000);
            Car bmw = new Car("BMW 406", 15000, 9000);
            Car Lamboghini = new Car("Lambo 409", 28000, 12000);

            List<Car> cars = new List<Car>() {volkswagen, bmw, Lamboghini};

            Lamboghini.SetPrice(17000);
            Lamboghini.SetMileage(9500);
        
            Console.WriteLine("Enter maximum Price");
            string inputPrice = Console.ReadLine();

            Console.WriteLine("Enter maximun mileage");
            string inputMileage = Console.ReadLine();

            Console.WriteLine("Enter Speed Limit");
            string inputSpeed = Console.ReadLine();
            
            int maxPrice = int.Parse(inputPrice);
            int maxMileage = int.Parse(inputMileage);
            int maxSpeed = int.Parse(inputSpeed);

            List<Car> carsMatchingSearch = new List<Car>() {};

            Console.WriteLine(Car.SpeedLimit(maxSpeed));

            foreach (Car automobile in cars)
            {
                if (automobile.worthbuying(maxPrice, maxMileage))
                {
                    carsMatchingSearch.Add(automobile);
                }
                else
                {
                    Console.WriteLine("The amount or mileage you entered does not meeet the specs of the available cars");
                }
            }

            foreach (Car car in carsMatchingSearch)
            {
                Console.WriteLine(car.GetMakeModel());
                Console.WriteLine(car.GetMileage());
                Console.WriteLine(car.GetPrice());
            }
        }
    }
}


    

    

    

    


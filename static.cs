using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("X6");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();    
        }
        
    }
    
    class Car
    {
        String model;
        public static int numberOfCars;
        public Car(String model) 
        { 
            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("Start the race!");
        }
    }
}

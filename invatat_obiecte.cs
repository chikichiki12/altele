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
            Car car1 = new Car("Ford", "Mustang", 1978, "Red");
            Car car2 = new Car("Audi", "X6", 2022, "Black");

            car1.Drive();
            car2.Own();
        }
        
    }
    
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Own()
        {
            Console.WriteLine($"You own a {make} {model}.");
        }
        public void Drive()
        {
            Console.WriteLine($"You drive a {color} {make} {model}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        

        //A no-arguments constructor that sets data members to default values (blanks or your choice)
        public Car() 
        
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        //A constructor with four arguments matching the order above

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        //A ToString() method returning a formatted string with the car details
        public string ToString()
        {
            return $"{Make} {Model} {Year} {Price}";
        }
        //  Create an instance of List<Car> that can hold instances of Car and any class derived from Car.Make this list a public static member of Car.
       public static List<Car> cars = new List<Car>();

        //Add a public static method to Car called ListCars that loops through the list and prints out each member and its index in the list.
        //(Hint: Use a regular for loop, not a foreach loop so you  can print out the index.)

        public static void ListCars()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine((i+1) + " " + cars[i].ToString());
            }
        }
        //Add a public static method to Car called Remove which takes an integer parameter and removes the car whose index is that parameter

        public static void  Remove(int removeCar) 
        
        {
            cars.Remove(cars[removeCar]);
        }

    }
}

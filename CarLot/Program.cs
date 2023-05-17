using CarLot;
using static System.Net.Mime.MediaTypeNames;



Car.cars.Add(new Car("ford", "pinto", 1970, 13000));
Car.cars.Add(new Car("kia", "sorento", 2021, 25000));
Car.cars.Add(new Car("suburu", "forester", 2023, 50000));
Car.cars.Add(new UsedCar("nissan", "versa", 2011, 2000, 80000));
Car.cars.Add(new UsedCar("acura", "rsx", 2019, 25000, 100000));
Car.cars.Add(new UsedCar("toyota", "corolla", 1994, 5000, 285000));

Car.ListCars();

//In your main, print out the list (by calling the ListCar method).
//Then ask the user which car they would like to buy, by number (the index of the car).


Console.WriteLine("Which car would you like? Pick a number");
int input = int.Parse(Console.ReadLine());

//Print out the details for the chosen car. (Think about how to print out this information:
//You’ll access the item in the list by index, and call Console.WriteLine.)

Console.WriteLine(Car.cars[input- 1].Make +" " + Car.cars[input - 1].Model + " " +  Car.cars[input - 1].Year + " $" + Car.cars[input - 1].Price);


Console.WriteLine("Excellent! Our finance department will be in touch");

Car.Remove(input- 1);

Car.ListCars();
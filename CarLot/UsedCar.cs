using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    internal class UsedCar : Car
    {
        public double Milage { get; set; }

        //Constructor: Takes five arguments and calls the four-argument constructor for Car and saves the mileage argument
        public UsedCar(string make, string model, int year, double price, double milage) : base(make, model, year, price)
        {
            this.Milage = milage;
        }
        public string ToString()
        {
            return $"{Make}{Model}{Year}{Price}{Milage}";
        }
    }

}

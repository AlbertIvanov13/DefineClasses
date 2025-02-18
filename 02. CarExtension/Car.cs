using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }


        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double fuel = FuelQuantity - distance * FuelConsumption / 100;
            if (fuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                fuelQuantity = 0;
            }
            else
            {
                FuelQuantity -= distance * (FuelConsumption / 100);
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:f2}";
        }
    }
}
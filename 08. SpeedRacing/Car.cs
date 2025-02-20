using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
			this.Model = model;
			this.fuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public Car(string model)
        {
            this.Model = model;
        }

        public Car()
        {
            
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}


		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}


		public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}

		public void Drive(Dictionary<string, Car> cars, string model, double amountOfKm)
		{
            foreach (var car in cars.Keys)
            {
                if (car == model)
                {
                    if (cars[car].FuelAmount - cars[car].FuelConsumptionPerKilometer * amountOfKm >= 0)
                    {
                        cars[car].FuelAmount -= cars[car].FuelConsumptionPerKilometer * amountOfKm;
                        cars[car].TravelledDistance += amountOfKm;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                        break;
                    }
                }
            }
		}
	}
}
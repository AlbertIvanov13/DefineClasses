using System.Collections.Immutable;

namespace CarManufacturer
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string tiresInput = Console.ReadLine();

            Tire[] tires = new Tire[4];
            Engine[] engines = new Engine[2];
            List<Car> cars = new List<Car>();
            List<Tire[]> newTires = new List<Tire[]>();
            List<Engine[]> newEngines = new List<Engine[]>();
            while (tiresInput != "No more tires")
            {
                string[] array = tiresInput.Split(" ").ToArray();
                tires = new Tire[]
                {
                    new Tire(int.Parse(array[0]), double.Parse(array[1])),            
                    new Tire(int.Parse(array[2]), double.Parse(array[3])),            
                    new Tire(int.Parse(array[4]), double.Parse(array[5])),            
                    new Tire(int.Parse(array[6]), double.Parse(array[7]))           
                };
                newTires.Add(tires);
                tiresInput = Console.ReadLine();
            }

            string enginesInput = Console.ReadLine();
            while (enginesInput != "Engines done")
            {
                string[] array = enginesInput.Split(" ").ToArray();
                engines = new Engine[]
                {
                    new Engine(int.Parse(array[0]), double.Parse(array[1]))
                };
                newEngines.Add(engines);
                enginesInput = Console.ReadLine();
            }

            string carInput = Console.ReadLine();
            while (carInput != "Show special")
            {
                string[] carInfo = carInput.Split(" ").ToArray();
                string horsePower = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);

                Car car = new Car(horsePower, model, year, fuelQuantity, fuelConsumption, newEngines[engineIndex], newTires[tireIndex]);

                cars.Add(car);


                carInput = Console.ReadLine();
            }

            foreach (Car car in cars.Where(c => c.Year >= 2017))
            {
                car.FuelQuantity -= (car.FuelConsumption / 100) * 20;
            }

            foreach (Car car in cars.Where(c => c.Year >= 2017 && c.Engines.Any(e => e.HorsePower > 330) && c.Tires.Sum(tires => tires.Pressure) >= 9 && c.Tires.Sum(tires => tires.Pressure) <= 10))
            {
                string result = $"Make: {car.Make}\n" +
                    $"Model: {car.Model}\n" +
                    $"Year: {car.Year}\n" +
                    $"HorsePowers: {car.Engines[0].HorsePower}\n" +
                    $"FuelQuantity: {car.FuelQuantity}";

                Console.WriteLine(result);
            }
        }
    }
}
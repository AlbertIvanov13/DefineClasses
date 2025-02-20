namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                Car car = new Car();

                car.Drive(cars, model, amountOfKm);
                

                command = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} {item.Value.FuelAmount:f2} {item.Value.TravelledDistance}");
            }
        }
    }
}
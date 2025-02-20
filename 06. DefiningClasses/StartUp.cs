namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Peter", 20);

            Console.WriteLine($"{person1.Name} {person1.Age}");

        }
    }
}
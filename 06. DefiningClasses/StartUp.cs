namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.WriteLine($"{person1.Name} {person1.Age}");

            Person person2 = new Person("George", 18);

            Console.WriteLine($"{person2.Name} {person2.Age}");

            Person person3 = new Person("Jose", 43);

            Console.WriteLine($"{person3.Name} {person3.Age}");

        }
    }
}
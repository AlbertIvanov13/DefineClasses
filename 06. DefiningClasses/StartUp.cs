namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] members = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = members[0];
                int age = int.Parse(members[1]);
                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }
}
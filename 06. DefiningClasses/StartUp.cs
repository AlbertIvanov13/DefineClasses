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

            var orderedPeople = family.People.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            foreach (Person person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
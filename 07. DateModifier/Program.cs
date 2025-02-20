namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(startDate, endDate);

            Console.WriteLine(dateModifier.CalculateDatesDifference(startDate, endDate));
        }
    }
}
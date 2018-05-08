namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AskP1ForNameAndAge();
            p1.CreateSpouse();

            Person p2 = new Person();
            p2.AskP2ForNameAndAge();
            p2.CreateSpouse();

            System.Console.WriteLine("Average Age" + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}

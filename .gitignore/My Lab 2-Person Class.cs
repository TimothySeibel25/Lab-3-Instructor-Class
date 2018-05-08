namespace ConsoleApplication1
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person spouse;

        public static int count;
        public static int sumOfAllAges;
        public static double averageAge()
        {
            return (double)Person.SumOfAllAges / double Person.count;

        }
        public String getFullName;
    {
        return this.FirstName + " " + LastName;
      }
    public void PrintNameAndAge()
    {
        System.Console.WriteLine("What is person first name?");
        this.FirstName = System.Console.ReadLine;
        System.Console.WriteLine("What is person last name?");
        this.LastName = System.Console.ReadLine;
        System.Console.WriteLine("What is person age?");
        this.Age = int.Parse(System.Console.ReadLine());
        }
    {
        this.Spouse = new person();
        this.Spouse.AskForSpouseNameAndAge();
        this.Spouse.Spouse = this;
    }
}

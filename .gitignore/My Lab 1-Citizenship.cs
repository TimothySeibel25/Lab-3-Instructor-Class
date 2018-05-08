namespace Project1
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName;
			string middleInitial;
			string lastName;
			string fullName;
			int age;
			bool isCitizen;
			bool canVote;
			int heightFeet;
			double heightInches;
			double totalHeightCM;

            System.Console.Write("What is your name?");
            System.Console.ReadLine();
            System.Console.Write("How tall are you in feet?");
            System.Console.ReadLine();
            System.Console.ReadLine("What is your height in remaining inches?");
            totalUserHeightCentimeters = (heightFeet * 12 + hightInches) * 2.54;
            System.Console.Write("What is your age?");
            int age = int.Parse(Console.ReadLine());
            bool isCitizen = Console.ReadLine());
            bool canVote = isCitizen && age >= 18;

            Console.WriteLine("User name" = fullName);
            Console.WriteLine("User height in centimeters" = totalHeightCM);
            Console.WriteLine("User can vote!");
            }
	}
}

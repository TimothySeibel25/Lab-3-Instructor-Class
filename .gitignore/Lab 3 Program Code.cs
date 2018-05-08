namespace Lab 3: Instructor & Student
{
    class Program
    {
        static void Main(string[] args)
        {
        Instructor John = new Instructor("John", "English");
        Instructor Mike = new Instructor("Mike", "Math");
        Student Jane = new Student("Jane", John);
        Student Joe = new Student("Joe", John);
        Student Melissa = new Student("Melissa", Mike);
        Student Matt = new Student("Matt", Mike);
        John.setStudentGrade(Jane, 95);
        John.setStudentGrade(Joe, 85);
        Mike.setStudentGrade(Melissa, 90);
        Mike.setStudentGrade(Matt, 92);
        Jane.studentPrintInfo();
        Joe.studentPrintInfo();
        Melissa.studentPrintInfo();
        Matt.studentPrintInfo();
        System.Console.ReadKey();
        }
    }
}

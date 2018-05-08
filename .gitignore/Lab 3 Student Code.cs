namespace ConsoleApplication1
{
    class Student
    {
        private string name;
        private int grade;
        private Instructor Teacher;
        public Student(string name, Instructor teacher);
        {
        this.name = Name;
        this.Instructor = teacher;
        this.grade = 0;
        }
        public void setGrade(int grade);
    {
        this.grade = Grade;
       }
    public void Print();
    {
    System.Console.WriteLine("Student:" + this.name + "Grade:" + this.grade + "Instructor:" + this.Instructor);
    }
    }
}

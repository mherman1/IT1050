namespace Lab3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public string NameAndGrade()
        {
            return Name + " has a grade of " + Grade;
        }

        public void PrintNameGradeAndTeacher()
        {
            System.Console.WriteLine (NameAndGrade() + " and " + Teacher.NameAndCourse());
        }
    }
}

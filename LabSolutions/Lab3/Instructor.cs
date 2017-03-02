namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public string NameAndCourse()
        {
            return Name + " is the " + CourseName + " teacher.";
        }

        public void PrintNameAndCourse()
        {
            System.Console.WriteLine(NameAndCourse());
        }
    }
}

﻿namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");
            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.PrintNameGradeAndTeacher();
            joe.PrintNameGradeAndTeacher();
            melissa.PrintNameGradeAndTeacher();
            matt.PrintNameGradeAndTeacher();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }

    }
}

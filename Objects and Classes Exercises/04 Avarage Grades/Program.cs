using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int name = 0; name < entry; name++)
            {
                Student oneStudent = new Student();

                List<string> studentData = Console.ReadLine().Split().ToList();

                string studentName = studentData[0];

                oneStudent.Name = studentName;

                List<double> oneStudentGrades = new List<double>();

                for (int grade = 1; grade < studentData.Count; grade++)
                {
                    double studentGrade = double.Parse(studentData[grade]);
                    oneStudentGrades.Add(studentGrade);
                }
                oneStudent.Grades = oneStudentGrades;
                students.Add(oneStudent);
            }
            List<Student> notableStudents = students.OrderBy(student => student.Name).ThenByDescending(student => student.AverageGrade).ToList();
            foreach (var student in notableStudents)
            {
                if (student.AverageGrade >= 5)
                {
                    Console.WriteLine("{0:f2} -> {1:f2}", student.Name, student.AverageGrade);
                }

            }
        }
    }
}
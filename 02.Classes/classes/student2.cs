using System;
using System.Globalization;
namespace classes
{

    public record Enrollment2(string Course, int Grade, int CreditHours);

   public class Student2
    {
        public required string Name {get; set;}
        public double FinalGpa
        {
            get
            {
                
            int sumCredit = 0;
            int GradeMultiplicatedeCredit = 0;

            foreach(var enroll in Enrollments)
            {
               sumCredit += enroll.CreditHours;
               GradeMultiplicatedeCredit += enroll.Grade * enroll.CreditHours; 
            }

            return sumCredit == 0 ? 0 : (double)GradeMultiplicatedeCredit / sumCredit; // Expressão ternária if/else
            }
        }

        public List<Enrollment2> Enrollments {get; set;} = [];

        public void AddEnrollment(Enrollment2 enrollment)
        {
            Enrollments.Add(enrollment);
        }
        public void AddEnrollment(string course, int grade, int creditHours)
        {
            Enrollments.Add(new Enrollment2(course, creditHours, grade));
        }

        public void ShowGlobalInfo()
        {
            System.Console.WriteLine($"Student: {Name}\n");
            System.Console.WriteLine($"{"Course", -20}{"Grade", 10}{"Credit Hours", 15}");

            foreach(var enroll in Enrollments)
            {
                System.Console.WriteLine($"{enroll.Course, -20}{enroll.Grade, 10}{enroll.CreditHours, 15}");
            }
            System.Console.Write($"\n{"Final GPA:", -30}");
            System.Console.WriteLine(FinalGpa.ToString("F2", CultureInfo.InvariantCulture));

        }
    } 
}
using System;

namespace classes
{
    internal class Program
    {
        static void Main()
        {
            List<Enrollment> listEnrollments = new List<Enrollment>
            {
                new Enrollment ("English 101", 4,3),
                new Enrollment ("Algebra 101", 3,3),
                new Enrollment ("Biology 101", 3,4),
                new Enrollment ("Computer Science I", 3,4),
                new Enrollment ("Psychology 101", 4,3),
                

            };
            var student1 = new Student() {Name = "Matheus"};

            foreach(var enroll in listEnrollments)
            {
                student1.AddEnrollment(enroll);
            }
            student1.ShowGlobalInfo();
        }
    }
}



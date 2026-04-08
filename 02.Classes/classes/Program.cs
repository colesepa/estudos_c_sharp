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
            
            List<Enrollment2> listEnrollments2 = new List<Enrollment2>
            {
                new Enrollment2 ("English 101", 4,3),
                new Enrollment2 ("Algebra 101", 3,3),
                new Enrollment2 ("Biology 101", 3,4),
                new Enrollment2 ("Computer Science I", 3,4),
                new Enrollment2 ("Psychology 101", 4,3),
                

            };
            var student2 = new Student2() {Name = "João Gabriel"};

            foreach(var enroll in listEnrollments2)
            {
                student2.AddEnrollment(enroll);
            }
            student2.ShowGlobalInfo();
        }
    }
}



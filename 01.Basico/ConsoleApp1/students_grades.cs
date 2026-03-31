public class Student
{
    public required string Name {get; set;}
    public required int Age {get; set;}
    
    private readonly List<double> _grades = new();

    public IReadOnlyList<double> Grades => _grades;

    public void AddGrade(double grade)
    {
        if (grade is < 0 or > 100)
            throw new ArgumentException("Nota Inválida!");
        else
            _grades.Add(grade);
    }
}
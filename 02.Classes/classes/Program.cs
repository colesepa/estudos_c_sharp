Student Sophia = new()
{
    Name = "Sophia",
    Age = 16
};

Console.WriteLine($"Student`s Name: {Sophia.Name} \nStudent`s Age: {Sophia.Age}");

var SophiaGrades = new List<double> {93, 87, 98, 95, 100};


Sophia.AddGrades(SophiaGrades);

Console.WriteLine($"{Sophia.GetGradesAsStrings()}");



class Student{
  public string Name {get; set;}
  public int Grade {get; set;}
}

var s = new Student {Name = "Alice", Grade = 15};
Console.WriteLine($"{s.Name} has a grade of {s.Grade}!");

var students = new List<Student>{
  new Student { Name = "Ana", Grade = 15 },
  new Student { Name = "Colombe", Grade = 19 },
  new Student { Name = "Jo", Grade = 18 },
  new Student { Name = "Sarah", Grade = 10 },
  new Student { Name = "Dior", Grade = 2 },
};

foreach (var s in students){
  Console.WriteLine($"{s.Name} has a grade of {s.Grade}");
}

var passed =  students.Where(st => st.Grade >= 10).ToList();


Console.WriteLine("PASSED\n");

foreach (var s in passed){
  Console.WriteLine($"{s.Name} has a grade of {s.Grade}");
}


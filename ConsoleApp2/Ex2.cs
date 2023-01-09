using ConsoleApp2;

StudentInformation firstStudent = new StudentInformation();
Console.Write("Enter the name of that student: ");
firstStudent.Name = Console.ReadLine();
Console.Write("Enter the age of that student: ");
firstStudent.Age = int.Parse(Console.ReadLine());
Console.Write("Enter the GPA of that student: ");
firstStudent.Gpa = double.Parse(Console.ReadLine());
Console.WriteLine(firstStudent);
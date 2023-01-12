namespace Classwork3
{
    class Function
    {
        List<Student> students = new List<Student>();
  
        public void AddAStudentToList()
        {
            Console.WriteLine("Enter the information about student");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter student grade: ");
            double grade = double.Parse(Console.ReadLine());
            Student student = new Student(name, age, grade);
            students.Add(student);
        }

        public void FindByName(string studentName)
        {
            foreach (Student item in students)
            {
                if (item.Name == studentName) Console.WriteLine(item);
            }
        }
        
        public  void Menu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Add a student to the list");
            Console.WriteLine("2. Find a student by name");
            Console.WriteLine("3. Exit");
            Console.WriteLine("--------------------");
        }

    }
}
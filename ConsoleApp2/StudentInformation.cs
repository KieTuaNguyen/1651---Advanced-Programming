namespace ConsoleApp2;

public class StudentInformation:Object
{
    //Field
    private int age;
    private double gpa;
    private string name;
    
    //Properties
    public int Age
    {
        set { if(value>0) age = value;  }
        get { return age;  }
    }

    public double Gpa
    {
        set { if(value>0 || value<=4) gpa = value;  }
        get { return gpa;  }
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    
    public void DisplayInformation()
    {
        Console.WriteLine($"Student named " + name +  " with age " + age + " has a GPA of " + gpa + ".");
    }
    
    public override string ToString()
    {
        return $"Student named " + name +  " with age " + age + " has a GPA of " + gpa + ".";
    }
}
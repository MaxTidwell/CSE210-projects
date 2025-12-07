using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}


/*
example 

// the parent class showing the abstract keyword included
public abstract class Employee
{
  private string _employeeName;

  // Notice the abstract method doesn't have a body at all (not even an empty one)
  // and it is followed by a semicolon.
  public abstract float CalculatePay();
}

// a child class
public class SalaryEmployee : Employee
{
  private float salary = 100f;

  public override float CalculatePay()
  {
    return salary;
  }
}

// a child class
public class HourlyEmployee : Employee
{
  private float rate = 9f;
  private float hours = 100f;

  public override float CalculatePay()
  {
    return rate * hours; // pay is calculated differently
  }
}

*/
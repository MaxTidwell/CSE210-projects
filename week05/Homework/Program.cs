using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Dave");
        assignment1.SetTopic("Math");

        Console.WriteLine(assignment1.GetSummary());


        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Bill");
        assignment2.SetTopic("Math");
        assignment2.SetTextbookSelection("7.3");
        assignment2.SetProblems("8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());


        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Mary");
        assignment3.SetTopic("Writing");
        assignment3.SetTitle("The Causes of World War II");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}
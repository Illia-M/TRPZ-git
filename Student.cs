using System;
class Program
{
    static void Main(string[] args)
    { 
   Student student = new Student();
        student.FirstName = "Sofia";
        student.LastName = "Tanchuk";
       Console.WriteLine($"My name is {student.FirstName} {student.LastName}");
    }
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

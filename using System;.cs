using System;

class Student
{
    public string name;
    public int age;

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.name = "Sandriya";
        s1.age = 20;

        s1.Display();
    }
}
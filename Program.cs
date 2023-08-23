using System;

public class Person
{
    public int age;

    public Person(int age)
    {
        this.age = age;
    }

    public Person()
    {

    }

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public int SetAge
    {
        get { return age; }
        set { age = value; }
    }

}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is " + age + " years old.");
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

class StudentProfessorTest
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        Student student = new Student();
        Teacher prof = new Teacher();

        Console.Write("Person: ");
        person.Greet();

        Console.Write("Student: ");
        student.age = 21;
        student.Greet();
        Console.Write("Student: ");
        student.ShowAge();

        Console.Write("Teacher: ");
        prof.Greet();
        Console.Write("Teacher: ");
        prof.Explain();
    }
}
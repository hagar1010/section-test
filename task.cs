using System;

namespace OopSection;

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        if (name == null || name == "" || name.Length >= 32)
        {
            throw new NullReferenceException("Invalid Name");
        }
        if (age <= 0 || age > 128)
        {
            throw new NullReferenceException("Invalid Age");
        }
        this.Name = name;
        this.Age = age;
    }

    public virtual void Print(){}
}













public class Student : Person
{
    public int Year;
    public float Gpa;

    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        if (year <= 0 || year > 4)
        {
            throw new NullReferenceException("Invalid Year");
        }
        if (gpa < 0 || gpa > 4)
        {
            throw new NullReferenceException("Invalid GPA");
        }
        this.Year = year;
        this.Gpa = gpa;
    }

    public override void Print()
    {
        Console.WriteLine($"My name is {Name} , My age is {Age} , and my GPA is {Gpa}");
    }
}
















public class Staff : Person
{
    public int Salary;
    public int JoinYear;

    public Staff(string name, int age, int salary, int joinyear) : base(name, age)
    {
        if (salary <= 0 || salary > 120000)
        {
            throw new NullReferenceException("Not acceptable salary");
        }
        if (joinyear < 21)
        {
            throw new NullReferenceException("Invalid age");
        }
        this.Salary = salary;
        this.JoinYear = joinyear;
    }

    public override void Print()
    {
        Console.WriteLine($"My name is {Name} , My age is {Age} , and my salary is {Salary}");
    }
}



















public class Database
{
    int current_index;
    public Person[] People = new Person[50];

    public void AddStudent(Student student)
    {
        People[current_index++] = student;
    }

    public void AddStaff(Staff staff)
    {
        People[current_index++] = staff;
    }

    public void AddPerson(Person person)
    {
        People[current_index++] = person;
    }

    public void PrintAll()
    {
        for (int i = 0; i < current_index; i++)
        {
            People[i].Print();
        }
    }
}










public class Program
{
    private static void Main()
    {
        var database = new Database();
        while (true)
        {
            Console.WriteLine("1) Staff \n2) Student \n3) Other \n4) Print All");
            Console.Write("Your Option :");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Age: ");
                    var age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Salary: ");
                    var salary = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Join year :");
                    var joinyear = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        var staff = new Staff(name, age, salary, joinyear);
                        database.AddStaff(staff);
                    }
                    catch (Exception ex1)
                    {
                        Console.WriteLine(ex1.Message);
                    }
                    break;

                case 2:
                    Console.Write("Name: ");
                    var name2 = Console.ReadLine();
                    Console.Write("Age: ");
                    var age2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Year: ");
                    var year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("GPA :");
                    var gpa = Convert.ToSingle(Console.ReadLine());
                    try
                    {
                        var student = new Student(name2, age2, year, gpa);
                        database.AddStudent(student);
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine(ex2.Message);
                    }
                    break;

                case 3:
                    Console.Write("Name: ");
                    var name3 = Console.ReadLine();
                    Console.Write("Age: ");
                    var age3 = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        var person = new Person(name3, age3);
                        database.AddPerson(person);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 4:
                    database.PrintAll();
                    break;

                default:
                    Console.WriteLine("Please enter valid option =)");
                    break;
            }
        }
    }
}


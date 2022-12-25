using System;

namespace oop;

public class Department
{
    public string Name;
    public float Compensation;

    public Department(string name, float compensation)
    {
        Name = name;
        Compensation = compensation;
    }

    // public double getSalary(int salary, int workingDays)
    // {
    //     return (salary * workingDays) + (salary * workingDays) * (Compensation / 100);
    // }

    public void Print()
    {
        Console.WriteLine($"Name is {Name} , Compensation is {Compensation}");
    }
}

public class Employee
{
    public string FirstName;
    public string LastName;
    public int Salary;
    // Department Department;
    public string DepName;

    public Employee(string firstName, string lastName, int salary,string depName)
    //  Department department
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        // Department = department;
        DepName=depName;
    }

    // public double getSalary(int workingDays)
    // {
    //     return Department.getSalary(Salary, workingDays);
    // }

    public void Print()
    {
        Console.WriteLine(
            $"First Name is {FirstName} , Last Name is {LastName} , Salary is {Salary} , Department is {DepName}"
        );
    }
}











public class Database
{
    int currentIndex1;
    int currentIndex2;

    public Department[] departments = new Department[10];
    public Employee[] employees = new Employee[50];

    public void AddDepartment(Department department)
    {
        departments[currentIndex1++] = department;
    }

    public void AddEmployee(Employee employee)
    {
        employees[currentIndex2++] = employee;
    }

    public void PrintDepartment()
    {
        for (int i = 0; i < currentIndex1; i++)
        {
            departments[i].Print();
        }
    }

    public void PrintEmployee()
    {
        for (int i = 0; i < currentIndex2; i++)
        {
            employees[i].Print();
        }
    }
}

public class Program
{
    public static void Main()
    {
        var database = new Database();
        while (true)
        {
            Console.WriteLine("1)DDEPARTMENT \n2)EMPLOYEE \n3)PRINT DEPARTMENT \n4)PRINT EMPOLEE");
            Console.Write("OPTION : ");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Name : ");
                    var name = Console.ReadLine();

                    Console.Write("Compensation : ");
                    var compensation = Convert.ToInt32(Console.ReadLine());

                    var department = new Department(name, compensation);
                    database.AddDepartment(department);
                    break;

                case 2:
                    Console.Write("First Name : ");
                    var firstName = Console.ReadLine();

                    Console.Write("Last Name : ");
                    var lastName = Console.ReadLine();

                    Console.Write("Salary : ");
                    var salary = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Department Index : ");
                    var departmentIndex = Convert.ToInt32(Console.ReadLine());

                    var employee = new Employee(firstName, lastName, salary, database.departments[departmentIndex].Name);//without .Name
                    database.AddEmployee(employee);
                    break;

                case 3:
                    database.PrintDepartment();
                    break;

                case 4:
                    database.PrintEmployee();
                    break;

                default:
                    Console.WriteLine("Please Enter Correct Option =)");
                    break;
            }
        }
    }
}

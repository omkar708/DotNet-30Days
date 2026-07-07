using System;

//created delegate for calculate it will return int type with getting int a and b as arguments
delegate int Calculate(int a, int b);

class Program
{
    //method for add value
    static int Addval(int a, int b)
    {
        return a + b;
    }

    //method for substract value
    static int Subval(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        //calling delegate for addval
        Calculate AddDelegate = Addval;
        int addition = AddDelegate(10, 15);
        Console.WriteLine(addition);

        //calling delegate for subval
        Calculate SubDelegate = Subval;
        int substraction = SubDelegate(10, 15);
        Console.WriteLine(substraction);

        //created func which get paramter int a, b and return int
        Func<int, int, int> Mul = (a, b) => a * b;
        Console.WriteLine(Mul(10, 20));

        //creating action whici don't return anything
        Action<string> showname = name => Console.WriteLine(name);
        showname("Omkar");

        //createing predicate which return true or false depend on condition
        Predicate<int> evenno = number => number % 2 == 0;
        Console.WriteLine( evenno(5));

        List<Employee> employees = new()
        {
            new () { Id = 101, Name = "Omkar", Salary = 50000 },
            new () { Id = 102, Name = "Rahul", Salary = 65000 },
            new () { Id = 103, Name = "Amit", Salary = 45000 },
            new () { Id = 104, Name = "Neha", Salary = 70000 },
            new () { Id = 105, Name = "Priya", Salary = 55000 }
        };

        //labmda LINQ to get salary > 50000
        var resultset = employees.Where(e => e.Salary > 50000);
        foreach (Employee employee in resultset)

        {
            Console.WriteLine(employee.Name);
        }
    }
}
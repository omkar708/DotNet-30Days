using System;

//created integer type data
Storage<int> num = new Storage<int>();
num.data = 100;
num.Display(num.data);

//created string type data
Storage<string> str = new Storage<string>();
str.data = "ABC";
str.Display(str.data);

//craeted class type data
Storage<Employee> emp = new Storage<Employee>();
emp.data = new Employee();
{
    emp.data.Id = 1;
    emp.data.Name = "Test";
    emp.data.Salary = 100;
}
emp.Display(emp.data);

//call to generic method
Show.Print("Omkar");
Show.Print(100);
Show.Print(5000.50);

//call to extension method
string name = "Omkar";
name.StringLength();

//craeted service for emplyee class
EmployeeService<Employee> service = new();
Employee emp1 = new Employee
{
    Id = 101,
    Name = "Omkar",
    Salary = 50000
};
service.Display(emp1);

//creating generic class (T for type)
class Storage<T>
{
    public T? data { get; set; }

    public void Display(T data)
    {
        Console.WriteLine(data);
    }
}

//generic method
public static class Show
{
    public static void Print<T>(T value)
    {
        Console.WriteLine(value);
    }
}

//extension function
static class StringExt
{
    public static void StringLength(this string val)
    {
        Console.WriteLine(val.Length);
    }
}

//employee service derived from Employee
class EmployeeService<T> where T : Employee
{
    public void Display(T employee)
    {
        Console.WriteLine($"Id : {employee.Id}");
        Console.WriteLine($"Name : {employee.Name}");
        Console.WriteLine($"Salary : {employee.Salary}");
    }
}


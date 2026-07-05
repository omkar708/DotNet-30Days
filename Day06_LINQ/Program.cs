using System;

List<Employee> employees = new List<Employee>
{
    new Employee { Id = 101, Name = "Omkar", Salary = 50000 },
    new Employee { Id = 102, Name = "Rahul", Salary = 65000 },
    new Employee { Id = 103, Name = "Amit", Salary = 45000 },
    new Employee { Id = 104, Name = "Neha", Salary = 70000 },
    new Employee { Id = 105, Name = "Priya", Salary = 55000 }
};

//to add where condition on column
var highSalaryEmployees =
    employees.Where(emp => emp.Salary > 55000);


foreach (var emp in highSalaryEmployees)
{
    Console.WriteLine($"{emp.Name} {emp.Salary}");
}

//select only names from data
var names =
    employees.Select(emp => emp.Name);

foreach (var name in names)
{
    Console.WriteLine(name);
}

//to sort on column asc
var sortedasc =
    employees.OrderBy(emp => emp.Salary);

foreach (var emp in sortedasc)
{
    Console.WriteLine($"{emp.Name} {emp.Salary}");
}

//sort on column dsc
var sorteddsc =
    employees.OrderByDescending(emp => emp.Salary);

foreach (var emp in sorteddsc)
{
    Console.WriteLine($"{emp.Name} {emp.Salary}");
}

//get first or default
var employee =
    employees.FirstOrDefault(emp => emp.Id == 103);

Console.WriteLine(employee?.Name);

//check for Any (if exist)
bool exists =
    employees.Any(emp => emp.Name == "Rahul");

Console.WriteLine(exists);

//get the count of total data
int total =
    employees.Count();

Console.WriteLine(total);

//count with condtion
int highSalary =
    employees.Count(emp => emp.Salary > 50000);
Console.WriteLine(highSalary);

//to get data group by
var groups =
    employees.GroupBy(emp => emp.Salary > 50000);

foreach (var group in groups)
{
    Console.WriteLine(group.Key);

    foreach (var emp in group)
    {
        Console.WriteLine(emp.Name);
    }
}
using System;

List<Employee> employee = new List<Employee>();
employee.Add(new Employee
{
    Id = 1,
    Name = "Foo",
    Salary = 2000
});
employee.Add(new Employee
{
    Id = 2,
    Name = "Boo",
    Salary = 3000
});
employee.Add(new Employee
{
    Id = 3,
    Name = "Zoo",
    Salary = 4000
});
employee.Add(new Employee
{
    Id = 1,
    Name = "Roo",
    Salary = 1000
});
employee.Add(new Employee
{
    Id = 1,
    Name = "Ooo",
    Salary = 2000
});



foreach (var item in employee)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Salary);
}


    Dictionary<int, string> employees = new Dictionary<int, string>();

    employees.Add(101, "Emp1");
    employees.Add(102, "Emp2");
    employees.Add(103, "Emp3");
    employees.Add(104, "Emp4");
    employees.Add(105, "Emp5");

    foreach (var emp in employees)
    {
        Console.WriteLine(emp);
    }

    HashSet<string> Alphabets = new HashSet<string>();
    Alphabets.Add("ABC");
    Alphabets.Add("XYZ");
    Alphabets.Add("PQR");

    //this will remove as duplicate not store in hashset
    Alphabets.Add("ABC");

    foreach (var alpha in Alphabets)
    {
        Console.WriteLine(alpha);
    }

    Queue<string> queue = new Queue<string>();

    queue.Enqueue("Customer1");
    queue.Enqueue("Customer2");
    queue.Enqueue("Customer3");
    queue.Enqueue("Customer4");
    queue.Enqueue("Customer5");

    foreach (var que in queue)
    {
        Console.WriteLine(que);
    }

    Stack<string> stack = new Stack<string>();
    stack.Push("Page1");
    stack.Push("Page2");
    stack.Push("Page3");

    foreach (var itm in stack)
    {
        Console.WriteLine(itm);
    }

    stack.Pop();

    foreach (var itm in stack)
    {
        Console.WriteLine(itm);
    }
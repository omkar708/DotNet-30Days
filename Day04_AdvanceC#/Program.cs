
Employee emp = new Employee("Omkar", 26, "A834");
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Department);
Console.WriteLine(emp.EmployeeCode);
Console.WriteLine(emp.Age);
Console.WriteLine(emp.Company);

class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }

    //created constructor for Person to set Name and Age
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

}

//Inherited Employee from Person
class Employee : Person
{
    public string Department = "IT";
    public string Company = "Yash";
    public readonly string EmployeeCode;

    //get the values of name and age from base class
    public Employee(string name, int age, string employeecode) : base(name, age)
    {
        EmployeeCode = employeecode;
    }
}
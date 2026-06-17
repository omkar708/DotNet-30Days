Employee emp = new Employee();
emp.SetSalary(5000);
Console.WriteLine("The salary is : " + emp.GetSalary());
Console.WriteLine($"Salary is {emp.GetSalary()}");

Manager mngr = new Manager();
mngr.SetSalary(8000);
Console.WriteLine("The salary is : " + mngr.GetSalary());
Console.WriteLine($"Salary is {mngr.GetSalary()}");

class Employee()
{
    public int Id;
    public string Name = "";
    private decimal Salary;

    public void SetSalary(decimal amount)
    {
        Salary = amount;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
}

class Manager : Employee
{
    public string department = "Management";
}

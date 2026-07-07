using System.Linq.Expressions;

int num1 = 10;
int num0 = 0;

try 
{
    Console.WriteLine(num1 / num0);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("This is finally block");
}

try
{
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 18)
    {
        throw new InvalidAgeException("Age should be greater than 18");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("This is finally block");
}


class InvalidAgeException : Exception
{
    public InvalidAgeException(string? message) : base(message)
    {
    }
}


class EmployeeService()
{
    public void EmpService() { }
}

class EmailService()
{
    public void EmService() { }
}

class ReportService()
{
    public void repService() { }
}
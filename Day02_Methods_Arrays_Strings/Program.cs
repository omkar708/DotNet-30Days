
using static System.Runtime.InteropServices.JavaScript.JSType;

int num1, num2, adn;
Console.WriteLine("Enter Number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number =: ");
num2 = Convert.ToInt32(Console.ReadLine());

adn = addnumber(num1, num2);
Console.WriteLine(adn);
static int addnumber(int a, int b)
{
    Console.WriteLine(a + b);
    return a + b;
}

int[] numbrs= { 10, 20, 30 };

foreach (int numbr in numbrs)
{
    Console.WriteLine(numbr);

}

for (int i = 0; i < numbrs.Length; i++)
{
    Console.WriteLine(numbrs[i]);
}

string name;
name = "Omkar";
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());
Console.WriteLine(name.Length);

try
{
    int a = 4;
    int b = 0;

    int result = a / b;
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("Completed");
}
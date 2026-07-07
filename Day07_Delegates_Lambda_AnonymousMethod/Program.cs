using System;

delegate int Calculate(int a, int b);

class Prgram
{
    public int a; public int b;
    static int Addval( int a, int b)
    {
        return a + b;
    }

    static int Subval( int a, int b)
    {
        return a - b;
    }

    static void main()
    {
        Calculate cal1 = Addval;
        int addition = Addval(10, 15);
        Console.WriteLine( addition );

        Calculate cal2 = Subval;
        int substraction = Subval(10, 15);
        Console.WriteLine(substraction );
    }

}
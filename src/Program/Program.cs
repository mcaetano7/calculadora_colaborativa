﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));


//esta clase implementa la suma
public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Esta clase implementa la operación <Substraction>
public class Substraction
{
    public static int Substract(int a, int b)
    {
        return a - b;

    }
}

//Esta clase implementa la operación multiplicacón
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return 0;
    }
}

// Esta clase Implementa la operación <Division>
public class Division
{
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}
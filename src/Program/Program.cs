﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
//Esta clase implementa la operación multiplicacón
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}
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
﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));


// Esta clase implementa la operación <Substraction>
public class Substraction
{
    public static int Substract(int a, int b)
    {
        return a - b;
    }
}
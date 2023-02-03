using System;
public class Exercise1
{
    public static void Main()
    {
        // Tính +-*/ (Khôi 20mc -20it438)
        int x, y;
        char operation;

        Console.Write("Nhap so t1: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Phep tinh: ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Nhap so t2: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (operation == '+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        else if (operation == '-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        else if ((operation == 'x') || (operation == '*'))
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        else if (operation == '/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        else
            Console.WriteLine("Wrong");
    }
}
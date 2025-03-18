using System;

class Program
{
    static void Main()
    {
        int result;

        for (int num = 1; num <= 10; num++)
        {
            for (int num2 = 1; num2 <= 10; num2++)
            {
                result = num * num2;
                Console.WriteLine(num + "*" + num2 + "=" + result);
            }
        }
    }
}

using System;

class Programm
{
    static void Main(string[] third_num)
    {
        Console.WriteLine("Введите 5-ти значное число");
        int numb = Convert.ToInt32(Console.ReadLine());
        numb = Math.Abs(numb);

        if (numb < 100000 && numb >= 10000)
        {
            int a = numb / 10000;
            int b = numb % 10;
            int c = (numb / 1000) % 10;
            int d = (numb % 100) / 10;

            if (a == b)
            {
                if (c == d)
                {
                    Console.WriteLine("Это числовой палиндром");
                }
            }
            else
            {
                Console.WriteLine("Это не числовой палиндром");
            }
        }
        else
        {
            Console.WriteLine("Введите число согласно условиям задачи");
        }
    }
}
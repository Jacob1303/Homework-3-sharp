using System;

class Programm
{
    static void Main(string[] cube_numb)
    {
        Console.WriteLine("Введите число ");
        int numb = Convert.ToInt32(Console.ReadLine());

        double cube = 1;

        for (int i = 1; i <= numb; i++ )
        {
            cube = Math.Pow(i, 3);
            Console.Write(cube + ", ");
        }
        Console.Write("таблица кубов чисел от 1 до введённого Вами числа.");
    }
}
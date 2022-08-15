using System;

class Programm
{
    static void Main(string[] Dist_betw_points)
    {
        Console.WriteLine("Введите поочерёдно координаты точки 1 (x,y,z)");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите поочерёдно координаты точки 2 (x,y,z)");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        int z2 = Convert.ToInt32(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));

        Console.Write("Расстояние между точками 1 и 2 равно ");
        Console.WriteLine(Math.Round(distance, 2));
    }
}
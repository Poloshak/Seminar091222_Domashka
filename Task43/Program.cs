﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double KoordinatyTochkiPeresecheniya (string[] koord)
{
    double b1 = int.Parse(koord[0]);
    double k1 = int.Parse(koord[1]);
    double b2 = int.Parse(koord[2]);
    double k2 = int.Parse(koord[3]);
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
    return x;
    return y;
}
Console.Clear();
Console.WriteLine("Введите b1, k1, b2 и k2 через пробел: ");
string[] K = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
KoordinatyTochkiPeresecheniya(K);


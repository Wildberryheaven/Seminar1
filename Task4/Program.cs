﻿Console.Write("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}
Console.WriteLine("Max = " + max);
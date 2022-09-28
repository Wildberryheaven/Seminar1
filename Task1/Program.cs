Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 / number1)
{
    Console.WriteLine($"Первое число ({number1}) является квадратом второго ({number2})");
}
else
{
    Console.WriteLine($"Первое число ({number1}) не является квадратом второго ({number2})");
}
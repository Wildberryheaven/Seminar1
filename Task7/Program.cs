Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 10;
Console.WriteLine($"Последняя цифра числа {number} равна: {number1}");
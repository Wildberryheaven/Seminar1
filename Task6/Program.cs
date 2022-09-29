Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) {
    Console.WriteLine($"Число {number} чётное");
} else {
    Console.WriteLine($"Число {number} нечётное");
}
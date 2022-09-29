Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number && i >= 1) {
    if (i % 2 == 0) {
        Console.Write(i + " ");
    }
    i++;
}
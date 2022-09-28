Console.Write("Введите целое число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbercheck = -number;
while (numbercheck <= number) {
    Console.Write(numbercheck + " ");
    numbercheck++;
}
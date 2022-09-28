Console.Clear();
Console.Write("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a == b) {
    Console.WriteLine("a = b");
} else { 
    if (a > b) {
    max = a;
    Console.WriteLine("Max = " + max);
    min = b;
    Console.WriteLine("Min = " + min);
    } else {
        max = b;
        Console.WriteLine("Max = " + max);
        min = a;
        Console.WriteLine("Min = " + min);
    }
} 
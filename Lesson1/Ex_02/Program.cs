Console.WriteLine("Програма для сравнения чисел: вы напишите два числа а мы скажем какое больше");
Console.WriteLine("Напишите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.WriteLine($"Число {a} больше");
} else {
    Console.WriteLine($"Число {b} больше");
}
Console.WriteLine("Програма для сравнения чисел: вы напишите три числа а мы скажем какое больше");
Console.WriteLine("Напишите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) {
    Console.WriteLine($"Число {a} больше");
} else if (b > a && b > c){
    Console.WriteLine($"Число {b} больше");
} else {
    Console.WriteLine($"Число {c} больше");
}

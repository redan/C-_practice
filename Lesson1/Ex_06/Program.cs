Console.WriteLine("Програма для проверки числа на четность");
Console.WriteLine("Введите число для проверки");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 0){
    Console.WriteLine("Это ноль!");
} else if (a % 2 == 0 ) {
    Console.WriteLine($"Число {a}  четное.");
} else {
    Console.WriteLine($"Число {a} не четное.");
}

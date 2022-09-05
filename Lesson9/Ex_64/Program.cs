Console.WriteLine("Задайте значения M и N. Программа выведет все натуральные числа в промежутке от M до N");
Console.WriteLine("Задайте m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте n");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = m; i <= n;i++){
    Console.Write(i + " ");
}
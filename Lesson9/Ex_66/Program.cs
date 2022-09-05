Console.WriteLine("Задайте значения M и N. Программа найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Задайте m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте n");
int n = Convert.ToInt32(Console.ReadLine());

int res = 0;
for(int i = m; i <= n;i++){
    res += i;
}

Console.Write(res);
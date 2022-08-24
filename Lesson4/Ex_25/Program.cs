int toPow( int num, int pow) {
    int res = num;
    for (int i = 1; i < pow; i++) {
        res = res * num;
    }
    return res;
}

Console.WriteLine("Напишите какое число возвести в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите в какую степень возвести число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получается:");
Console.WriteLine(toPow(a,b));
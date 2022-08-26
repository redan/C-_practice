Console.WriteLine("Напиши числа, а мы проверем сколько из них больше нуля, для выхода напишите 666");



var num = Convert.ToInt32(Console.ReadLine());
int countMoreZero = 0;


while(num != 666){
    if(num > 0) {
        countMoreZero++;
    }
    Console.WriteLine("Напиши числа, а мы проверем сколько из них больше нуля, для выхода напишите 666");
    num = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Результат:");
Console.WriteLine(countMoreZero);
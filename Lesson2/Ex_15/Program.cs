Console.WriteLine("Напишите нормер дн недели а мы скажем вам выходной ли он");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
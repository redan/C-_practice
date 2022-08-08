Console.WriteLine("Программа, которая покажет все четные числа до Х");
Console.WriteLine("Напишите число");
int x = Convert.ToInt32(Console.ReadLine());
List<int> nums = new List<int>();
for (int i = 0; i < x; i++){
    if (i % 2 == 0 && i != 0) {
        nums.Add(i);
    }
}
Console.WriteLine($"Ниже все четные числа от 0 до {x}");
foreach (int num in nums){
    Console.WriteLine(num);
}

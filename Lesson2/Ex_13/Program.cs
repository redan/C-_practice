Console.WriteLine("Напишите 3 значное число");

int num = Convert.ToInt32(Console.ReadLine());

var nums = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

if(nums.Length < 3){
    Console.WriteLine("В вашем числе нет 3 цифры");
} else {
    Console.WriteLine(nums[3]);
}
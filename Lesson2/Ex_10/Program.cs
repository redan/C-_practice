Console.WriteLine("Напишите 3-х значное число");

int num = Convert.ToInt32(Console.ReadLine());

var nums = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();


Console.WriteLine(nums[1]);

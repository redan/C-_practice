Console.WriteLine("Напишите первую координату (3 цифры через , (символ запятой)");

string num = Console.ReadLine();

var nums = num.Split(',');
int[] pointA = new int[3];
for(int i = 0; i < pointA.Length; i++) {
    pointA[i] = Convert.ToInt32(nums[i]);
}
Console.WriteLine("Напишите вторую координату (3 цифры через , (символ запятой)");

string num2 = Console.ReadLine();

var nums2 = num2.Split(',');
int[] pointB = new int[3];
for(int i = 0; i < pointB.Length; i++) {
    pointB[i] = Convert.ToInt32(nums2[i]);
}
var res = Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2)+Math.Pow(pointA[1]-pointB[1], 2)+Math.Pow(pointA[2]-pointB[2], 2));

Console.WriteLine("Результат:");
Console.WriteLine(Math.Round(res,2));
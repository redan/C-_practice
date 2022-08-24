Console.WriteLine("Напишите число");

int num = Convert.ToInt32(Console.ReadLine());



int arrToSum(int num) {
    var nums = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    int res = 0;
    for(int i = 0; i < nums.Length; i++){
        res = nums[i] + res;
    }
    return res;
}


Console.WriteLine(arrToSum(num));
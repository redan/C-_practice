Console.WriteLine("Напишите число");

int num = Convert.ToInt32(Console.ReadLine());

var nums = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
int[] numsRewers = new int[nums.Length];
for (int i = 0; i < nums.Length; i++) {
    numsRewers[i] = nums[nums.Length-i-1];
}


Console.WriteLine(Enumerable.SequenceEqual(nums, numsRewers));
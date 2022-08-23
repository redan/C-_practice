Console.WriteLine("Напишите число до которого возводить все в квадраты");

int N = Convert.ToInt32(Console.ReadLine());

int[] resArr = new int[N];

for (int i = 0; i < N; i++) {
    resArr[i] = Convert.ToInt32(Math.Pow(i+1, 3));
}

foreach (int res in resArr) {
    Console.Write(res + " ");
}
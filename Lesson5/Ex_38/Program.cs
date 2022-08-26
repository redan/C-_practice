int[] arrOfRandom(int count) {
    Random rnd = new Random();
    int[] res = new int[count]; 
    for(int i = 0; i < count; i++){
        res[i] = rnd.Next(1,100);
    }
    return res;
}

Console.WriteLine("Напиши из скольких чисел будет массив");

int arrCount = Convert.ToInt32(Console.ReadLine());

var arrayOfRandom = arrOfRandom(arrCount);

for(int i = 0; i< arrayOfRandom.Length;i++){
    Console.Write(arrayOfRandom[i] + " ");
}
Console.WriteLine(" ");
int diffMaxMin(int[] arr){
    int res = 0;
    int max = 0;
    int min = arr[0];
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < min) {
            min = arr[i];
        }
        if(arr[i] > max){
            max = arr[i];
        }
    }
    res = max - min;
    return res;
}
Console.WriteLine("Результат:");
Console.WriteLine(diffMaxMin(arrayOfRandom));
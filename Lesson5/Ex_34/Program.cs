﻿int[] arrOfRandom(int count) {
    Random rnd = new Random();
    int[] res = new int[count]; 
    for(int i = 0; i < count; i++){
        res[i] = rnd.Next(100,1000);
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
int howMatchEven(int[] arr){
    int res = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] % 2 == 0){
            res++;
        }
    }
    return res;
}
Console.WriteLine("Результат:");
Console.WriteLine(howMatchEven(arrayOfRandom));
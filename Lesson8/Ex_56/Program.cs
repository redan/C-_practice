Console.WriteLine("Задайте размер двумерного массив m X n мы заполним его случайными числами и остортивуем в порядке уменьшения");
Console.WriteLine("Задайте m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте n");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

void randToArr(int[,]  ar){
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            ar[i,j] = rand.Next(1,100);
        }
    }
}

void printArr(int[,] ar){
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            Console.Write(ar[i, j] + "     ");
        }
        Console.WriteLine("");
    }
}

int smalestArr(int[,] ar){
    int smallestSum = 0;
    int[] res = new int[ar.GetLength(0)];
    int[] tmpArr = new int[ar.GetLength(1)];
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            tmpArr[j] = ar[i,j];
        }
        res[i] = sumOfArr(tmpArr);
        smallestSum = res[i];
    }
    for(int i = 0; i < res.Length; i++){
        if(res[i] < smallestSum){
            smallestSum = res[i];
        }
    }
    for(int i = 0; i < res.Length; i++){
        if(res[i] == smallestSum){
            return i;
        }
    }
    return -1; 
}


int sumOfArr(int[] ar){
    int sum = 0;
    for(int i = 0; i < ar.Length;i++){
        sum = sum + ar[i];
    }
    return sum;
}

int[,] arr = new int[m , n];
randToArr(arr);
printArr(arr);
Console.WriteLine(smalestArr(arr));

Console.WriteLine("Задайте размер двумерного массив m X n");
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

void avgOfEveryColsArr(int[,] ar){
    float[] resArr = new float[ar.GetLength(1)];
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            resArr[j] = resArr[j] + ar[i,j];
        }
    }
    for(int i = 0; i < resArr.Length; i++){
        resArr[i] = resArr[i] / ar.GetLength(1);
    }
    for(int i = 0; i < resArr.Length; i++){
        Console.Write(resArr[i] + " ");
    }
}



int[,] arr= new int[m , n];
randToArr(arr);
printArr(arr);
avgOfEveryColsArr(arr);


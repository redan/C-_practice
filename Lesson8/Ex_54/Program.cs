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
void sortArr(int[,] ar){
    //int[,] ress = new int[ar.GetLength(0), ar.GetLength(1)];
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1) -1; j++){
            for (int k = j + 1; k < ar.GetLength(1); k++){
                if (ar[i,j] < ar[i,k]){
                    int tmp = ar[i,k];
                    ar[i,k] = ar[i,j];
                    ar[i,j] = tmp;
                }
            }
        }
    }
}

int[,] arr = new int[m , n];
randToArr(arr);
printArr(arr);
Console.WriteLine("");
sortArr(arr);
printArr(arr);
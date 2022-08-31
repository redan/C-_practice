Console.WriteLine("Задайте размер двумерного массив m X n, заполненный случайными вещественными числами.");
Console.WriteLine("Задайте m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте n");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

void randToArr(double[,]  ar){
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            ar[i,j] = Math.Round(rand.NextDouble() * 100, 2) ;
        }
    }
}

void printArr(double[,] ar){
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            Console.Write(ar[i, j] + "     ");
        }
        Console.WriteLine("");
    }
}


double[,] arr= new double[m , n];
randToArr(arr);
printArr(arr);
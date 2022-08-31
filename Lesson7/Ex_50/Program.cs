Console.WriteLine("Напишите координаты искомого элемента (m X n");
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

void searchElem(int a, int b, int[,] ar){
    for(int i = 0; i < ar.GetLength(0); i++){
        for(int j = 0; j < ar.GetLength(1); j++){
            if(i == a && j == b) {
                Console.WriteLine(ar[a-1,b-1]);
                return;
            }
        }
    }
    Console.WriteLine("elem not found");
}


int[,] arr= new int[5 , 6];
randToArr(arr);
printArr(arr);
searchElem(m,n, arr);
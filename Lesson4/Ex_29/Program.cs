int[] arrOfRandom(int count) {
    Random rnd = new Random();
    int[] res = new int[count]; 
    for(int i = 0; i < count; i++){
        res[i] = rnd.Next(1,100);
    }
    return res;
}

var res = arrOfRandom(8);
for(int i = 0; i< res.Length;i++){
    Console.Write(res[i] + " ");
}



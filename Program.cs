int[] A = new int[21];

Random rnd = new Random();

for (int i = 0; i < A.Length; i++){
    A[i] = rnd.Next(1, 37);
}

int n = 0;
int len = A.Length;
int k = 1;

while (len > 0){
    len -= k;
    n++;
    k++;
}

int[,] B = new int[n, n];

int ai = 0;

while (ai < A.Length){
    for (int j = 0; j < n; j++){
        for (int l = 0; l < n; l++){
            if (l <= j){
                B[j, l] = A[ai];
                ai++;
            }
        }
    }
}

Console.WriteLine($"Из массива |{String.Join(',', A)}| получена матрица:");
for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        Console.Write(B[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        if (j < i){
            B[j, i] = B[i, j];
            B[i, j] = 0;
        }
    }
}

Console.WriteLine("После отзеркаливания матрицы В получена матрица:");
for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        Console.Write(B[i, j] + "\t");
    }
    Console.WriteLine();
}
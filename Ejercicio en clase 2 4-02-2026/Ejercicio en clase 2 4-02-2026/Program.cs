// Author: Omar Ernesto Flores de Hoyos - 181268
int n = 2, m = 5;
int [,]myMatrix = {{1,2,3,4,5},{6,7,8,9,10}};

for (int i = 0; i < n; i++) {
    Console.WriteLine();
    for (int j = 0; j < m; j++)
    {
        Console.Write(myMatrix[i, j] + " ");
    }
}
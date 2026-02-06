// Author: Omar Ernesto Flores de Hoyos - 181268

int[,] myMatrix = {{1,2,3},{4,5,6},{7,8,9}};
int suma = 0;
int n = 3, m = 3;

for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++)
    {
       suma += myMatrix[i,j];
    }
}
Console.WriteLine(suma);
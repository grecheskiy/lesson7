//В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] matrix = new int[5, 9];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("line with minsum: " + MinSumMatrix(matrix));

void FillMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(0,100);}}}

void PrintMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

int MinSumMatrix(int[,] matr)
{int MinSum = 0;
int temp = 0;
int num = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{MinSum += matr[0, j];
temp += matr[i, j];
if (temp < MinSum)
{MinSum = temp;
num = i;}}
temp = 0;}
return num;}

//{if (i == 0) 
//{sum += matr[i, j];
//minSum += matr[i, j];}
//else sum += matr[i, j];
//if (sum < minSum)
//{minSum = sum;
//minNum = m;}
//sum = 0;}
//return minNum;
//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Write("Enter numbre of lines: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter number of columns: ");
int m = int.Parse(Console.ReadLine() ?? "");
int[,] matrix = new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
DescendMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

void FillMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(0,100);}}}

void PrintMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

void DescendMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{for (int k = 0; k < matr.GetLength(1)-j-1; k++)
{if (matr[i, k+1] > matr[i, k]) 
{int temp = matr[i, k+1];
matr[i, k+1] = matr[i, k];
matr[i, k] = temp;
}}}}}
//Написать программу, которая обменивает элементы первой строки и последней строки.
Console.Write("Enter number of lines: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter number of columns: ");
int m = int.Parse(Console.ReadLine() ?? "");
int[,] matrix= new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
ExchangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

void FillMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(0,100);}}}

void PrintMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

void ExchangeMatrix(int[,] matr)
{int temp = 0;
for (int i=0; i<matr.GetLength(1); i++)
{temp = matr[matr.GetLength(0)-1, i];
matr[matr.GetLength(0)-1, i] = matr[0, i];
matr[0, i] = temp;}}
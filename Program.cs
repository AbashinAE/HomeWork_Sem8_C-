// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine()!);

if(columnsA != rowsB)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));

//---------------метод перемножения матриц
int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
  int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  for (int i = 0; i < arrayA.GetLength(0); i++)
  {
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        arrayC[i,j]+=arrayA[i,k]*arrayB[k,j];
      }
    }

  }
  return arrayC;
}




// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
   int[,] res = new int[m, n];

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      res[i, j] = new Random().Next(minValue, maxValue+1);
    }
  }
  return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
          }
    Console.WriteLine();
  }
}
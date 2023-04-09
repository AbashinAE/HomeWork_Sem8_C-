// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
//Console.Write("Введите размер массива m: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите размер массива n: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.Write("Введите размер массива m: ");
// int k = int.Parse(Console.ReadLine()!);

int m = 2;
int n = 2;
int k = 2;
int[,,] arr = new int[m, n, k];
CreateArray(arr);
GetArray(arr);
PrintArray(arr);

//--------------- метод заполнения массива
void GetArray(int[,,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      for (int k = 0; k < massive.GetLength(2); k++)
      {
        arr[i, j, k] = new Random().Next(10, 99);
      }
    }

  }
}

// -----------------Вывод массива-----------------
void PrintArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
             }
    }
    Console.WriteLine();
  }
}

//-----------------метод вычесления неповторяющихся элементов

void CreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < array.GetLength(0); m++)
  {
    for (int n = 0; n < array.GetLength(1); n++)
    {
      for (int l = 0; l < array.GetLength(2); l++)
      {
        array[m, n, l] = temp[count];
        count++;
      }
    }
  }
}

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[]rowAr=GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

//--------------метод формирования из двумерного в одномерный массив

int[] GetRowArray(int[,] inArray)
{
  int[] ressult = new int[inArray.GetLength(0)*inArray.GetLength(1)];
  int index=0;
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
  for (int j = 0; j < inArray.GetLength(1); j++)
  {
    ressult[index]=inArray[i,j];
    index++;
    }
  }
    return ressult;
}

//---------метод сортировки одномерного массива---------
void SortArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = i+1; j < array.Length; j++)
    {
      if (array[i]>array[j])
      {
        int temp=array[i];
        array[i]=array[j];
        array[j]=temp;
      }
    }
  }
}

//-------------метод подсчета колличества найденных элеменов
void PrintData(int[] array)
{
  int el=array[0];
  int count = 1;
  for (int i = 1; i < array.Length; i++)
  {
    if(array[i]!=el)
    {
      Console.WriteLine($"{el} встречается {count}");
      el=array[i];
      count=1;
    }
    else
    {
      count++;
    }
  }
  Console.WriteLine($"{el} встречается {count}");
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
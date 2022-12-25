Console.Clear();

//Нобходимые функции:
// _________________________________________

int[,] GetArray(int m, int n, int minValue, int maxValue) //функция заполнения рандомного двумерного массива с ЦЕЛЫМИ числами для всех задач
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// _________________________________________

void PrintArray(int[,] inArray) //функция отображения массива целых чисел
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// ________________________________________

void SortedArray(int[,] array) // функция сортировки строк массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temporary;
                }
            }
        }
    }
}

// ________________________________________

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("Enter the rows number: ");
// int Rows = int.Parse(Console.ReadLine());

// Console.Write("Enter the columns number: ");
// int Columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(Rows, Columns, 0, 100);

// PrintArray(array);

// SortedArray(array);
// Console.WriteLine("Sortet array by Rowses: ");
// PrintArray(array);

// _______________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Enter the rows number: ");
// int Rows = int.Parse(Console.ReadLine());

// Console.Write("Enter the columns number: ");
// int Columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(Rows, Columns, 0, 10);

// PrintArray(array);

// int row = 0;
// int minSumm = 0;
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     minSumm += array[0, i];
// }
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int summ = 0;
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         summ += array[i, j];
//     }
//     if (minSumm > summ)
//     {
//         minSumm = summ;
//         row = i;
//     }

// }

// Console.WriteLine($"The number of less summ row's is: {row+1}"); 

// __________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Enter the first rows number: ");
// int Rows1 = int.Parse(Console.ReadLine());

// Console.Write("Enter the first columns number: ");
// int Columns1 = int.Parse(Console.ReadLine());

// Console.Write("Enter the second rows number: ");
// int Rows2 = int.Parse(Console.ReadLine());

// Console.Write("Enter the second columns number: ");
// int Columns2 = int.Parse(Console.ReadLine());

// if (Columns1 != Rows2)
// {
//     Console.Write("Умножение невозможно, столбцы и строки должны быть равны: ");
//     return;
// }

// int[,] array1 = GetArray(Rows1, Columns1, 0, 10);
// int[,] array2 = GetArray(Rows1, Columns1, 0, 10);

// PrintArray(array1);
// Console.WriteLine();
// PrintArray(array2);
// Console.WriteLine();

// PrintArray(CountMultyMatrix(array1, array2));

// int[,] CountMultyMatrix(int[,] array1, int[,] array2)
// {
//     int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 array3[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     return array3;
// }

// ________________________________________

// Задача 60.

Console.Write("Введите размеры массива через пробел: ");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array3D = GetArray3D(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]), }, 10, 99);
PrintArray3D(array3D);

int[,,] GetArray3D(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int elmnt)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j, k] == elmnt) return true;
            }
        }
    }
    return false;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
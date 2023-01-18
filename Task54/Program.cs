/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива.
*/

int[,] SetArray(int row, int col, int beginNum, int endNum)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }
}

void DescendingSortRowArr(int[,] arr)
{
    int[] sortArr = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sortArr[j] = arr[i, j];
        }
        BubbleSort(sortArr);
        for (int k = 0; k < sortArr.Length; k++)
        {
            arr[i, k] = sortArr[k];
        }
    }
}
Console.WriteLine();
Console.WriteLine("СФОРМИРУЕМ ДВУМЕРНЫЙ МАССИВ:");
Console.Write(" -количество строк = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" -количество столбцов = ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] myArray = SetArray(row, col, 1, 20);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Отсортированный двумерный массив по убыванию в каждой строке");
DescendingSortRowArr(myArray);
PrintArray(myArray);
Console.WriteLine();

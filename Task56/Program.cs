/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка
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

int SumArrayRow(int[,] arr, int indexRow) //функция для подсчета суммы заданной строки массива
{
    int sumRow = arr[indexRow, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
        sumRow += arr[indexRow, j];
    return sumRow;
}

int NumberRowArrayMinSum(int[,] arr)
{
    int rowNum = 0;
    int minSum = SumArrayRow(arr, 0); //присвоение минимальной суммы 1 строке массива
    //Console.WriteLine($"Сумма 0 индекса строк = {minAmount}");
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        //Console.WriteLine($"Сумма {i} индекса строк = {SumArrayRow(arr, i)}");
        if (SumArrayRow(arr, i) < minSum)
        {
            minSum = SumArrayRow(arr, i);
            rowNum = i;
        }
    }
    return rowNum + 1; //по условию выводим должны вывести реальный номер строки, а не его индекс
}
Console.WriteLine();
Console.WriteLine("СФОРМИРУЕМ ДВУМЕРНЫЙ МАССИВ:");
Console.Write(" -количество строк = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" -количество столбцов = ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] myArray = SetArray(row, col, 1, 10);
PrintArray(myArray);
int NumMinRow = NumberRowArrayMinSum(myArray);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {NumMinRow}-й строке");
Console.WriteLine();

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 
*/

int[,,] SetArrayNonRepeatElem(int row, int col, int dep)
{
    int[,,] arr = new int[row, col, dep];
    Queue<int> SequenceArr = new Queue<int>(Enumerable.Range(10, 90).OrderBy(_ => new Random().Next()));
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = SequenceArr.Dequeue();
            }
        }
    }
    return arr;
}

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
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
Console.WriteLine("Задан массив размером 2 x 2 x 2");
int[,,] myArray = SetArrayNonRepeatElem(2, 2, 2);
PrintArray(myArray);
Console.WriteLine();
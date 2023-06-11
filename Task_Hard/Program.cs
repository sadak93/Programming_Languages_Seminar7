// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

int [,] Sort (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                int imin = i;
                int jmin = j;
                for (int k = i; k < array.GetLength(0); k++)
                {
                    for (int m = j+1; m < array.GetLength(1); m++)
                        if (array[k,m]<array[imin,jmin])
                            {
                                imin = k;
                                jmin = m;
                            }
                    int temp = array[i,j];
                    array[i,j] = array[imin,jmin];
                    array[imin,jmin]=temp;
                }
            }    
        }
    return array;
}
// for (int i = 0; i < array2.Length-1; i++)
//     {
//         int imin = i;
//         for (int j = i+1; j < array2.Length; j++)
//         {
//             if (array2[j]<array2[imin])
//                 imin = j;
//         }
//         int temp = array2[i];
//         array2[i]=array2[imin];
//         array2[imin]=temp;
//     }
//     return array2;

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Sort(array);
PrintArray(Sort(array));
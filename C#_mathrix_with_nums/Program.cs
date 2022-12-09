// Заполнение матрицы числами


// int[,] mat = new int[3, 4]; //создаем двумерную таблицу чисел с параметрами 3 строки, 4 столбца

// void PrintMat(int [,] mathrix) //создаем функцию PrintMat, которая в качестве аргумента 
//                                 //принимает некую таблицу чисел
// {
//     for(int i = 0; i < mathrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < mathrix.GetLength(1); j++)
//         {
//             Console.Write($"{mathrix[i, j]} ");
//         }
//         Console.WriteLine();
//          }
// }
// PrintMat(mat);




void FillMat(int[,] rand) //создаем функцию FillMat, которая будет заполнять таблицу
                          //случайными числами
{
    for (int i = 0; i < rand.GetLength(0); i++)
    {
        for (int j = 0; j < rand.GetLength(1); j++)
        {
            rand[i, j] = new Random().Next(100, 900);
        }
}
}
void PrintMat(int[,] mathrix) //создаем функцию PrintMat для вывода на печать таблицы
{
    for (int i = 0; i < mathrix.GetLength(0); i++)
    {
        for (int j = 0; j < mathrix.GetLength(1); j++)
        {
            Console.Write($"{mathrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] mat = new int[3, 4]; //создаем двумерный массив чисел с параметрами 3 строки, 4 столбца

PrintMat(mat); //сначала выводим таблицу с нулями
FillMat(mat); // включаем заполнение
Console.WriteLine();// отделяем нулевую таблицу от заполненной
PrintMat(mat); //выводим заполненный массив

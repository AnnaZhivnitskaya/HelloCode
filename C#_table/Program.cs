// создание таблицы

//string[,] table = new string[2, 5]; // 2строки и 5 столбцов
//индексы так же начинаются с нуля
//String.Empty строки выводятся пустыми, ничего не содержат, если не задать значения
//table[0, 0]   table[0, 1]  table[0, 2]   table[0, 3]   table[0, 4] 
//table[1, 0]   table[1, 1]  table[1, 2]   table[1, 3]   table[1, 4] 

// table[1, 2] = "слово"; //так присваивается значение элементу таблицы (матрицы)

// for (int rows = 0; rows < 2; rows++)
// {      
//     for(int colomns = 0; colomns < 5; colomns++)
//     {
//         Console.WriteLine($"+{table[rows, colomns]}+");
//     }
// }

int[,] table = new int[5, 8]; // при int таблица выводит нули по умолчанию

for (int i = 0; i < table.GetLength(0); i++)// для того, чтобы указать кол-во строк, исп .GetLength(0)
{      
    for(int j = 0; j < table.GetLength(1); j++)//для того, чтобы указать кол-во строк, исп .GetLength(1)
    {
        Console.Write($"{table[i, j]} ");//выводим значение столбиков в линию
     }
     Console.WriteLine();// принудительно переходим на новую строку
 }